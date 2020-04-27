namespace courseWork02
{
    partial class ExpensePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblIncome = new System.Windows.Forms.Label();
            this.btnEDelete = new System.Windows.Forms.Button();
            this.btnESave = new System.Windows.Forms.Button();
            this.dtpESpecDate = new System.Windows.Forms.DateTimePicker();
            this.rbESpecific = new System.Windows.Forms.RadioButton();
            this.rbEEnd = new System.Windows.Forms.RadioButton();
            this.rbIEBegining = new System.Windows.Forms.RadioButton();
            this.chkEReurEvent = new System.Windows.Forms.CheckBox();
            this.dtpEDate = new System.Windows.Forms.DateTimePicker();
            this.btnESearch = new System.Windows.Forms.Button();
            this.txtEDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEAmount = new System.Windows.Forms.TextBox();
            this.txtEPayerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPayerName = new System.Windows.Forms.Label();
            this.lblECategory = new System.Windows.Forms.Label();
            this.cmdExpCategory = new System.Windows.Forms.ComboBox();
            this.expenseCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet1 = new courseWork02.testDataSet1();
            this.expenseCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new courseWork02.testDataSet();
            this.btnCategory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.expenseCategoryTableAdapter = new courseWork02.testDataSetTableAdapters.ExpenseCategoryTableAdapter();
            this.expenseCategoryTableAdapter1 = new courseWork02.testDataSet1TableAdapters.ExpenseCategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.expenseCategoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblIncome.Location = new System.Drawing.Point(74, -63);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(104, 29);
            this.lblIncome.TabIndex = 20;
            this.lblIncome.Text = "Incomes";
            // 
            // btnEDelete
            // 
            this.btnEDelete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDelete.Location = new System.Drawing.Point(530, 692);
            this.btnEDelete.Name = "btnEDelete";
            this.btnEDelete.Size = new System.Drawing.Size(84, 40);
            this.btnEDelete.TabIndex = 54;
            this.btnEDelete.Text = "Delete";
            this.btnEDelete.UseVisualStyleBackColor = false;
            this.btnEDelete.Click += new System.EventHandler(this.btnEDelete_Click);
            // 
            // btnESave
            // 
            this.btnESave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnESave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnESave.Location = new System.Drawing.Point(390, 692);
            this.btnESave.Name = "btnESave";
            this.btnESave.Size = new System.Drawing.Size(84, 40);
            this.btnESave.TabIndex = 53;
            this.btnESave.Text = "Save";
            this.btnESave.UseVisualStyleBackColor = false;
            this.btnESave.Click += new System.EventHandler(this.btnESave_Click);
            // 
            // dtpESpecDate
            // 
            this.dtpESpecDate.Location = new System.Drawing.Point(390, 629);
            this.dtpESpecDate.Name = "dtpESpecDate";
            this.dtpESpecDate.Size = new System.Drawing.Size(200, 22);
            this.dtpESpecDate.TabIndex = 52;
            // 
            // rbESpecific
            // 
            this.rbESpecific.AutoSize = true;
            this.rbESpecific.Location = new System.Drawing.Point(390, 587);
            this.rbESpecific.Name = "rbESpecific";
            this.rbESpecific.Size = new System.Drawing.Size(141, 21);
            this.rbESpecific.TabIndex = 51;
            this.rbESpecific.TabStop = true;
            this.rbESpecific.Text = "At a Specific Date";
            this.rbESpecific.UseVisualStyleBackColor = true;
            // 
            // rbEEnd
            // 
            this.rbEEnd.AutoSize = true;
            this.rbEEnd.Location = new System.Drawing.Point(390, 535);
            this.rbEEnd.Name = "rbEEnd";
            this.rbEEnd.Size = new System.Drawing.Size(194, 21);
            this.rbEEnd.TabIndex = 50;
            this.rbEEnd.TabStop = true;
            this.rbEEnd.Text = "At the End of Every month";
            this.rbEEnd.UseVisualStyleBackColor = true;
            // 
            // rbIEBegining
            // 
            this.rbIEBegining.AutoSize = true;
            this.rbIEBegining.Location = new System.Drawing.Point(390, 487);
            this.rbIEBegining.Name = "rbIEBegining";
            this.rbIEBegining.Size = new System.Drawing.Size(224, 21);
            this.rbIEBegining.TabIndex = 49;
            this.rbIEBegining.TabStop = true;
            this.rbIEBegining.Text = "At the Begining of Every month";
            this.rbIEBegining.UseVisualStyleBackColor = true;
            // 
            // chkEReurEvent
            // 
            this.chkEReurEvent.AutoSize = true;
            this.chkEReurEvent.Location = new System.Drawing.Point(390, 441);
            this.chkEReurEvent.Name = "chkEReurEvent";
            this.chkEReurEvent.Size = new System.Drawing.Size(18, 17);
            this.chkEReurEvent.TabIndex = 48;
            this.chkEReurEvent.UseVisualStyleBackColor = true;
            // 
            // dtpEDate
            // 
            this.dtpEDate.Location = new System.Drawing.Point(390, 274);
            this.dtpEDate.Name = "dtpEDate";
            this.dtpEDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEDate.TabIndex = 47;
            // 
            // btnESearch
            // 
            this.btnESearch.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnESearch.Location = new System.Drawing.Point(646, 98);
            this.btnESearch.Name = "btnESearch";
            this.btnESearch.Size = new System.Drawing.Size(79, 31);
            this.btnESearch.TabIndex = 46;
            this.btnESearch.Text = "Search";
            this.btnESearch.UseVisualStyleBackColor = false;
            this.btnESearch.Click += new System.EventHandler(this.btnESearch_Click);
            // 
            // txtEDescription
            // 
            this.txtEDescription.Location = new System.Drawing.Point(390, 102);
            this.txtEDescription.Name = "txtEDescription";
            this.txtEDescription.Size = new System.Drawing.Size(200, 22);
            this.txtEDescription.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(90, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Description";
            // 
            // txtEAmount
            // 
            this.txtEAmount.Location = new System.Drawing.Point(390, 212);
            this.txtEAmount.Name = "txtEAmount";
            this.txtEAmount.Size = new System.Drawing.Size(200, 22);
            this.txtEAmount.TabIndex = 43;
            // 
            // txtEPayerName
            // 
            this.txtEPayerName.Location = new System.Drawing.Point(390, 155);
            this.txtEPayerName.Name = "txtEPayerName";
            this.txtEPayerName.Size = new System.Drawing.Size(200, 22);
            this.txtEPayerName.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(90, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Recurring Evet";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Teal;
            this.lblDate.Location = new System.Drawing.Point(90, 271);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 25);
            this.lblDate.TabIndex = 40;
            this.lblDate.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(90, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Amount";
            // 
            // lblPayerName
            // 
            this.lblPayerName.AutoSize = true;
            this.lblPayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayerName.ForeColor = System.Drawing.Color.Teal;
            this.lblPayerName.Location = new System.Drawing.Point(90, 155);
            this.lblPayerName.Name = "lblPayerName";
            this.lblPayerName.Size = new System.Drawing.Size(125, 25);
            this.lblPayerName.TabIndex = 38;
            this.lblPayerName.Text = "Payee Name";
            // 
            // lblECategory
            // 
            this.lblECategory.AutoSize = true;
            this.lblECategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblECategory.ForeColor = System.Drawing.Color.Teal;
            this.lblECategory.Location = new System.Drawing.Point(90, 332);
            this.lblECategory.Name = "lblECategory";
            this.lblECategory.Size = new System.Drawing.Size(174, 25);
            this.lblECategory.TabIndex = 55;
            this.lblECategory.Text = "Expense Category";
            // 
            // cmdExpCategory
            // 
            this.cmdExpCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.expenseCategoryBindingSource1, "CategoryName", true));
            this.cmdExpCategory.DataSource = this.expenseCategoryBindingSource1;
            this.cmdExpCategory.DisplayMember = "CategoryName";
            this.cmdExpCategory.FormattingEnabled = true;
            this.cmdExpCategory.Location = new System.Drawing.Point(390, 333);
            this.cmdExpCategory.Name = "cmdExpCategory";
            this.cmdExpCategory.Size = new System.Drawing.Size(121, 24);
            this.cmdExpCategory.TabIndex = 56;
            this.cmdExpCategory.ValueMember = "CategoryId";
            // 
            // expenseCategoryBindingSource1
            // 
            this.expenseCategoryBindingSource1.DataMember = "ExpenseCategory";
            this.expenseCategoryBindingSource1.DataSource = this.testDataSet1;
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "testDataSet1";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenseCategoryBindingSource
            // 
            this.expenseCategoryBindingSource.DataMember = "ExpenseCategory";
            this.expenseCategoryBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCategory.Location = new System.Drawing.Point(390, 387);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(121, 31);
            this.btnCategory.TabIndex = 57;
            this.btnCategory.Text = "Create Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(51, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 58;
            this.label3.Text = "Expenses";
            // 
            // expenseCategoryTableAdapter
            // 
            this.expenseCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // expenseCategoryTableAdapter1
            // 
            this.expenseCategoryTableAdapter1.ClearBeforeFill = true;
            // 
            // ExpensePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 755);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.cmdExpCategory);
            this.Controls.Add(this.lblECategory);
            this.Controls.Add(this.btnEDelete);
            this.Controls.Add(this.btnESave);
            this.Controls.Add(this.dtpESpecDate);
            this.Controls.Add(this.rbESpecific);
            this.Controls.Add(this.rbEEnd);
            this.Controls.Add(this.rbIEBegining);
            this.Controls.Add(this.chkEReurEvent);
            this.Controls.Add(this.dtpEDate);
            this.Controls.Add(this.btnESearch);
            this.Controls.Add(this.txtEDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEAmount);
            this.Controls.Add(this.txtEPayerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPayerName);
            this.Controls.Add(this.lblIncome);
            this.Name = "ExpensePage";
            this.Text = "ExpensePagecs";
            this.Load += new System.EventHandler(this.ExpensePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expenseCategoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Button btnEDelete;
        private System.Windows.Forms.Button btnESave;
        private System.Windows.Forms.DateTimePicker dtpESpecDate;
        private System.Windows.Forms.RadioButton rbESpecific;
        private System.Windows.Forms.RadioButton rbEEnd;
        private System.Windows.Forms.RadioButton rbIEBegining;
        private System.Windows.Forms.CheckBox chkEReurEvent;
        private System.Windows.Forms.DateTimePicker dtpEDate;
        private System.Windows.Forms.Button btnESearch;
        private System.Windows.Forms.TextBox txtEDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEAmount;
        private System.Windows.Forms.TextBox txtEPayerName;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPayerName;
        public System.Windows.Forms.Label lblECategory;
        private System.Windows.Forms.ComboBox cmdExpCategory;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Label label3;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource expenseCategoryBindingSource;
        private testDataSetTableAdapters.ExpenseCategoryTableAdapter expenseCategoryTableAdapter;
        private testDataSet1 testDataSet1;
        private System.Windows.Forms.BindingSource expenseCategoryBindingSource1;
        private testDataSet1TableAdapters.ExpenseCategoryTableAdapter expenseCategoryTableAdapter1;
    }
}