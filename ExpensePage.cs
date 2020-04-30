using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static courseWork02.AppointmentPage;
using static courseWork02.Login;
using static courseWork02.SearchPage;

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
                    CategoryId = Convert.ToInt16(cmdExpCategory.SelectedValue)
                };
                db.Expenses.Add(expense);
                db.SaveChanges();
                if (AppoinmentDetails.AppoinmentId != 0)
                {
                    var expenseId = from exp in db.Expenses
                                    select exp;
                    var result = db.Appoinments.SingleOrDefault(b => b.AppoinmentId == AppoinmentDetails.AppoinmentId);
                    if (result != null)
                    {
                        result.ExpenseId = Convert.ToInt32(expenseId.First());
                        db.SaveChanges();
                    }
                }
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
            // TODO: This line of code loads data into the 'testDataSet1.ExpenseCategory' table. You can move, or remove it, as needed.
            this.expenseCategoryTableAdapter1.Fill(this.testDataSet1.ExpenseCategory);
            if (ExpenseDetails.ExpenseId != 0)
            {
                using(MoneyPred db = new MoneyPred())
                {
                    var expenseDetails = from expense in db.Expenses
                                         where expense.ExpensseId == ExpenseDetails.ExpenseId && expense.IsActive == 1
                                         select expense;

                    foreach (var item in expenseDetails)
                    {
                        this.txtEAmount.Text = item.Amount.ToString();
                        this.txtEAmount.Text = item.Amount.ToString();
                        this.txtEDescription.Text = item.Description.ToString();
                        this.txtEPayerName.Text = item.PayerName.ToString();
                        this.dtpEDate.Text = item.Date.ToString();
                        this.dtpESpecDate.Text = item.SpecDate.ToString();
                        this.cmdExpCategory.SelectedIndex = cmdExpCategory.Items.IndexOf(item.CategoryId);
                        this.rbEEnd.Checked = item.IsEndMonth == 1 ? true : false;
                        this.rbESpecific.Checked = item.IsSpecDate == 1 ? true : false;
                        this.rbIEBegining.Checked = item.IsBeginingMonth == 1 ? true : false;
                        this.chkEReurEvent.Checked = item.IsRecurringEvent == 1 ? true : false;

                    }
                }
                
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

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.expenseCategoryTableAdapter1.FillBy(this.testDataSet1.ExpenseCategory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnEDelete_Click(object sender, EventArgs e)
        {
            using(MoneyPred db = new MoneyPred())
            {
                var result = db.Expenses.SingleOrDefault(b => b.ExpensseId == ExpenseDetails.ExpenseId);
                if (result != null)
                {
                    result.IsActive =0;
                    db.SaveChanges();
                }
            }
        }
    }
}
