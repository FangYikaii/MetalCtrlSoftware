using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Xugz
{  
    public class XmlHelper
    {
        //public static List<string> Read(string filePath)
        //{
        //    List<string> list = new List<string>();
        //    using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(filePath, false))
        //    {
        //        // 获取工作表集合
        //        WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
        //        Sheets sheets = workbookPart.Workbook.Descendants<Sheets>().FirstOrDefault();

        //        foreach (Sheet sheet in sheets.Elements<Sheet>())
        //        {
        //            // 获取工作表内容
        //            WorksheetPart worksheetPart = (WorksheetPart)workbookPart.GetPartById(sheet.Id);

        //            // 获取工作表中的单元格
        //            var cells = worksheetPart.Worksheet.Descendants<Cell>();
        //            string listInfo = string.Empty;
        //            foreach (var cell in cells)
        //            {
        //                // 获取单元格的值
        //                string cellValue = GetCellValue(cell, workbookPart);
        //                if (cellValue != null && cellValue != "") listInfo += listInfo == string.Empty ? cellValue : ("," + cellValue);                     
        //            }
        //            list.Add(listInfo);
        //        }
        //    }
        //    return list;
        //}

        /// <summary>
        /// 获取Excel指定工作表数据
        /// </summary>
        /// <param name="filePath">Excel所在路径</param>
        /// <param name="sheetName">工作表名</param>
        /// <returns></returns>
        public static List<string[]> Read(string filePath, string sheetName="Sheet1")
        {
            List<string[]> ret = new List<string[]>();
            //打开文件
            SpreadsheetDocument document = SpreadsheetDocument.Open(filePath, false);
            WorkbookPart workbook = document.WorkbookPart;
            IEnumerable<Sheet> sheets = document.WorkbookPart.Workbook.Descendants<Sheet>().Where(s => s.Name == sheetName);
            if (sheets.Count() == 0)
            {
                return ret;
            }
            WorksheetPart worksheetPart = (WorksheetPart)document.WorkbookPart.GetPartById(sheets.First().Id);
            Worksheet worksheet = worksheetPart.Worksheet;
            IEnumerable<Row> rows = worksheet.Descendants<Row>();
            
            foreach (Row row in rows)//获取行的值
            {
                string columnValue = string.Empty;
                foreach (Cell cell in row)
                {
                    columnValue += columnValue == string.Empty ? GetValue(cell, workbook.SharedStringTablePart) :
                        ("," + GetValue(cell, workbook.SharedStringTablePart));
                }               
                ret.Add(columnValue.Split(','));
            }
            return ret;

        }
        /// <summary>
        /// 获取单元格信息  这也是官方获取值的方法
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="stringTablePart">stringTablePart就是WorkbookPart.SharedStringTablePart，它存储了所有以SharedStringTable方式存储数据的子元素。</param>
        /// <returns></returns>
        public static string GetValue(Cell cell, SharedStringTablePart stringTablePart)
        {
            if (cell.ChildElements.Count == 0)
                return null;
            //get cell value
            String value = cell.CellValue.InnerText;
            //Look up real value from shared string table
            if ((cell.DataType != null) && (cell.DataType == CellValues.SharedString))
                value = stringTablePart.SharedStringTable
                    .ChildElements[Int32.Parse(value)]
                    .InnerText;
            return value;
        }
        private static string GetCellValue(Cell cell, WorkbookPart workbookPart)
        {
            string value = string.Empty;

            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                int sharedStringIndex = int.Parse(cell.InnerText);
                value = workbookPart.SharedStringTablePart.SharedStringTable.ChildElements[sharedStringIndex].InnerText;
            }
            else if (cell.CellValue != null)
            {
                value = cell.CellValue.Text;
            }

            return value;
        }
        public static void Write(string filePath, string[] message)
        {
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(filePath, true))
            {

                // 访问WorkbookPart
                WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;

                // 获取第一个工作表
                WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();

                // 获取工作表的SheetData元素
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

              
                int rowId = sheetData.Count();
                Row row = new Row();
                Cell[] cell = new Cell[message.Length];        
                for (int i = 0; i < cell.Length; i++)
                {
                    cell[i] = new Cell()
                    {
                        CellValue = new CellValue(message[i]),
                        DataType = new EnumValue<CellValues>(CellValues.String)
                    };
                }
                for (int i = 0; i < cell.Length; i++)
                {
                    row.AppendChild(cell[i]);
                }
                sheetData.AppendChild(row);
                // 保存文档
                workbookPart.Workbook.Save();
            }
        }
        public static void Creat(string filePath, string[] header)
        {

            // 创建一个新的SpreadsheetDocument对象
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                // 添加一个WorkbookPart
                WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();
                workbookpart.Workbook = new Workbook();

                // 添加一个WorksheetPart
                WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                // 添加一个Sheet
                Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());
                Sheet sheet = new Sheet()
                {
                    Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "Sheet1"
                };
                sheets.Append(sheet);

                // 添加一个单元格
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
                Row row = new Row();
                Cell[] cell = new Cell[header.Length];               
                for (int i = 0; i < header.Length; i++)
                {
                    cell[i] = new Cell
                    {
                        CellValue = new CellValue(header[i]),
                        DataType = new EnumValue<CellValues>(CellValues.String)
                    };
                }
                for (int i = 0; i < cell.Length; i++)
                {
                    row.AppendChild(cell[i]);
                }
                sheetData.AppendChild(row);
                // 保存文档
                workbookpart.Workbook.Save();
            }
        }
    }
}
