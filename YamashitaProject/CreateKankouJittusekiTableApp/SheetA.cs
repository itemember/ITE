using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace CreateKankouJittusekiTableApp
{

    class SheetA
    {

        public void CreateSheet(String excelNames, String sheetName)
        {
            Excel.Application xlApp = new Excel.Application(); // Excelオブジェクト
            Excel.Workbook xlWorkBook;

            /*指定したパスのエクセルワークブックを開く*/
            xlWorkBook = ExcelBookProcess.OpenWorkBook(xlApp, excelNames);
            /*エクセルワークシートを選択*/
            xlWorkBook = ExcelBookProcess.SelectWorkSheet(xlApp, xlWorkBook, sheetName);
            /*要素の書き込み*/
            SheetLogic(ref xlApp, ref xlWorkBook);
        }

        private void SheetLogic (ref Excel.Application excelApplication, ref Excel.Workbook excelWorkBook)
        {
            Excel.Range CellRange;
            List<String> employeeNameList = new List<String>();

            /*完工実績表：表題*/
            /*完工実績表：上部*/
            for (int i = 1; i <= 5; i++)
            {
                //書き込む場所を指定
                CellRange = excelApplication.Cells[i, 1] as Excel.Range;
                //書き込む内容
                CellRange.Value2 = "繰り返し" + i + "回目";
            }
            /*完工実績表：下部*/
            for (int i = 1; i <= 5; i++)
            {
                //書き込む場所を指定
                CellRange = excelApplication.Cells[i, 1] as Excel.Range;

                //書き込む内容
                CellRange.Value2 = "繰り返し" + i + "回目";
            }

            //Appを閉じる
            excelWorkBook.Close(true);
            excelApplication.Quit();
        }
    }
}
