namespace courseWork02
{
    partial class IncomePage
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
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblPayerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPayerName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.chkReurEvent = new System.Windows.Forms.CheckBox();
            this.rbIncomeBegining = new System.Windows.Forms.RadioButton();
            this.rbIncomeEnd = new System.Windows.Forms.RadioButton();
            this.rbIncomeSpecific = new System.Windows.Forms.RadioButton();
            this.dtpSpecDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblIncome.Location = new System.Drawing.Point(65, 37);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(104, 29);
            this.lblIncome.TabIndex = 0;
            this.lblIncome.Text = "Incomes";
            // 
            // lblPayerName
            // 
            this.lblPayerName.AutoSize = true;
            this.lblPayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayerName.ForeColor = System.Drawing.Color.Teal;
            this.lblPayerName.Location = new System.Drawing.Point(83, 140);
            this.lblPayerName.Name = "lblPayerName";
            this.lblPayerName.Size = new System.Drawing.Size(120, 25);
            this.lblPayerName.TabIndex = 1;
            this.lblPayerName.Text = "Payer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(83, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Teal;
            this.lblDate.Location = new System.Drawing.Point(83, 256);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 25);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(83, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Recurring Evet";
            // 
            // txtPayerName
            // 
            this.txtPayerName.Location = new System.Drawing.Point(383, 140);
            this.txtPayerName.Name = "txtPayerName";
            this.txtPayerName.Size = new System.Drawing.Size(200, 22);
            this.txtPayerName.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(383, 197);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 22);
            this.txtAmount.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(383, 87);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 22);
            this.txtDescription.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(83, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Description";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearch.Location = new System.Drawing.Point(639, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 31);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(383, 259);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 12;
            // 
            // chkReurEvent
            // 
            this.chkReurEvent.AutoSize = true;
            this.chkReurEvent.Location = new System.Drawing.Point(383, 323);
            this.chkReurEvent.Name = "chkReurEvent";
            this.chkReurEvent.Size = new System.Drawing.Size(18, 17);
            this.chkReurEvent.TabIndex = 13;
            this.chkReurEvent.UseVisualStyleBackColor = true;
            // 
            // rbIncomeBegining
            // 
            this.rbIncomeBegining.AutoSize = true;
            this.rbIncomeBegining.Location = new System.Drawing.Point(383, 369);
            this.rbIncomeBegining.Name = "rbIncomeBegining";
            this.rbIncomeBegining.Size = new System.Drawing.Size(224, 21);
            this.rbIncomeBegining.TabIndex = 14;
            this.rbIncomeBegining.TabStop = true;
            this.rbIncomeBegining.Text = "At the Begining of Every month";
            this.rbIncomeBegining.UseVisualStyleBackColor = true;
            // 
            // rbIncomeEnd
            // 
            this.rbIncomeEnd.AutoSize = true;
            this.rbIncomeEnd.Location = new System.Drawing.Point(383, 417);
            this.rbIncomeEnd.Name = "rbIncomeEnd";
            this.rbIncomeEnd.Size = new System.Drawing.Size(194, 21);
            this.rbIncomeEnd.TabIndex = 15;
            this.rbIncomeEnd.TabStop = true;
            this.rbIncomeEnd.Text = "At the End of Every month";
            this.rbIncomeEnd.UseVisualStyleBackColor = true;
            // 
            // rbIncomeSpecific
            // 
            this.rbIncomeSpecific.AutoSize = true;
            this.rbIncomeSpecific.Location = new System.Drawing.Point(383, 469);
            this.rbIncomeSpecific.Name = "rbIncomeSpecific";
            this.rbIncomeSpecific.Size = new System.Drawing.Size(141, 21);
            this.rbIncomeSpecific.TabIndex = 16;
            this.rbIncomeSpecific.TabStop = true;
            this.rbIncomeSpecific.Text = "At a Specific Date";
            this.rbIncomeSpecific.UseVisualStyleBackColor = true;
            // 
            // dtpSpecDate
            // 
            this.dtpSpecDate.Location = new System.Drawing.Point(383, 511);
            this.dtpSpecDate.Name = "dtpSpecDate";
            this.dtpSpecDate.Size = new System.Drawing.Size(200, 22);
            this.dtpSpecDate.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(383, 574);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 40);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(544, 574);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 40);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // IncomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 654);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpSpecDate);
            this.Controls.Add(this.rbIncomeSpecific);
            this.Controls.Add(this.rbIncomeEnd);
            this.Controls.Add(this.rbIncomeBegining);
            this.Controls.Add(this.chkReurEvent);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtPayerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPayerName);
            this.Controls.Add(this.lblIncome);
            this.Name = "IncomePage";
            this.Text = "IncomePage";
            this.Load += new System.EventHandler(this.IncomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblPayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPayerName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox chkReurEvent;
        private System.Windows.Forms.RadioButton rbIncomeBegining;
        private System.Windows.Forms.RadioButton rbIncomeEnd;
        private System.Windows.Forms.RadioButton rbIncomeSpecific;
        private System.Windows.Forms.DateTimePicker dtpSpecDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}