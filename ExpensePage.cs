using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static courseWork02.Login;

namespace courseWork02
{
    public partial class ExpensePage : Form
    {
        public ExpensePage()
        {
            InitializeComponent();
        }

        private void btnESave_Click(object sender, EventArgs e)
        {
            using (MoneyPred db = new MoneyPred())
            {
                Expense expense = new Expense
                {
                    Description = txtEDescription.Text.ToString(),
                    PayerName = txtEPayerName.Text.ToString(),
                    Amount = Convert.ToDecimal(txtEAmount.Text),
                    Date = DateTime.Parse(dtpEDate.Text),
                    IsRecurringEvent = Convert.ToByte(chkEReurEvent.Checked),
                    IsActive = 1,
                    IsEndMonth = Convert.ToByte(rbEEnd.Checked),
                    IsBeginingMonth = Convert.ToByte(rbIEBegining.Checked),
                    IsSpecDate = Convert.ToByte(rbESpecific.Checked),
                    SpecDate = DateTime.Parse(dtpESpecDate.Text),
                    UserID = UserDetails.UserId,
                    CategoryId = 1
                };
                db.Expenses.Add(expense);
                db.SaveChanges();
            }
        }

        private void btnESearch_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var expenseSearchPage = new SearchPage();
            expenseSearchPage.Activate();
            expenseSearchPage.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            var expenseCategory = new ExpenseCategoryPage();
            expenseCategory.Activate();
            expenseCategory.ShowDialog();
        }

        private void ExpensePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.ExpenseCategory' table. You can move, or remove it, as needed.
            this.expenseCategoryTableAdapter.Fill(this.testDataSet.ExpenseCategory);
            using (MoneyPred db = new MoneyPred())
            {
                var categorieList = from categories in db.ExpenseCategories
                                 where categories.ISActive == 1
                                 select categories.CategoryName;

                DataTable dt = new DataTable();
                
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.expenseCategoryTableAdapter.FillBy(this.testDataSet.ExpenseCategory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
