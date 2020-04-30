namespace courseWork02
{
    partial class FinancePredicPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPredcWeek = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWeekExp = new System.Windows.Forms.TextBox();
            this.lblPerWeek = new System.Windows.Forms.Label();
            this.txtPerDay = new System.Windows.Forms.TextBox();
            this.lblPerDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "This Tool will help you to predict your finance for the next week\r\n or days in th" +
    "e current Month.\r\n";
            // 
            // btnPredcWeek
            // 
            this.btnPredcWeek.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPredcWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredcWeek.Location = new System.Drawing.Point(163, 154);
            this.btnPredcWeek.Name = "btnPredcWeek";
            this.btnPredcWeek.Size = new System.Drawing.Size(141, 63);
            this.btnPredcWeek.TabIndex = 1;
            this.btnPredcWeek.Text = "Predict for Weeks";
            this.btnPredcWeek.UseVisualStyleBackColor = false;
            this.btnPredcWeek.Click += new System.EventHandler(this.btnPredcWeek_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(482, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Predict for Days";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Income for the Month";
            // 
            // txtIncome
            // 
            this.txtIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncome.Location = new System.Drawing.Point(447, 264);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(125, 28);
            this.txtIncome.TabIndex = 4;
            // 
            // txtExpense
            // 
            this.txtExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpense.Location = new System.Drawing.Point(447, 308);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.Size = new System.Drawing.Size(125, 28);
            this.txtExpense.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expenses up to Today";
            // 
            // txtWeekExp
            // 
            this.txtWeekExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeekExp.Location = new System.Drawing.Point(447, 351);
            this.txtWeekExp.Name = "txtWeekExp";
            this.txtWeekExp.Size = new System.Drawing.Size(125, 28);
            this.txtWeekExp.TabIndex = 8;
            this.txtWeekExp.Visible = false;
            this.txtWeekExp.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblPerWeek
            // 
            this.lblPerWeek.AutoSize = true;
            this.lblPerWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerWeek.Location = new System.Drawing.Point(213, 356);
            this.lblPerWeek.Name = "lblPerWeek";
            this.lblPerWeek.Size = new System.Drawing.Size(178, 24);
            this.lblPerWeek.TabIndex = 7;
            this.lblPerWeek.Text = "Expenses per week";
            this.lblPerWeek.Visible = false;
            // 
            // txtPerDay
            // 
            this.txtPerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerDay.Location = new System.Drawing.Point(447, 351);
            this.txtPerDay.Name = "txtPerDay";
            this.txtPerDay.Size = new System.Drawing.Size(125, 28);
            this.txtPerDay.TabIndex = 10;
            this.txtPerDay.Visible = false;
            // 
            // lblPerDay
            // 
            this.lblPerDay.AutoSize = true;
            this.lblPerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerDay.Location = new System.Drawing.Point(213, 356);
            this.lblPerDay.Name = "lblPerDay";
            this.lblPerDay.Size = new System.Drawing.Size(165, 24);
            this.lblPerDay.TabIndex = 9;
            this.lblPerDay.Text = "Expenses per Day";
            this.lblPerDay.Visible = false;
            // 
            // FinancePredicPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 488);
            this.Controls.Add(this.txtPerDay);
            this.Controls.Add(this.lblPerDay);
            this.Controls.Add(this.txtWeekExp);
            this.Controls.Add(this.lblPerWeek);
            this.Controls.Add(this.txtExpense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPredcWeek);
            this.Controls.Add(this.label1);
            this.Name = "FinancePredicPage";
            this.Text = "FinancePredicPage";
            this.Load += new System.EventHandler(this.FinancePredicPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPredcWeek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWeekExp;
        private System.Windows.Forms.Label lblPerWeek;
        private System.Windows.Forms.TextBox txtPerDay;
        private System.Windows.Forms.Label lblPerDay;
    }
}