using System;
using System.IO;
using System.Linq;
using OfficeOpenXml;

namespace BoilingDataProcessingWF
{
    internal class XlsxFileHandler
    {
        #region PRIVATE

        private string file_path;
        private FileInfo inlet;

        #endregion

        #region PUBLIC

        public XlsxFileHandler(string file_path)
        {
            this.file_path = file_path;
            inlet = new FileInfo(file_path);
        }

        public void CreateFile()
        {
            using (var package = new ExcelPackage(inlet))
            {
                ExcelWorksheet ws = package.Workbook.Worksheets.Add("FileInfo");
               
                string[] filename = file_path.Split('\\');
                ws.Cells["A1"].Value = "Имя файла-->";
                ws.Cells["A2"].Value = "Дата создания-->";
                ws.Cells["B1"].Value = filename.Last();
                ws.Cells["A2"].Value = "Дата создания-->";
                ws.Cells["B2"].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss ");
                ws.Cells["A1:B2"].AutoFitColumns();

                package.Save();
            }
        }

        public static void DeleteFile(string file_path)
        {
            // Проверка существования файла
            if (File.Exists(file_path))
            {
                // Проверка есть ли в файле обработанные экспериметы
                using (var package = new ExcelPackage(new FileInfo(file_path)))
                {
                    if (package.Workbook.Worksheets.Count == 1)
                    {
                        File.Delete(file_path);
                    }
                }
            }
        }

        #endregion
    }
}
