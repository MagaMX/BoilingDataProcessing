using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DocumentFormat.OpenXml.Spreadsheet;
using System.IO;


namespace BoilingDataProcessingWF
{
    public partial class AppForm : Form
    {
        private Solver Solver = new Solver();
        private string xlsx_path_in, xlsx_path_out, docx_path_in;

        public AppForm()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            InitializeComponent();
            this.Icon = Properties.Resources.AppIcon;
            this.StartPosition = FormStartPosition.CenterScreen;
            box_Pressure.Items.AddRange(new string[] { "1 атм", "2 атм", "3 атм", "4 атм", "5 атм" });
            box_Pressure.DropDownStyle = ComboBoxStyle.DropDownList;
            customProgressBar.Visible = false;
            checkBox_CreateFile.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
            button_process.Click += Process_Click;
            box_Pressure.SelectedIndexChanged += box_Pressure_SelectedIndexChanged;
        }

        private void Process_Click(object? sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(xlsx_path_in) && !String.IsNullOrEmpty(docx_path_in) && !String.IsNullOrEmpty(xlsx_path_out))
            {
                customProgressBar.Visible = true;
                button_process.Enabled = false;

                BackgroundWorker bgw = new BackgroundWorker();
                bgw.WorkerReportsProgress = true;

                bgw.DoWork += new DoWorkEventHandler(bgw_Process);
                bgw.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
                bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_WorkComplete);
                bgw.RunWorkerAsync();
            }

            else
            {
                MessageBox.Show("Необходимо выбрать 3 файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }  
            
        }

        void worker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            customProgressBar.Value = e.ProgressPercentage;
        }
   
        private void bgw_WorkComplete(object? sender, RunWorkerCompletedEventArgs e)
        {
                button_process.Enabled = true;
                customProgressBar.Visible = false;
        }

        private void bgw_Process(object? sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            worker.ReportProgress(0);
            
            ExcelFileReader InFileXLSX = new ExcelFileReader(xlsx_path_in);
            WordFileReader InFileDOCX = new WordFileReader(docx_path_in);

            try
            {
                InFileXLSX.Read();
            }
            catch (Exception)
            {
                MessageBox.Show("Файл эксперимента(.xlsx) пуст или поврежден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            worker.ReportProgress(25);
            Thread.Sleep(100);

            try 
            { 
                InFileDOCX.Read(); 
            } 
            catch (Exception)
            {
                MessageBox.Show("В файле протокола(.docx) нет таблиц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }   
            
            worker.ReportProgress(50);
            Thread.Sleep(100);

            Solver.setData(InFileDOCX.get_voltage(), InFileDOCX.get_protocol_time(), InFileXLSX.get_excel_time(), InFileXLSX.get_dT(), InFileXLSX.get_q(), (int)number_of_points.Value);
            var result = Solver.Solve();
            
            worker.ReportProgress(75);
            Thread.Sleep(100);

            ExcelFileWriter OutFileXLSX = new ExcelFileWriter(xlsx_path_in, xlsx_path_out, (InFileDOCX.get_voltage(), InFileDOCX.get_protocol_time(), result.Item1, result.Item2));
            OutFileXLSX.Write();

            ExcelFileWriter.InsertHeader(xlsx_path_in);
            
            worker.ReportProgress(100);
            Thread.Sleep(1000);

            if (checkBox_OpenFile.Checked == true )
            {
                System.Diagnostics.Process.Start(xlsx_path_out);
            }
        }

        private void Select_XLSX_in(object? sender, EventArgs e)
        {
            openExperimentFileDialog = new OpenFileDialog()
            {
                DefaultExt = "xlsx",
                Filter = "Excel files (*.xlsx)|*.xlsx",
                Multiselect = false,
                SupportMultiDottedExtensions = false,
                CheckFileExists = false
            };

            if (openExperimentFileDialog.ShowDialog() != DialogResult.OK ||
                !openExperimentFileDialog.SafeFileName.EndsWith(".xlsx"))
                return;

            xlsx_path_in = openExperimentFileDialog.FileName;

            label_XLSX_in.Text = xlsx_path_in;
        }
        private void Select_DOCX_in(object? sender, EventArgs e)
        {
            openExperimentFileDialog = new OpenFileDialog()
            {
                DefaultExt = "docx",
                Filter = "Docx files (*.docx)|*.docx",
                Multiselect = false,
                SupportMultiDottedExtensions = false,
                CheckFileExists = false
            };

            if (openExperimentFileDialog.ShowDialog() != DialogResult.OK ||
                !openExperimentFileDialog.SafeFileName.EndsWith(".docx"))
                return;

            docx_path_in = openExperimentFileDialog.FileName;

            label_DOCX_in.Text = docx_path_in;
        }

        private void Select_XLSX_out(object? sender, EventArgs e)
        {
            openExperimentFileDialog = new OpenFileDialog()
            {
                DefaultExt = "xlsx",
                Filter = "Excel files (*.xlsx)|*.xlsx",
                Multiselect = false,
                SupportMultiDottedExtensions = false,
                CheckFileExists = false
            };

            if (openExperimentFileDialog.ShowDialog() != DialogResult.OK ||
                !openExperimentFileDialog.SafeFileName.EndsWith(".xlsx"))
                return;

            xlsx_path_out = openExperimentFileDialog.FileName;
            label_XLSX_out.Text = xlsx_path_out;
        }

        private void checkBox_CheckedChanged(object? sender, EventArgs e)
        {
            if (checkBox_CreateFile.Checked == true)
            {
                SaveFileDialog createFileDialog = new SaveFileDialog();
                createFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                createFileDialog.Title = "Save an Excel File";
                createFileDialog.ShowDialog();

                if (createFileDialog.FileName != "")
                {
                    XlsxFileHandler NewXLSX = new XlsxFileHandler(createFileDialog.FileName);
                    NewXLSX.CreateFile();
                    button_select_XLSX_out.Enabled = false;
                    label_XLSX_out.BackColor = System.Drawing.Color.Silver;
                }

                else
                {
                    checkBox_CreateFile.Checked = false;
                }

                xlsx_path_out = createFileDialog.FileName;
                label_XLSX_out.Text = xlsx_path_out;
            }

            else
            {
                XlsxFileHandler.DeleteFile(xlsx_path_out);
                button_select_XLSX_out.Enabled = true;
                label_XLSX_out.BackColor = System.Drawing.Color.White;
                label_XLSX_out.Text = "";
            }
        }

        private void box_Pressure_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = box_Pressure.SelectedItem.ToString();
            MessageBox.Show(selectedState);

        }

    }
}
