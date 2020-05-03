namespace courseWork02
{
    partial class SearchPage
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
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.expenseDataGrid = new System.Windows.Forms.DataGridView();
            this.incomeDataGrid = new System.Windows.Forms.DataGridView();
            this.chkIncome = new System.Windows.Forms.CheckBox();
            this.chkExpense = new System.Windows.Forms.CheckBox();
            this.lblExpGrid = new System.Windows.Forms.Label();
            this.lblIncGrid = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(153, 38);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 22);
            this.dtpFromDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(379, 43);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 17);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(410, 38);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(200, 22);
            this.dtpToDate.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(682, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // expenseDataGrid
            // 
            this.expenseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expenseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Date,
            this.Amount,
            this.Edit,
            this.ID});
            this.expenseDataGrid.Location = new System.Drawing.Point(153, 187);
            this.expenseDataGrid.Name = "expenseDataGrid";
            this.expenseDataGrid.RowHeadersWidth = 51;
            this.expenseDataGrid.RowTemplate.Height = 24;
            this.expenseDataGrid.Size = new System.Drawing.Size(552, 150);
            this.expenseDataGrid.TabIndex = 7;
            this.expenseDataGrid.Visible = false;
            this.expenseDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // incomeDataGrid
            // 
            this.incomeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn1,
            this.dataGridViewTextBoxColumn2});
            this.incomeDataGrid.Location = new System.Drawing.Point(153, 394);
            this.incomeDataGrid.Name = "incomeDataGrid";
            this.incomeDataGrid.RowHeadersWidth = 51;
            this.incomeDataGrid.RowTemplate.Height = 24;
            this.incomeDataGrid.Size = new System.Drawing.Size(552, 150);
            this.incomeDataGrid.TabIndex = 8;
            this.incomeDataGrid.Visible = false;
            this.incomeDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.incomeDataGrid_CellContentClick);
            // 
            // chkIncome
            // 
            this.chkIncome.AutoSize = true;
            this.chkIncome.Location = new System.Drawing.Point(410, 98);
            this.chkIncome.Name = "chkIncome";
            this.chkIncome.Size = new System.Drawing.Size(124, 21);
            this.chkIncome.TabIndex = 9;
            this.chkIncome.Text = "Search Income";
            this.chkIncome.UseVisualStyleBackColor = true;
            // 
            // chkExpense
            // 
            this.chkExpense.AutoSize = true;
            this.chkExpense.Location = new System.Drawing.Point(153, 98);
            this.chkExpense.Name = "chkExpense";
            this.chkExpense.Size = new System.Drawing.Size(133, 21);
            this.chkExpense.TabIndex = 10;
            this.chkExpense.Text = "Search Expense";
            this.chkExpense.UseVisualStyleBackColor = true;
            // 
            // lblExpGrid
            // 
            this.lblExpGrid.AutoSize = true;
            this.lblExpGrid.Location = new System.Drawing.Point(150, 155);
            this.lblExpGrid.Name = "lblExpGrid";
            this.lblExpGrid.Size = new System.Drawing.Size(93, 17);
            this.lblExpGrid.TabIndex = 11;
            this.lblExpGrid.Text = "Expense Grid";
            this.lblExpGrid.Visible = false;
            // 
            // lblIncGrid
            // 
            this.lblIncGrid.AutoSize = true;
            this.lblIncGrid.Location = new System.Drawing.Point(150, 362);
            this.lblIncGrid.Name = "lblIncGrid";
            this.lblIncGrid.Size = new System.Drawing.Size(84, 17);
            this.lblIncGrid.TabIndex = 12;
            this.lblIncGrid.Text = "Income Grid";
            this.lblIncGrid.Visible = false;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.Frozen = true;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.Frozen = true;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.Frozen = true;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 125;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.Frozen = true;
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.DataPropertyName = "Edit";
            this.dataGridViewButtonColumn1.Frozen = true;
            this.dataGridViewButtonColumn1.HeaderText = "Edit";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Edit";
            this.dataGridViewButtonColumn1.ToolTipText = "Edit";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // SearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 604);
            this.Controls.Add(this.lblIncGrid);
            this.Controls.Add(this.lblExpGrid);
            this.Controls.Add(this.chkExpense);
            this.Controls.Add(this.chkIncome);
            this.Controls.Add(this.incomeDataGrid);
            this.Controls.Add(this.expenseDataGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFromDate);
            this.Name = "SearchPage";
            this.Text = "SearchPage";
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView expenseDataGrid;
        private System.Windows.Forms.DataGridView incomeDataGrid;
        private System.Windows.Forms.CheckBox chkIncome;
        private System.Windows.Forms.CheckBox chkExpense;
        private System.Windows.Forms.Label lblExpGrid;
        private System.Windows.Forms.Label lblIncGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}