namespace courseWork02
{
    partial class ExpenseCategoryPage
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
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryType = new System.Windows.Forms.Label();
            this.lblCategoryOwner = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.txtCatType = new System.Windows.Forms.TextBox();
            this.txtCatOwner = new System.Windows.Forms.TextBox();
            this.txtCatIcon = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCatSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(61, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expence Category";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.ForeColor = System.Drawing.Color.Teal;
            this.lblCategoryName.Location = new System.Drawing.Point(66, 92);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(149, 25);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "Category Name";
            // 
            // lblCategoryType
            // 
            this.lblCategoryType.AutoSize = true;
            this.lblCategoryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryType.ForeColor = System.Drawing.Color.Teal;
            this.lblCategoryType.Location = new System.Drawing.Point(66, 152);
            this.lblCategoryType.Name = "lblCategoryType";
            this.lblCategoryType.Size = new System.Drawing.Size(142, 25);
            this.lblCategoryType.TabIndex = 2;
            this.lblCategoryType.Text = "Category Type";
            // 
            // lblCategoryOwner
            // 
            this.lblCategoryOwner.AutoSize = true;
            this.lblCategoryOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryOwner.ForeColor = System.Drawing.Color.Teal;
            this.lblCategoryOwner.Location = new System.Drawing.Point(66, 208);
            this.lblCategoryOwner.Name = "lblCategoryOwner";
            this.lblCategoryOwner.Size = new System.Drawing.Size(155, 25);
            this.lblCategoryOwner.TabIndex = 3;
            this.lblCategoryOwner.Text = "Category Owner";
            this.lblCategoryOwner.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.Teal;
            this.lblIcon.Location = new System.Drawing.Point(66, 271);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(109, 25);
            this.lblIcon.TabIndex = 4;
            this.lblIcon.Text = "Select Icon";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(361, 94);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(100, 22);
            this.txtCatName.TabIndex = 5;
            // 
            // txtCatType
            // 
            this.txtCatType.Location = new System.Drawing.Point(361, 152);
            this.txtCatType.Name = "txtCatType";
            this.txtCatType.Size = new System.Drawing.Size(100, 22);
            this.txtCatType.TabIndex = 6;
            // 
            // txtCatOwner
            // 
            this.txtCatOwner.Location = new System.Drawing.Point(361, 212);
            this.txtCatOwner.Name = "txtCatOwner";
            this.txtCatOwner.Size = new System.Drawing.Size(100, 22);
            this.txtCatOwner.TabIndex = 7;
            // 
            // txtCatIcon
            // 
            this.txtCatIcon.Location = new System.Drawing.Point(361, 271);
            this.txtCatIcon.Name = "txtCatIcon";
            this.txtCatIcon.Size = new System.Drawing.Size(100, 22);
            this.txtCatIcon.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSave.Location = new System.Drawing.Point(377, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 44);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnDelete.Location = new System.Drawing.Point(489, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 44);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCatSearch
            // 
            this.btnCatSearch.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCatSearch.Location = new System.Drawing.Point(512, 93);
            this.btnCatSearch.Name = "btnCatSearch";
            this.btnCatSearch.Size = new System.Drawing.Size(79, 24);
            this.btnCatSearch.TabIndex = 11;
            this.btnCatSearch.Text = "Search";
            this.btnCatSearch.UseVisualStyleBackColor = false;
            // 
            // ExpenseCategoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.btnCatSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCatIcon);
            this.Controls.Add(this.txtCatOwner);
            this.Controls.Add(this.txtCatType);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.lblCategoryOwner);
            this.Controls.Add(this.lblCategoryType);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.label1);
            this.Name = "ExpenseCategoryPage";
            this.Text = "ExpenseCategoryPage";
            this.Load += new System.EventHandler(this.ExpenseCategoryPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryType;
        private System.Windows.Forms.Label lblCategoryOwner;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.TextBox txtCatType;
        private System.Windows.Forms.TextBox txtCatOwner;
        private System.Windows.Forms.TextBox txtCatIcon;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCatSearch;
    }
}