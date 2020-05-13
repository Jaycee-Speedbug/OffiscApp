namespace OffiscApp
{
    partial class OffiscMainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.AmountLabel = new System.Windows.Forms.Label();
            this.TotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.DebtorLabel = new System.Windows.Forms.Label();
            this.DebtorComboBox = new System.Windows.Forms.ComboBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ExpenseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CategoriesComboBox = new System.Windows.Forms.ComboBox();
            this.ExpenseComboBox = new System.Windows.Forms.ComboBox();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.FractionLabel = new System.Windows.Forms.Label();
            this.NumTextBox = new System.Windows.Forms.TextBox();
            this.DepreciationTextBox = new System.Windows.Forms.TextBox();
            this.DepreciationLabel = new System.Windows.Forms.Label();
            this.DeductionTextBox = new System.Windows.Forms.TextBox();
            this.DeductionLabel = new System.Windows.Forms.Label();
            this.CapTextBox = new System.Windows.Forms.TextBox();
            this.CapLabel = new System.Windows.Forms.Label();
            this.AfterFractionLabel = new System.Windows.Forms.Label();
            this.AfterDepreciationLabel = new System.Windows.Forms.Label();
            this.AfterDeductionLabel = new System.Windows.Forms.Label();
            this.AfterCapLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.AbandonButton = new System.Windows.Forms.Button();
            this.EuroLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DenumTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(11, 178);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(199, 24);
            this.AmountLabel.TabIndex = 0;
            this.AmountLabel.Text = "Total amount to record";
            // 
            // TotalAmountTextBox
            // 
            this.TotalAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountTextBox.Location = new System.Drawing.Point(277, 180);
            this.TotalAmountTextBox.Name = "TotalAmountTextBox";
            this.TotalAmountTextBox.Size = new System.Drawing.Size(95, 28);
            this.TotalAmountTextBox.TabIndex = 5;
            this.TotalAmountTextBox.Text = "0,00";
            this.TotalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalAmountTextBox.TextChanged += new System.EventHandler(this.TotalAmountTextBox_TextChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(11, 18);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(85, 24);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category";
            this.CategoryLabel.Click += new System.EventHandler(this.NatureLabel_Click);
            // 
            // DebtorLabel
            // 
            this.DebtorLabel.AutoSize = true;
            this.DebtorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebtorLabel.Location = new System.Drawing.Point(11, 70);
            this.DebtorLabel.Name = "DebtorLabel";
            this.DebtorLabel.Size = new System.Drawing.Size(66, 24);
            this.DebtorLabel.TabIndex = 4;
            this.DebtorLabel.Text = "Debtor";
            // 
            // DebtorComboBox
            // 
            this.DebtorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DebtorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DebtorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebtorComboBox.FormattingEnabled = true;
            this.DebtorComboBox.Location = new System.Drawing.Point(120, 67);
            this.DebtorComboBox.Name = "DebtorComboBox";
            this.DebtorComboBox.Size = new System.Drawing.Size(661, 30);
            this.DebtorComboBox.TabIndex = 3;
            this.DebtorComboBox.SelectedIndexChanged += new System.EventHandler(this.DebtorComboBox_SelectedIndexChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(448, 18);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(48, 24);
            this.DateLabel.TabIndex = 6;
            this.DateLabel.Text = "Date";
            // 
            // ExpenseDateTimePicker
            // 
            this.ExpenseDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseDateTimePicker.Location = new System.Drawing.Point(493, 17);
            this.ExpenseDateTimePicker.Name = "ExpenseDateTimePicker";
            this.ExpenseDateTimePicker.Size = new System.Drawing.Size(288, 28);
            this.ExpenseDateTimePicker.TabIndex = 2;
            // 
            // CategoriesComboBox
            // 
            this.CategoriesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CategoriesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoriesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesComboBox.FormattingEnabled = true;
            this.CategoriesComboBox.Location = new System.Drawing.Point(120, 15);
            this.CategoriesComboBox.Name = "CategoriesComboBox";
            this.CategoriesComboBox.Size = new System.Drawing.Size(313, 30);
            this.CategoriesComboBox.Sorted = true;
            this.CategoriesComboBox.TabIndex = 1;
            // 
            // ExpenseComboBox
            // 
            this.ExpenseComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ExpenseComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ExpenseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseComboBox.FormattingEnabled = true;
            this.ExpenseComboBox.Location = new System.Drawing.Point(120, 121);
            this.ExpenseComboBox.Name = "ExpenseComboBox";
            this.ExpenseComboBox.Size = new System.Drawing.Size(661, 30);
            this.ExpenseComboBox.TabIndex = 4;
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel.Location = new System.Drawing.Point(11, 124);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(86, 24);
            this.ItemLabel.TabIndex = 9;
            this.ItemLabel.Text = "Expense";
            // 
            // FractionLabel
            // 
            this.FractionLabel.AutoSize = true;
            this.FractionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FractionLabel.Location = new System.Drawing.Point(11, 223);
            this.FractionLabel.Name = "FractionLabel";
            this.FractionLabel.Size = new System.Drawing.Size(78, 24);
            this.FractionLabel.TabIndex = 11;
            this.FractionLabel.Text = "Fraction";
            // 
            // NumTextBox
            // 
            this.NumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumTextBox.Location = new System.Drawing.Point(137, 224);
            this.NumTextBox.Name = "NumTextBox";
            this.NumTextBox.Size = new System.Drawing.Size(41, 27);
            this.NumTextBox.TabIndex = 6;
            this.NumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumTextBox.TextChanged += new System.EventHandler(this.NumTextBox_TextChanged);
            // 
            // DepreciationTextBox
            // 
            this.DepreciationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepreciationTextBox.Location = new System.Drawing.Point(137, 275);
            this.DepreciationTextBox.Name = "DepreciationTextBox";
            this.DepreciationTextBox.Size = new System.Drawing.Size(112, 27);
            this.DepreciationTextBox.TabIndex = 9;
            this.DepreciationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DepreciationTextBox.TextChanged += new System.EventHandler(this.DepreciationTextBox_TextChanged);
            // 
            // DepreciationLabel
            // 
            this.DepreciationLabel.AutoSize = true;
            this.DepreciationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepreciationLabel.Location = new System.Drawing.Point(11, 275);
            this.DepreciationLabel.Name = "DepreciationLabel";
            this.DepreciationLabel.Size = new System.Drawing.Size(116, 24);
            this.DepreciationLabel.TabIndex = 13;
            this.DepreciationLabel.Text = "Depreciation";
            this.DepreciationLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // DeductionTextBox
            // 
            this.DeductionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeductionTextBox.Location = new System.Drawing.Point(137, 327);
            this.DeductionTextBox.Name = "DeductionTextBox";
            this.DeductionTextBox.Size = new System.Drawing.Size(112, 27);
            this.DeductionTextBox.TabIndex = 10;
            this.DeductionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DeductionTextBox.TextChanged += new System.EventHandler(this.DeductionTextBox_TextChanged);
            // 
            // DeductionLabel
            // 
            this.DeductionLabel.AutoSize = true;
            this.DeductionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeductionLabel.Location = new System.Drawing.Point(11, 327);
            this.DeductionLabel.Name = "DeductionLabel";
            this.DeductionLabel.Size = new System.Drawing.Size(96, 24);
            this.DeductionLabel.TabIndex = 15;
            this.DeductionLabel.Text = "Deduction";
            // 
            // CapTextBox
            // 
            this.CapTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapTextBox.Location = new System.Drawing.Point(137, 378);
            this.CapTextBox.Name = "CapTextBox";
            this.CapTextBox.Size = new System.Drawing.Size(112, 27);
            this.CapTextBox.TabIndex = 11;
            this.CapTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CapTextBox.TextChanged += new System.EventHandler(this.CapTextBox_TextChanged);
            // 
            // CapLabel
            // 
            this.CapLabel.AutoSize = true;
            this.CapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapLabel.Location = new System.Drawing.Point(11, 378);
            this.CapLabel.Name = "CapLabel";
            this.CapLabel.Size = new System.Drawing.Size(44, 24);
            this.CapLabel.TabIndex = 17;
            this.CapLabel.Text = "Cap";
            // 
            // AfterFractionLabel
            // 
            this.AfterFractionLabel.AutoSize = true;
            this.AfterFractionLabel.CausesValidation = false;
            this.AfterFractionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfterFractionLabel.Location = new System.Drawing.Point(329, 227);
            this.AfterFractionLabel.Name = "AfterFractionLabel";
            this.AfterFractionLabel.Size = new System.Drawing.Size(60, 24);
            this.AfterFractionLabel.TabIndex = 19;
            this.AfterFractionLabel.Text = "0,00 €";
            this.AfterFractionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AfterFractionLabel.UseMnemonic = false;
            // 
            // AfterDepreciationLabel
            // 
            this.AfterDepreciationLabel.AutoSize = true;
            this.AfterDepreciationLabel.CausesValidation = false;
            this.AfterDepreciationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfterDepreciationLabel.Location = new System.Drawing.Point(329, 278);
            this.AfterDepreciationLabel.Name = "AfterDepreciationLabel";
            this.AfterDepreciationLabel.Size = new System.Drawing.Size(60, 24);
            this.AfterDepreciationLabel.TabIndex = 20;
            this.AfterDepreciationLabel.Text = "0,00 €";
            this.AfterDepreciationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AfterDeductionLabel
            // 
            this.AfterDeductionLabel.AutoSize = true;
            this.AfterDeductionLabel.CausesValidation = false;
            this.AfterDeductionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfterDeductionLabel.Location = new System.Drawing.Point(329, 330);
            this.AfterDeductionLabel.Name = "AfterDeductionLabel";
            this.AfterDeductionLabel.Size = new System.Drawing.Size(60, 24);
            this.AfterDeductionLabel.TabIndex = 21;
            this.AfterDeductionLabel.Text = "0,00 €";
            this.AfterDeductionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AfterCapLabel
            // 
            this.AfterCapLabel.AutoSize = true;
            this.AfterCapLabel.CausesValidation = false;
            this.AfterCapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfterCapLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AfterCapLabel.Location = new System.Drawing.Point(323, 381);
            this.AfterCapLabel.Name = "AfterCapLabel";
            this.AfterCapLabel.Size = new System.Drawing.Size(66, 24);
            this.AfterCapLabel.TabIndex = 22;
            this.AfterCapLabel.Text = "0,00 €";
            this.AfterCapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AfterCapLabel.Click += new System.EventHandler(this.AfterCapLabel_Click);
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(588, 352);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(193, 53);
            this.OkButton.TabIndex = 12;
            this.OkButton.Text = "Validate";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AbandonButton
            // 
            this.AbandonButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AbandonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbandonButton.Location = new System.Drawing.Point(588, 276);
            this.AbandonButton.Name = "AbandonButton";
            this.AbandonButton.Size = new System.Drawing.Size(193, 53);
            this.AbandonButton.TabIndex = 13;
            this.AbandonButton.Text = "Cancel";
            this.AbandonButton.UseVisualStyleBackColor = true;
            this.AbandonButton.Click += new System.EventHandler(this.AbandonButton_Click);
            // 
            // EuroLabel
            // 
            this.EuroLabel.AutoSize = true;
            this.EuroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EuroLabel.Location = new System.Drawing.Point(374, 183);
            this.EuroLabel.Name = "EuroLabel";
            this.EuroLabel.Size = new System.Drawing.Size(20, 24);
            this.EuroLabel.TabIndex = 25;
            this.EuroLabel.Text = "€";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "/";
            // 
            // DenumTextBox
            // 
            this.DenumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DenumTextBox.Location = new System.Drawing.Point(205, 224);
            this.DenumTextBox.Name = "DenumTextBox";
            this.DenumTextBox.Size = new System.Drawing.Size(44, 27);
            this.DenumTextBox.TabIndex = 8;
            this.DenumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DenumTextBox.TextChanged += new System.EventHandler(this.DenumTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "€";
            // 
            // OffiscMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DenumTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EuroLabel);
            this.Controls.Add(this.AbandonButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.AfterCapLabel);
            this.Controls.Add(this.AfterDeductionLabel);
            this.Controls.Add(this.AfterDepreciationLabel);
            this.Controls.Add(this.AfterFractionLabel);
            this.Controls.Add(this.CapTextBox);
            this.Controls.Add(this.CapLabel);
            this.Controls.Add(this.DeductionTextBox);
            this.Controls.Add(this.DeductionLabel);
            this.Controls.Add(this.DepreciationTextBox);
            this.Controls.Add(this.DepreciationLabel);
            this.Controls.Add(this.NumTextBox);
            this.Controls.Add(this.FractionLabel);
            this.Controls.Add(this.ExpenseComboBox);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.CategoriesComboBox);
            this.Controls.Add(this.ExpenseDateTimePicker);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DebtorComboBox);
            this.Controls.Add(this.DebtorLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.TotalAmountTextBox);
            this.Controls.Add(this.AmountLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OffiscMainForm";
            this.Text = "Add an expense";
            this.Load += new System.EventHandler(this.OffiscMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label DebtorLabel;
        private System.Windows.Forms.ComboBox DebtorComboBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker ExpenseDateTimePicker;
        private System.Windows.Forms.ComboBox CategoriesComboBox;
        private System.Windows.Forms.ComboBox ExpenseComboBox;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label FractionLabel;
        private System.Windows.Forms.TextBox NumTextBox;
        private System.Windows.Forms.TextBox DepreciationTextBox;
        private System.Windows.Forms.Label DepreciationLabel;
        internal System.Windows.Forms.TextBox TotalAmountTextBox;
        private System.Windows.Forms.TextBox DeductionTextBox;
        private System.Windows.Forms.Label DeductionLabel;
        private System.Windows.Forms.TextBox CapTextBox;
        private System.Windows.Forms.Label CapLabel;
        private System.Windows.Forms.Label AfterFractionLabel;
        private System.Windows.Forms.Label AfterDepreciationLabel;
        private System.Windows.Forms.Label AfterDeductionLabel;
        private System.Windows.Forms.Label AfterCapLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button AbandonButton;
        private System.Windows.Forms.Label EuroLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DenumTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

