using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace OffiscApp {


    public class ExcelConnector {

        string excelFileName;
        Excel.Application ExcelApp;
        Excel._Workbook WrkBk;
        Excel._Worksheet WrkSht;



        /// <summary>
        /// Constructeur
        /// </summary>
        public ExcelConnector() {
            ExcelApp = new Excel.Application();
            ExcelApp.Visible = true;

        }



        /// <summary>
        /// Establish connection with the target worksheet of the Excel file
        /// </summary>
        /// <param name="fileName">Target Excel file name</param>
        /// <returns></returns>
        public bool openConnection(string fileName) {
            excelFileName = fileName;
            try {
                WrkBk = ExcelApp.Workbooks.Open(fileName);
                WrkSht = WrkBk.Worksheets.Item[Program.EXPENSES_TABLE_WORKSHEET];
                return true;
            }
            catch {
                //ExcelApp.Quit();
                return false;
            }
        }



        public bool saveExpense(DateTime expDate, string expCategory, string debtor, string expItem,  string totalVal, 
                                string numerator, string denominator, string depreciation, string deduction, string cap) {
            int freeRow;
            double num;
            double denum;
            string fraction;
            string deprec;
            double value;
            Excel.Range range;

            // Recherche d'une ligne vide
            //freeRow = rowIndexOf("", Program.EXPENSES_TABLE_ITEM_COLUMN);

            // Insertion d'une ligne vide en deuxième ligne de table
            freeRow = Program.EXPENSES_TABLE_FIRST_LINE + 1;
            range = (Excel.Range)WrkSht.Rows[freeRow];
            range.Insert();
            // Report des formules
            range = (Excel.Range)WrkSht.Range[WrkSht.Cells[freeRow, Program.EXPENSES_TABLE_AMOUNT_COLUMN], 
                                              WrkSht.Cells[freeRow + 1, Program.EXPENSES_TABLE_LAST_COLUMN]];
            range.FillUp();

            // Préparation des données
            if (double.TryParse(numerator, out num) &&
                double.TryParse(denominator, out denum)) {
            }
            else {
                num = 1.0;
                denum = 1.0;
            }
            fraction = (num / denum).ToString("F");
            if (double.TryParse(depreciation, out value)) {
                deprec = (value).ToString() + "%";
                //deprec = string.Format("{0:P}", value / 100);
            }
            else {
                deprec = "100%";
                //deprec = string.Format("{0:P", 100);
            }

            // Copie des données
            range = (Excel.Range)WrkSht.Cells[freeRow, Program.EXPENSES_TABLE_DATE_COLUMN];
            range.Value2 = expDate;

            range = (Excel.Range)WrkSht.Cells[freeRow, Program.EXPENSES_TABLE_CATEGORY_COLUMN];
            range.Value2 = expCategory;

            range = (Excel.Range)WrkSht.Cells[freeRow, Program.EXPENSES_TABLE_ITEM_COLUMN];
            range.Value2 = expItem;

            range = (Excel.Range)WrkSht.Cells[freeRow, Program.EXPENSES_TABLE_DEBTOR_COLUMN];
            range.Value2 = debtor;

            range = (Excel.Range)WrkSht.Cells[freeRow, Program.EXPENSES_TABLE_TOTAL_AMOUNT_COLUMN];
            range.Value2 = totalVal;

            range = (Excel.Range)WrkSht.Cells[freeRow, Program.EXPENSES_TABLE_FRACTION_COLUMN];
            range.Value2 = fraction;

            range = (Excel.Range)WrkSht.Cells[freeRow, Program.EXPENSES_TABLE_DEPRECIATION_COLUMN];
            range.Value2 = deprec;

            range = (Excel.Range)WrkSht.Cells[freeRow, Program.EXPENSES_TABLE_DEDUCTION_COLUMN];
            range.Value2 = deduction;

            range = (Excel.Range)WrkSht.Cells[freeRow, Program.EXPENSES_TABLE_CAP_COLUMN];
            range.Value2 = cap;

            return true;
        }



        /// <summary>
        /// List of string from a column
        /// </summary>
        /// <param name="uniqueItems">True to get unical items</param>
        /// <param name="column">target column</param>
        /// <returns></returns>
        public List<string> getItems(bool uniqueItems, int column) {

            List<string> items = new List<string>();
            string cellContent;
            Excel.Range range;

            for (int cursor = Program.EXPENSES_TABLE_FIRST_LINE; cursor< 100; cursor++) {
                range = (Excel.Range)WrkSht.Cells[cursor, column];
                cellContent = (string)range.Value2;

                if (cellContent != null) {
                    if (!uniqueItems || !items.Contains(cellContent)) {
                        items.Add(cellContent);
                    }
                }
            }
            return items;
        }



        public int rowIndexOf(string str, int col) {
            int cursor = Program.EXPENSES_TABLE_FIRST_LINE;
            Excel.Range range;

            do {
                range = (Excel.Range)WrkSht.Cells[cursor, col];
                if (((string)(range.Value2)).Equals(str)) {
                    break;
                }
                cursor++;
            } while (cursor <= WrkSht.UsedRange.End[Excel.XlDirection.xlDown].Row);
            return cursor;
        }



        public bool closeConnection() {
            ExcelApp.Quit();
            return true;
        }

    }
    
}
