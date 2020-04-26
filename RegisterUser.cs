using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseWork02
{
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFname.Text) || string.IsNullOrWhiteSpace(txtLname.Text) || string.IsNullOrWhiteSpace(txtUserName.Text)
               || string.IsNullOrWhiteSpace(txtProf.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please Enter Values to all the fields!");
                return;

            }
            using (MoneyPred db = new MoneyPred())
            {
                User user = new User
                {
                    FirstName = txtFname.Text.ToString(),
                    LastName = txtLname.Text.ToString(),
                    EMail = txtEmail.Text.ToString(),
                    Proffesion = txtProf.Text.ToString(),
                    UserName = txtUserName.Text.ToString(),
                    Password = txtPassword.Text.ToString(),
                    isActive = 1,

                };
                db.Users.Add(user);
                db.SaveChanges();
            }
            this.Hide();
            var loginPage = new Login();
            loginPage.Activate();
            loginPage.ShowDialog();
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (!reg.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Please Enter valid Email address");
            }
        }        
        private void txtCPassword_Leave(object sender, EventArgs e)
        {
            if (string.Compare(txtCPassword.Text, txtPassword.Text, true) == 1)
            {
                MessageBox.Show("Passwords Dont Match!");
            }
        }
    }
}
