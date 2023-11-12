using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using Table = DocumentFormat.OpenXml.Wordprocessing.Table;
using TableRow = DocumentFormat.OpenXml.Wordprocessing.TableRow;
using TableCell = DocumentFormat.OpenXml.Wordprocessing.TableCell;
using OfficeOpenXml.DataValidation;

namespace BoilingDataProcessingWF
{
    internal class WordFileReader
    {
        #region PRIVATE

        private List<string> voltage, protocol_time;
        private string file_path;

        private void Reinit()
        {
            voltage = new List<string>();
            protocol_time = new List<string>();
        }

        #endregion

        #region PUBLIC
        public WordFileReader(string file_path)
        {
            Reinit();
            this.file_path = file_path;
        }
        public void Read() 
        {
            Reinit();
            using (WordprocessingDocument doc = WordprocessingDocument.Open(file_path, false))
            {
                // Получаем все таблицы из документа
                var tables = doc.MainDocumentPart.Document.Descendants<Table>();

                if (tables.Any())
                {
                    Table table = tables.First(); // Получаем первую таблицу в документе
                    bool isFirstRow = true;
                    // Чтение содержимого таблицы
                    foreach (TableRow row in table.Elements<TableRow>())
                    {
                        if (isFirstRow)
                        {
                            isFirstRow = false;
                            continue; // Пропускаем первую строку(Шапка)
                        }

                        // Получение значения ячейки первого столбца
                        voltage.Add(row.Elements<TableCell>().ElementAt(1).InnerText.Trim());

                        // Получение значения ячейки третьего столбца
                        protocol_time.Add(row.Elements<TableCell>().ElementAt(3).InnerText.Trim());

                    }

                    //Удаление пустых считанных полей из таблицы
                    voltage.RemoveAll(s => string.IsNullOrEmpty(s));
                    protocol_time.RemoveAll(s => string.IsNullOrEmpty(s));
                }

                else
                {
                    throw new Exception();
                }
               
            }
        }

        public List<string> get_voltage() { return voltage; }
        public List<string> get_protocol_time() { return protocol_time; }

        #endregion
    }
}
