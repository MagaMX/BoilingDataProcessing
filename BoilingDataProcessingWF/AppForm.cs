using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;


namespace BoilingDataProcessingWF
{
    public partial class AppForm : Form
    {
        private string xlsx_path_in, xlsx_path_out, docx_path_in;
        private int pressure;
        private (List<double>, List<double>) result;
        private ToolTip tooltip = new System.Windows.Forms.ToolTip();
        private DataPoint lastDataPoint;

        public AppForm()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            InitializeComponent();

            this.Icon = Properties.Resources.AppIcon;
            this.StartPosition = FormStartPosition.CenterScreen;

            box_Pressure.Items.AddRange(new string[] { "1 атм", "2 атм", "3 атм", "4 атм", "5 атм" });
            box_Pressure.DropDownStyle = ComboBoxStyle.DropDownList;

            customProgressBar.Visible = false;// Отключаем видимость прогрессбара до выполнения обработки
            chartBC.ChartAreas[0].Visible = false;// Отключаем видимость зоны графика до построения графика
            chartBC.Legends[0].Enabled = false;// Отключаем видимость легенды до построения графика
            dataGridViewBC.Visible = false;// Отключаем видимость таблицы данных эксперимента до построения графика
            label_DataGridBC.Visible = false;

            //Обработка событий
            checkBox_CreateFile.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
            button_process.Click += Process_Click;
            box_Pressure.SelectedIndexChanged += box_Pressure_SelectedIndexChanged;
            button_GenerateChartCurve.Click += Generate_Chart_Curve_Click;
            chartBC.MouseMove += ChartBC_MouseMove;
            chartBC.MouseLeave += ChartBC_MouseLeave;
        }

        private void Process_Click(object sender, EventArgs e)
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

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            customProgressBar.Value = e.ProgressPercentage;
        }
   
        private void bgw_WorkComplete(object sender, RunWorkerCompletedEventArgs e)
        {
                button_process.Enabled = true;
                customProgressBar.Visible = false;
        }

        private void bgw_Process(object sender, DoWorkEventArgs e)
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

            Solver Solver = new Solver();
            Solver.setData(InFileDOCX.get_voltage(), InFileDOCX.get_protocol_time(), InFileXLSX.get_excel_time(), InFileXLSX.get_dT(), InFileXLSX.get_q(), (int)number_of_points.Value);
            result = Solver.Solve();
            
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

        private void Select_XLSX_in(object sender, EventArgs e)
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

        private void Select_DOCX_in(object sender, EventArgs e)
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

        private void Select_XLSX_out(object sender, EventArgs e)
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

        private void checkBox_CheckedChanged(object sender, EventArgs e)
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

        private void Generate_Chart_Curve_Click(object sender, EventArgs e)
        {
            try
            {
                chartBC.Series["Кривая Ягова"].Points.Clear();
                chartBC.Series["Эксперимент"].Points.Clear();

                chartBC.Cursor = Cursors.Cross;

                label_DataGridBC.Visible = true;
                dataGridViewBC.Visible = true;

                if (checkBox_Logarithm.Checked == true)
                {
                    chartBC.ChartAreas[0].Visible = true;
                    chartBC.Legends[0].Enabled = true;
                    chartBC.ChartAreas[0].AxisY.Minimum = 10;
                    chartBC.ChartAreas[0].AxisY.Maximum = 1000;
                    chartBC.ChartAreas[0].AxisX.Minimum = 1;
                    chartBC.ChartAreas[0].AxisX.Maximum = 100;
                    chartBC.ChartAreas[0].AxisY.Interval = 1;
                    chartBC.ChartAreas[0].AxisX.Interval = 1;
                    chartBC.ChartAreas[0].AxisY.IsLogarithmic = true;
                    chartBC.ChartAreas[0].AxisX.IsLogarithmic = true;
                    chartBC.ChartAreas[0].CursorY.IsUserEnabled = true;
                    chartBC.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
                    chartBC.ChartAreas[0].CursorX.IsUserEnabled = true;
                    chartBC.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                }

                else
                {
                    chartBC.ChartAreas[0].Visible = true;
                    chartBC.Legends[0].Enabled = true;
                    chartBC.ChartAreas[0].AxisY.Minimum = 0;
                    chartBC.ChartAreas[0].AxisY.Maximum = RoundToNearestMultiple(result.Item2[result.Item2.Count - 1] / 1000, 100) + 100;//Округляем до ближайшего целого значения кратного 100 и добавляем 100 запаса
                    chartBC.ChartAreas[0].AxisX.Minimum = 0;
                    chartBC.ChartAreas[0].AxisX.Maximum = RoundToNearestMultiple(result.Item1[result.Item1.Count - 1], 5) + 5; 
                    chartBC.ChartAreas[0].AxisY.Interval = 50;
                    chartBC.ChartAreas[0].AxisX.Interval = 5;
                    chartBC.ChartAreas[0].AxisY.IsLogarithmic = false;
                    chartBC.ChartAreas[0].AxisX.IsLogarithmic = false;
                    chartBC.ChartAreas[0].CursorY.IsUserEnabled = true;
                    chartBC.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
                    chartBC.ChartAreas[0].CursorX.IsUserEnabled = true;
                    chartBC.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                }

                Expressions exp = new Expressions(pressure);

                List<double> res = exp.YagovCurve();

                for (int i = 1; i < res.Count; i++)
                {
                    chartBC.Series["Кривая Ягова"].Points.AddXY(i, res[i]);
                }

                for (int i = 0; i < result.Item1.Count; i++)
                {
                    chartBC.Series["Эксперимент"].Points.AddXY(result.Item1[i], result.Item2[i] / 1000);
                }

                //Создадим таблицу с данными эксперимента и выведем ее на форму
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ΔT, °C", typeof(double));
                dataTable.Columns.Add("q,  кВт/м2", typeof(double));

                for (int i = 0; i < result.Item1.Count; i++)
                {
                    dataTable.Rows.Add(result.Item1[i], result.Item2[i] / 1000);
                }

                // Привязка таблицы данных к элементу управления DataGridView
                dataGridViewBC.DataSource = dataTable;

                // Запрет пользовательского редактирования ячеек
                dataGridViewBC.ReadOnly = true;
                dataGridViewBC.AllowUserToAddRows = false;

                // Растягивание столбцов
                dataGridViewBC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            catch (Exception) 
            {
                MessageBox.Show("Необходимо сначала обработать эксперимент!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void box_Pressure_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = box_Pressure.SelectedItem.ToString().Split(' ')[0];
            pressure = Convert.ToInt32(selectedState);
        }

        private void ChartBC_MouseMove(object sender, MouseEventArgs e)
        {
            // Получаем текущие координаты мыши
            Point mousePoint = chartBC.PointToClient(System.Windows.Forms.Cursor.Position);

            // Поиск ближайшей точки на графике
            HitTestResult result = chartBC.HitTest(mousePoint.X, mousePoint.Y);

            // Проверка, является ли результат точкой данных
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                DataPoint dataPoint = result.Series.Points[result.PointIndex];

                // Проверка, изменилась ли точка данных
                if (lastDataPoint != dataPoint)
                {
                    // Обновление значения ToolTip
                    double xValue = dataPoint.XValue;
                    double yValue = dataPoint.YValues[0];
                    tooltip.SetToolTip(chartBC, $"X: {xValue}, Y: {yValue}");

                    // Сохранить текущую точку данных
                    lastDataPoint = dataPoint;
                }
            }

            else
            {
                // Если мышь не наведена на точку данных, скрыть ToolTip
                tooltip.Hide(chartBC);
            }
            
        }

        private void ChartBC_MouseLeave(object sender, EventArgs e)
        {
            tooltip.Hide(chartBC);
            lastDataPoint = null;
        }

        private static int RoundToNearestMultiple(double number, int multiplier)
        {
            return (int)(Math.Round(number / (double)multiplier) * multiplier);
        }
    }
}
