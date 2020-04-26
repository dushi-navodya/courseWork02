using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseWork02
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
        public static class UserDetails
        {
            public static int UserId { get; set; }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please Enter user Details to Sign in or Sign Up!");
                return;
            }
            using(MoneyPred db = new MoneyPred())
            {

                var user = from users in db.Users
                           where (users.UserName == txtUserName.Text && users.Password == txtPassword.Text)
                           select users.UserID;
                UserDetails.UserId = user.FirstOrDefault();
                if(UserDetails.UserId ==0)
                {
                    MessageBox.Show("Invalid User Name or Password");
                    txtPassword.Clear();
                    txtUserName.Clear();
                    return;
                }
                    db.SaveChanges();
            }
            this.Hide();
            var homePage = new HomePage();
            homePage.Activate();
            homePage.ShowDialog();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var RegisterUser = new RegisterUser();
            RegisterUser.Activate();
            RegisterUser.ShowDialog();
        }
    }
}
