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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
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
