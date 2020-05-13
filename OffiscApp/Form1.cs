using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OffiscApp
{
    public partial class OffiscMainForm : Form
    {

        ExcelConnector ExCon;

        public OffiscMainForm()
        {
            InitializeComponent();
            ExCon = new ExcelConnector();
        }



        public OffiscMainForm(ExcelConnector excon) {
            InitializeComponent();
            ExCon = excon;
            // Remplissage des controls
            setControlsInitValues();
        }



        private void fillComboDebtors() {
            List<string> items = ExCon.getItems(true, Program.EXPENSES_TABLE_DEBTOR_COLUMN);
            foreach (string itemName in items) {
                DebtorComboBox.Items.Add(itemName);
            }
        }



        private void fillComboCategories() {
            foreach(string s in Program.CATEGORIES) {
                CategoriesComboBox.Items.Add(s);
            }
        }



        private void fillComboItem() {
            List<string> items = ExCon.getItems(true, Program.EXPENSES_TABLE_ITEM_COLUMN);
            foreach (string itemName in items) {
                ExpenseComboBox.Items.Add(itemName);
            }
        }



        private void setControlsInitValues() {
            double val = 0.0;
            double val2 = 1.0;
            double val3 = 100;
            int val4 = 1;

            // Combos
            fillComboDebtors();
            fillComboCategories();
            fillComboItem();
            // Text Boxes
            TotalAmountTextBox.Text = val.ToString("N2");
            NumTextBox.Text = val2.ToString("N0");
            DenumTextBox.Text = val4.ToString("N0");
            DepreciationTextBox.Text = val3.ToString("N0");
            CapTextBox.Text = "";
        }



        private void updateFields() {
            double amount;
            double fraction = 1.0;
            double num;
            double denum;
            double deprec;
            double deduction = 0;
            double cap;
            double val;

            if (double.TryParse(TotalAmountTextBox.Text, out amount)) {

                if (double.TryParse(NumTextBox.Text, out num) &&
                    double.TryParse(DenumTextBox.Text, out denum)) {
                    fraction = num / denum;
                    val = amount * fraction;
                    AfterFractionLabel.Text = string.Format("{0:C2}", val);
                }

                if (double.TryParse(DepreciationTextBox.Text, out deprec)) {
                    val = amount * fraction * deprec / 100;
                    AfterDepreciationLabel.Text = string.Format("{0:C2}", val);
                }

                if (double.TryParse(DeductionTextBox.Text,out deduction)) {
                    val = amount * fraction * deprec / 100 - deduction;
                    AfterDeductionLabel.Text = string.Format("{0:C2}", val);
                }

                if (double.TryParse(CapTextBox.Text, out cap)) {
                    val = Math.Min(cap, amount * fraction * deprec / 100 - deduction);
                    AfterCapLabel.Text = string.Format("{0:C2}", val);
                }

            }
            else {
                // Rien à faire
            }
        }



        private void NatureLabel_Click(object sender, EventArgs e) {
            // Rien à faire
        }



        private void DebtorComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            // Rien à faire
        }



        private void OffiscMainForm_Load(object sender, EventArgs e) {
            // End
            // TODO: Comment bien fermer l'app ???
            if (e.ToString().Equals("END")) {
                ExCon.closeConnection();
            }
        }



        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e) {
            // Rien à faire
        }



        private void Label1_Click(object sender, EventArgs e) {
            // Rien à faire
        }



        private void AbandonButton_Click(object sender, EventArgs e) {
            setControlsInitValues();
        }



        private void OkButton_Click(object sender, EventArgs e) {
            /*
            string depreciation;
            string fraction;
            double num;
            double denum;

            if (double.TryParse(NumTextBox.Text, out num) &&
                double.TryParse(DenumTextBox.Text, out denum)) {
            }
            else {
                num = 1.0;
                denum = 1.0;
            }
            fraction = (num / denum).ToString("F");
            depreciation = string.Format("{0:P}", DepreciationTextBox.Text);
            */
            ExCon.saveExpense((DateTime)ExpenseDateTimePicker.Value, 
                              CategoriesComboBox.Text, 
                              DebtorComboBox.Text,
                              ExpenseComboBox.Text, 
                              TotalAmountTextBox.Text,
                              NumTextBox.Text,
                              DenumTextBox.Text,
                              DepreciationTextBox.Text,
                              DeductionTextBox.Text,
                              CapTextBox.Text);
        }



        private void NumTextBox_TextChanged(object sender, EventArgs e) {
            updateFields();
        }



        private void DenumTextBox_TextChanged(object sender, EventArgs e) {
            updateFields();
        }

        

        private void DepreciationTextBox_TextChanged(object sender, EventArgs e) {
            double deprec;

            if (double.TryParse(DepreciationTextBox.Text, out deprec)) {
                // 0 to 100%
                if (deprec < 0) { DepreciationTextBox.Text = "0"; }
                if (deprec > 100) { DepreciationTextBox.Text = "100"; }
            }
            else {
                DepreciationTextBox.Text = "100";
            }
            updateFields();
        }



        private void DeductionTextBox_TextChanged(object sender, EventArgs e) {
            double deduction;

            if (double.TryParse(DeductionTextBox.Text, out deduction)) {
                // >= 0
                if (deduction < 0) { DeductionTextBox.Text = "0"; }
            }
            else {
                DeductionTextBox.Text = "0";
            }
            updateFields();
        }



        private void CapTextBox_TextChanged(object sender, EventArgs e) {
            double cap;

            if (double.TryParse(CapTextBox.Text, out cap)) {
                // >= 0
                if (cap < 0) { DeductionTextBox.Text = "0"; }
            }
            else {
                DeductionTextBox.Text = "";
            }
            updateFields();
        }



        private void TotalAmountTextBox_TextChanged(object sender, EventArgs e) {
            updateFields();
        }



        private void AfterCapLabel_Click(object sender, EventArgs e) {
            // Rien à faire
        }

    }

}
