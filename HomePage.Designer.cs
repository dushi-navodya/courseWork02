namespace courseWork02
{
    partial class HomePage
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
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnPredic = new System.Windows.Forms.Button();
            this.pieChart = new MindFusion.Charting.WinForms.PieChart();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnAppoinment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(299, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Page";
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIncome.Location = new System.Drawing.Point(110, 187);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(116, 50);
            this.btnIncome.TabIndex = 2;
            this.btnIncome.Text = "Income";
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnExpense
            // 
            this.btnExpense.BackColor = System.Drawing.Color.Aqua;
            this.btnExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpense.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExpense.Location = new System.Drawing.Point(110, 257);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(116, 50);
            this.btnExpense.TabIndex = 3;
            this.btnExpense.Text = "Expense";
            this.btnExpense.UseVisualStyleBackColor = false;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // btnPredic
            // 
            this.btnPredic.BackColor = System.Drawing.Color.Teal;
            this.btnPredic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredic.Location = new System.Drawing.Point(110, 329);
            this.btnPredic.Name = "btnPredic";
            this.btnPredic.Size = new System.Drawing.Size(116, 75);
            this.btnPredic.TabIndex = 5;
            this.btnPredic.Text = "Predict Financial Status";
            this.btnPredic.UseVisualStyleBackColor = false;
            this.btnPredic.Click += new System.EventHandler(this.button2_Click);
            // 
            // pieChart
            // 
            this.pieChart.ChartPadding = 20;
            this.pieChart.DetachOffset = 0F;
            this.pieChart.LegendTitle = "Pie Chart for Expenses";
            this.pieChart.Location = new System.Drawing.Point(98, 90);
            this.pieChart.Margin = new System.Windows.Forms.Padding(4);
            this.pieChart.Name = "pieChart";
            this.pieChart.Padding = new System.Windows.Forms.Padding(67, 62, 67, 62);
            this.pieChart.ShowLegend = true;
            this.pieChart.Size = new System.Drawing.Size(879, 525);
            this.pieChart.StartAngle = 0F;
            this.pieChart.SubtitleFontName = null;
            this.pieChart.SubtitleFontSize = null;
            this.pieChart.SubtitleFontStyle = null;
            this.pieChart.TabIndex = 7;
            this.pieChart.Text = "pieChart1";
            this.pieChart.Theme.AxisLabelsBrush = new MindFusion.Drawing.SolidBrush("#FF000000");
            this.pieChart.Theme.AxisTitleBrush = new MindFusion.Drawing.SolidBrush("#FF000000");
            this.pieChart.Theme.DataLabelsBrush = new MindFusion.Drawing.SolidBrush("#FF000000");
            this.pieChart.Theme.GaugeBackground = new MindFusion.Drawing.SolidBrush("#FFB0C4DE");
            this.pieChart.Theme.GaugePointerBackground = new MindFusion.Drawing.SolidBrush("#FFFFA500");
            this.pieChart.Theme.GaugePointerStroke = new MindFusion.Drawing.SolidBrush("#FFDC143C");
            this.pieChart.Theme.GaugeScaleBackground = new MindFusion.Drawing.SolidBrush("#FFFFFFFF");
            this.pieChart.Theme.GaugeStroke = new MindFusion.Drawing.SolidBrush("#FF483D8B");
            this.pieChart.Theme.GaugeTickBackground = new MindFusion.Drawing.SolidBrush("#FF00BFFF");
            this.pieChart.Theme.LegendBorderStrokeThickness = 0D;
            this.pieChart.Theme.LegendTitleBrush = new MindFusion.Drawing.SolidBrush("#FF000000");
            this.pieChart.Theme.PlotBorderStrokeThickness = 0D;
            this.pieChart.Theme.SubtitleBrush = new MindFusion.Drawing.SolidBrush("#FF000000");
            this.pieChart.Theme.TitleBrush = new MindFusion.Drawing.SolidBrush("#FF000000");
            this.pieChart.Theme.UniformSeriesFill = new MindFusion.Drawing.SolidBrush("#FF90EE90");
            this.pieChart.Theme.UniformSeriesStroke = new MindFusion.Drawing.SolidBrush("#FF000000");
            this.pieChart.TitleFontName = null;
            this.pieChart.TitleFontSize = null;
            this.pieChart.TitleFontStyle = null;
            // 
            // btnAcc
            // 
            this.btnAcc.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAcc.Location = new System.Drawing.Point(110, 519);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(116, 50);
            this.btnAcc.TabIndex = 8;
            this.btnAcc.Text = "Account";
            this.btnAcc.UseVisualStyleBackColor = false;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnAppoinment
            // 
            this.btnAppoinment.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAppoinment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppoinment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAppoinment.Location = new System.Drawing.Point(110, 438);
            this.btnAppoinment.Name = "btnAppoinment";
            this.btnAppoinment.Size = new System.Drawing.Size(116, 50);
            this.btnAppoinment.TabIndex = 9;
            this.btnAppoinment.Text = "Appointment";
            this.btnAppoinment.UseVisualStyleBackColor = false;
            this.btnAppoinment.Click += new System.EventHandler(this.btnAppoinment_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 675);
            this.Controls.Add(this.btnAppoinment);
            this.Controls.Add(this.btnAcc);
            this.Controls.Add(this.btnPredic);
            this.Controls.Add(this.btnExpense);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pieChart);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnPredic;
        private MindFusion.Charting.WinForms.PieChart pieChart;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnAppoinment;
    }
}