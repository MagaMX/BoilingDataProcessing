using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OfficeOpenXml;


namespace BoilingDataProcessingWF
{
    internal class ExcelFileWriter
    {
        #region PRIVATE

        private List<string> voltage, protocol_time = new List<string>();
        private List<double> q_out, dT_out = new List<double>();
        private string file_path_in, file_path_out;
        private FileInfo outlet;

        //Создание уникального имени листа excel
        private string create_unique_name(string name, ExcelPackage out_package)
        {
            int i = 1, k;
            while (i > 0)
            {
                k = i;
                foreach (var worksheet in out_package.Workbook.Worksheets)
                {
                    if (worksheet.Name.Equals(name + " №" + i))
                    {
                        i++;
                        break;
                    }
                }
                if (k == i) break;
            }
            return name + " №" + i;
        }

        //Запись данных экспермиента в excel
        private void ListWrite<T>(List<T> list, ExcelWorksheet ws)
        {
            int col = 1;
            while (ws.Cells[2, col].Value != null) { col += 1; }
            ws.Cells[2, col].LoadFromCollection(list).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; 
        }
        #endregion

        #region PUBLIC

        public ExcelFileWriter(string file_path_in, string file_path_out, (List<string> voltage, List<string> protocol_time, List<double> dT_out, List<double> q_out) tuple)
        {
            this.voltage = tuple.voltage;
            this.protocol_time = tuple.protocol_time;
            this.dT_out = tuple.dT_out;
            this.q_out = tuple.q_out;
            this.file_path_in = file_path_in;
            this.file_path_out = file_path_out;
            outlet = new FileInfo(file_path_out);
        }

        public ExcelFileWriter(string file_path_out)
        {
            this.file_path_out = file_path_out;
            outlet = new FileInfo(file_path_out);
        }

        public void Write() 
        {
            using (var out_package = new ExcelPackage(outlet))
            {
                //Задаем имя листа именем файла эксперимента
                string[] filename = file_path_in.Split('\\');
                string unique_name = create_unique_name(filename.Last(), out_package);
                // Добавляем новый лист с уникальным именем
                ExcelWorksheet ws_out = out_package.Workbook.Worksheets.Add(unique_name);
                int sheet_index = Convert.ToInt32(unique_name.Split('№').Last());
                if (sheet_index <= out_package.Workbook.Worksheets.Count)
                    out_package.Workbook.Worksheets.MoveAfter(ws_out.Index, sheet_index);//Двигаем лист соответственно его номеру

                string[] processed_header = new[] { "№", "Time", "q", "dT", "U" };
                List<int> point_number = new();
                for (int i = 1; i < protocol_time.Count + 1; i++) { point_number.Add(i); }

                ws_out.Cells["A1"].LoadFromArrays(new List<string[]>(new[] { processed_header }));
                ws_out.Cells["A1:Z1"].Style.Font.Bold = true;
                ws_out.Cells["A1:Z1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ListWrite(point_number, ws_out);
                ListWrite(protocol_time, ws_out);
                ListWrite(q_out, ws_out);
                ListWrite(dT_out, ws_out);
                ListWrite(voltage, ws_out);

                double columnWidth = 15; // Ширина столбца в символах
                ws_out.Column(3).Width = columnWidth;

                out_package.Save();// Сохраняем изменения в файл
            }    
        }

        public void setData(List<string> voltage, List<string> protocol_time, List<double> dT_out, List<double> q_out)
        {
            this.voltage = voltage;
            this.protocol_time = protocol_time;
            this.dT_out = dT_out;
            this.q_out = q_out;
        }

        //Вставка шапки
        public static void InsertHeader(string file_path_in)
        {
            string[] header = new[] {"Time", "Tw_case", "Th1", "Th2", "Th3", "Th4", "Th5", "Tvap", "Tliq",
                 "Tw", "Tsat2", "dTh31", "dTh32", "dTh21", "dTh54", "dT2", "q_h",
                 "q_h31", "q_h32", "q_h21", "q_h54", "q_hiv", "alfa1", "alfa2", "dq", "p"};
            using (var package = new ExcelPackage(new FileInfo(file_path_in)))
            {
                ExcelWorksheet ws_in = package.Workbook.Worksheets.FirstOrDefault();
                if (ws_in != null)
                {
                    ws_in.Cells["A1"].LoadFromArrays(new List<string[]>(new[] { header }));
                    ws_in.Cells["A1:Z1"].Style.Font.Bold = true;
                    ws_in.Cells["A1:Z1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                }
                else
                {
                    // Обработка случая, когда лист не найден
                    Console.WriteLine("Лист не найден в файле Excel.");
                }
                //Закрытие файла эксперимента
                package.Save();
            }
        }

        #endregion
    }
}
