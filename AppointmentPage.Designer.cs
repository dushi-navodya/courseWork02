namespace courseWork02
{
    partial class AppointmentPage
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
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtInviteeName = new System.Windows.Forms.TextBox();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lbInviteeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIncome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExpense
            // 
            this.btnExpense.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnExpense.Location = new System.Drawing.Point(524, 95);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(146, 50);
            this.btnExpense.TabIndex = 23;
            this.btnExpense.Text = "Create Expense";
            this.btnExpense.UseVisualStyleBackColor = false;
            this.btnExpense.Click += new System.EventHandler(this.btnCatSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnDelete.Location = new System.Drawing.Point(382, 304);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 44);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSave.Location = new System.Drawing.Point(270, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 44);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPurpose
            // 
            this.txtPurpose.Location = new System.Drawing.Point(366, 213);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(100, 22);
            this.txtPurpose.TabIndex = 19;
            this.txtPurpose.TextChanged += new System.EventHandler(this.txtCatOwner_TextChanged);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(366, 153);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 18;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtCatType_TextChanged);
            // 
            // txtInviteeName
            // 
            this.txtInviteeName.Location = new System.Drawing.Point(366, 95);
            this.txtInviteeName.Name = "txtInviteeName";
            this.txtInviteeName.Size = new System.Drawing.Size(100, 22);
            this.txtInviteeName.TabIndex = 17;
            this.txtInviteeName.TextChanged += new System.EventHandler(this.txtCatName_TextChanged);
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurpose.ForeColor = System.Drawing.Color.Teal;
            this.lblPurpose.Location = new System.Drawing.Point(71, 209);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(85, 25);
            this.lblPurpose.TabIndex = 15;
            this.lblPurpose.Text = "Purpose";
            this.lblPurpose.Click += new System.EventHandler(this.lblCategoryOwner_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.Teal;
            this.lblLocation.Location = new System.Drawing.Point(71, 153);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(86, 25);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Location";
            this.lblLocation.Click += new System.EventHandler(this.lblCategoryType_Click);
            // 
            // lbInviteeName
            // 
            this.lbInviteeName.AutoSize = true;
            this.lbInviteeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInviteeName.ForeColor = System.Drawing.Color.Teal;
            this.lbInviteeName.Location = new System.Drawing.Point(71, 93);
            this.lbInviteeName.Name = "lbInviteeName";
            this.lbInviteeName.Size = new System.Drawing.Size(126, 25);
            this.lbInviteeName.TabIndex = 13;
            this.lbInviteeName.Text = "Invitee Name";
            this.lbInviteeName.Click += new System.EventHandler(this.lblCategoryName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(66, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Apoinment Schedular";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnIncome.Location = new System.Drawing.Point(524, 184);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(146, 50);
            this.btnIncome.TabIndex = 24;
            this.btnIncome.Text = "Create Income";
            this.btnIncome.UseVisualStyleBackColor = false;
            // 
            // AppointmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.btnExpense);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtInviteeName);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lbInviteeName);
            this.Controls.Add(this.label1);
            this.Name = "AppointmentPage";
            this.Text = "AppointmentPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtInviteeName;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lbInviteeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIncome;
    }
}