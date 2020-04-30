namespace courseWork02
{
    partial class RegisterUser
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
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblProf = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCPassword = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtProf = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCPassword = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(205, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register User Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.Teal;
            this.lblFname.Location = new System.Drawing.Point(61, 124);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(106, 25);
            this.lblFname.TabIndex = 1;
            this.lblFname.Text = "First Name";
            this.lblFname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.ForeColor = System.Drawing.Color.Teal;
            this.lblLname.Location = new System.Drawing.Point(61, 164);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(106, 25);
            this.lblLname.TabIndex = 2;
            this.lblLname.Text = "Last Name";
            this.lblLname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Teal;
            this.lblEmail.Location = new System.Drawing.Point(61, 359);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProf.ForeColor = System.Drawing.Color.Teal;
            this.lblProf.Location = new System.Drawing.Point(61, 405);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(109, 25);
            this.lblProf.TabIndex = 4;
            this.lblProf.Text = "Proffession";
            this.lblProf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Teal;
            this.lblPassword.Location = new System.Drawing.Point(61, 209);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 25);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCPassword
            // 
            this.lblCPassword.AutoSize = true;
            this.lblCPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPassword.ForeColor = System.Drawing.Color.Teal;
            this.lblCPassword.Location = new System.Drawing.Point(61, 259);
            this.lblCPassword.Name = "lblCPassword";
            this.lblCPassword.Size = new System.Drawing.Size(171, 25);
            this.lblCPassword.TabIndex = 6;
            this.lblCPassword.Text = "Confirm Password";
            this.lblCPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(302, 127);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(117, 22);
            this.txtFname.TabIndex = 7;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(302, 167);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(117, 22);
            this.txtLname.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(302, 362);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(117, 22);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyUp);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(302, 408);
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(117, 22);
            this.txtProf.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(302, 212);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(117, 22);
            this.txtPassword.TabIndex = 11;
            // 
            // txtCPassword
            // 
            this.txtCPassword.Location = new System.Drawing.Point(302, 262);
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.Size = new System.Drawing.Size(117, 22);
            this.txtCPassword.TabIndex = 12;
            this.txtCPassword.Leave += new System.EventHandler(this.txtCPassword_Leave);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSignUp.Location = new System.Drawing.Point(501, 209);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(111, 56);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(302, 308);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(117, 22);
            this.txtUserName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(61, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "User Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(61, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Telephone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(534, 451);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(35, 23);
            this.btnPlus.TabIndex = 18;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(292, 451);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 198);
            this.panel1.TabIndex = 20;
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtCPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtProf);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblCPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.label1);
            this.Name = "RegisterUser";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCPassword;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtProf;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCPassword;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Panel panel1;
    }
}

