using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            using(MoneyPred db = new MoneyPred())
            {
                User user = new User
                {
                    FirstName = txtFname.Text.ToString(),
                    LastName = txtLname.Text.ToString(),
                    EMail = txtEmail.Text.ToString(),
                    Proffesion = txtProf.Text.ToString(),
                    Password = txtPassword.Text.ToString(),
                    ISActive = true,

                };
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
    }
}
