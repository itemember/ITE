using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace CreateKankouJittusekiTableApp
{
    /// <summary>
    /// 
    /// </summary>
    class ExcelBookProcess
    {
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="excelNames"></param>
        ///// <param name="excelSheetName"></param>
        ///// <returns></returns>
        //public Excel.Worksheet GetExcelSheet(String excelNames, String excelSheetName)
        //{
        //    Excel.Workbook xlBook = OpenExcelBook(excelNames);
        //    Excel.Worksheet excelSheet; 

        //    excelSheet = (Excel.Worksheet)xlBook.Sheets[GetSheetIndex(excelSheetName, xlBook.Sheets)];
        //    return excelSheet;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileNames">ファイル名(絶対パス+ファイル名)</param>
        /// <param name="sheetName">シート名</param>
        /// <returns>エクセルブック</returns>
        public static Excel.Workbook OpenWorkBook
            (Excel.Application excelApplication, String excelNames)
        {
            Excel.Workbook xlBook; // workbookオブジェクト

            /*
             * Excelのウィンドウの設定
             * Visible = true: 表示
             * Visible = false: 非表示
             */
            excelApplication.Visible = false; // 
            /*Excelファイルをオープンする*/
            xlBook = (Excel.Workbook)(excelApplication.Workbooks.Open(
                excelNames,  //オープンするExcelファイル名
                Type.Missing, //（省略可能）UpdateLinks (0 / 1 / 2 / 3)
                Type.Missing, //（省略可能）ReadOnly (True / False )
                Type.Missing, //（省略可能）Format
                // 1:タブ / 2:カンマ (,) / 3:スペース / 4:セミコロン (;)
                // 5:なし / 6:引数 Delimiterで指定された文字
                Type.Missing, //（省略可能）Password
                Type.Missing, //（省略可能）WriteResPassword
                Type.Missing, //（省略可能）IgnoreReadOnlyRecommended
                Type.Missing, //（省略可能）Origin
                Type.Missing, //（省略可能）Delimiter
                Type.Missing, //（省略可能）Editable
                Type.Missing, //（省略可能）Notify
                Type.Missing, //（省略可能）Converter
                Type.Missing, //（省略可能）AddToMru
                Type.Missing, //（省略可能）Local
                Type.Missing  //（省略可能）CorruptLoad
                ));
            return xlBook;
        }

        public static Excel.Workbook SelectWorkSheet
            (Excel.Application excelApplication, Excel.Workbook excelWorkBook, string sheetName)
        {
            /*
             * 存在しないシートを選択すると
             * エクセルが開けなくなるため，
             * Try&Catchでエラーを取得する．
             */
            try
            {
                /*Sheetを指定*/
                ((Excel.Worksheet)excelWorkBook.Sheets[sheetName]).Select();
            }
            catch (Exception ex)
            {
                /*
                 * ワークブックを閉じる時の設定
                 * Close(true) : 変更がブックに保存される。
                 * Close(false) : 変更がブックの保存されない。
                 */
                excelWorkBook.Close(false);
                /*エクセルの終了*/
                excelApplication.Quit();
                /*Errorメッセージ*/
                Console.WriteLine("指定したSheetは存在しません．");
                Console.ReadLine();
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            return excelWorkBook;
        }
    }
}
