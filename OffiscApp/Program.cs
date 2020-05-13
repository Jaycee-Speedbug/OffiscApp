using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OffiscApp
{
    static class Program
    {

        public static readonly string EXCEL_FILE_NAME = "CLOUD-AUTO-TAX-CALC2020.xlsx";
        public static readonly string EXPENSES_TABLE_WORKSHEET = "Expenses";

        public static readonly int EXPENSES_TABLE_FIRST_LINE = 3;
        public static readonly string EXPENSES_TABLE_BOUNDARY_KEYWORD = "TOTAUX";
        public static readonly int EXPENSES_TABLE_BOUNDARY_COLUMN = 1;

        public static readonly int EXPENSES_TABLE_DATE_COLUMN = 1;
        public static readonly int EXPENSES_TABLE_CATEGORY_COLUMN = 2;
        public static readonly int EXPENSES_TABLE_ITEM_COLUMN = 3;
        public static readonly int EXPENSES_TABLE_DEBTOR_COLUMN = 4;
        public static readonly int EXPENSES_TABLE_TOTAL_AMOUNT_COLUMN = 5;
        public static readonly int EXPENSES_TABLE_FRACTION_COLUMN = 6;
        public static readonly int EXPENSES_TABLE_DEPRECIATION_COLUMN = 7;
        public static readonly int EXPENSES_TABLE_DEDUCTION_COLUMN = 8;
        public static readonly int EXPENSES_TABLE_CAP_COLUMN = 9;
        public static readonly int EXPENSES_TABLE_AMOUNT_COLUMN = 10;
        public static readonly int EXPENSES_TABLE_LAST_COLUMN = 13;


        public static readonly string[] CATEGORIES = { "TRANSPORT", "RESIDENCE", "REPAS", "DOCUMENTATION",
                                                       "FORMATION", "RECHERCHE EMPLOI","DIVERS"};
        
        
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ExcelConnector Excon = new ExcelConnector();
            //string fileName = AppDomain.CurrentDomain.BaseDirectory + EXCEL_FILE_NAME;

            if (!Excon.openConnection(AppDomain.CurrentDomain.BaseDirectory + EXCEL_FILE_NAME)) {
                // Problème avec l'ouverture du fichier Excel
                // TODO: Warning and close
                
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OffiscMainForm(Excon));

            // TODO: Appeler la fonction de l'ExcelConnector mettant fin à la connection au fichier Excel
        }
    }
}
