using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseWork02
{
    public partial class SearchPage : Form
    {
        public SearchPage()
        {
            InitializeComponent();
        }
        public static class ExpenseDetails
        {
            public static int ExpenseId { get; set; }
            public static int IncomeId { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtpFromDate.Text) || string.IsNullOrEmpty(dtpToDate.Text))
            {
                MessageBox.Show("You must select Date range!");
                return;
            }
            else if (chkExpense.Checked)
            {
                using (MoneyPred db = new MoneyPred())
                {
                    var expenseDetails = from expenses in db.Expenses
                                         where dtpFromDate.Value < expenses.Date
                                         && dtpToDate.Value > expenses.Date
                                         select new
                                         {Description = expenses.Description, Amount = expenses.Amount, Date = expenses.Date, Id = expenses.ExpensseId};

                    expenseDataGrid.DataSource = expenseDetails.ToList();
                }
                expenseDataGrid.Visible = true;
                lblExpGrid.Visible = true;
                
            }
            else if (chkIncome.Checked)
            {
                using (MoneyPred db = new MoneyPred())
                {
                    var incomeDetails = from incomes in db.Incomes
                                         where dtpFromDate.Value < incomes.Date
                                         && dtpToDate.Value > incomes.Date
                                         select new
                                         { Description = incomes.Description, Amount = incomes.Amount, Date = incomes.Date, Id = incomes.ExpensseId };

                    incomeDataGrid.DataSource = incomeDetails.ToList();
                }
                incomeDataGrid.Visible = true;
                lblIncGrid.Visible = true;
            }


        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var expId = expenseDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

                ExpenseDetails.ExpenseId = Convert.ToInt32(expId);


                this.Hide();
                var expensePage = new ExpensePage();
                expensePage.Activate();
                expensePage.Show();
            }
        }

        private void incomeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var incId = incomeDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

                ExpenseDetails.IncomeId = Convert.ToInt32(incId);


                this.Hide();
                var incomePage = new IncomePage();
                incomePage.Activate();
                incomePage.Show();
            }
        }
    }
}
