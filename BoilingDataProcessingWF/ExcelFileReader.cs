using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using OfficeOpenXml;
using DocumentFormat.OpenXml.Packaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO.Packaging;


namespace BoilingDataProcessingWF
{
    internal class ExcelFileReader
    {
        #region PRIVATE

        private List<string> excel_time;
        private List<double> dT, q;
        private string file_path;
        private FileInfo inlet;

        private void Reinit()
        {
            excel_time = new List<string>();
            dT = new List<double>();
            q = new List<double>();
        }

        #endregion

        #region PUBLIC
        public ExcelFileReader(string file_path)
        {
            Reinit();
            this.file_path = file_path;
            inlet = new FileInfo(file_path);
        }
        public void Read()
        {
            Reinit();
            using (var package = new ExcelPackage(inlet))
            {
                ExcelWorksheet ws_in = package.Workbook.Worksheets.FirstOrDefault();

                if (ws_in != null)
                {
                    //Считывание данных эксперимента
                    int iLastRow = ws_in.Dimension.End.Row;//последняя заполненная строка в столбце А

                    for (int row = 2; row <= iLastRow; row++)
                    {
                        var cellValue = ws_in.Cells[row, 1].Value;

                        if (cellValue != null && double.TryParse(cellValue.ToString(), out double numericValue))
                        {
                            DateTime dateTimeValue = DateTime.FromOADate(numericValue);
                            excel_time.Add(dateTimeValue.ToString(@"HH\:mm"));
                        }
                    }

                    dT = (ws_in.Cells[$"P2:P{iLastRow}"].Value as object[,]).Cast<object>().Select(x => Convert.ToDouble(x)).ToList();
                    q = (ws_in.Cells[$"Q2:Q{iLastRow}"].Value as object[,]).Cast<object>().Select(x => Convert.ToDouble(x)).ToList();

                    //Закрытие файла эксперимента
                    package.Save();
                }

                else
                {
                    throw new Exception();
                }
                
                
            }
        }

        public List<string> get_excel_time() { return excel_time; }
        public List<double> get_dT() { return dT; }
        public List<double> get_q() { return q; }

        #endregion
    }
}
