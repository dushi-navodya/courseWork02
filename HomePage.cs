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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {

            var incomePage = new IncomePage();
            incomePage.Activate();
            incomePage.ShowDialog();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            var expensePage = new ExpensePage();
            expensePage.Activate();
            expensePage.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FinancePredicPage financePredicPage = new FinancePredicPage();
            financePredicPage.Activate();
            financePredicPage.Show();
        }
    }
}
