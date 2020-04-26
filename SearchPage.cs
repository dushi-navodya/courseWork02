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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtpFromDate.Text) || string.IsNullOrEmpty(dtpToDate.Text))
            {
                MessageBox.Show("You must select Date range!");
                return;
            }
            else if (rdbExpense.Checked)
            {
                BindingSource bindingsource = new BindingSource();
                DataSet dataSet = new DataSet();
                using (MoneyPred db = new MoneyPred())
                {
                    var expenseDetails = from expenses in db.Expenses
                                         where dtpFromDate.Value < expenses.Date
                                         && dtpToDate.Value > expenses.Date
                                         select new
                                         {Description = expenses.Description, Amount = expenses.Amount, Date = expenses.Date};

                    dataGrid.DataSource = expenseDetails.ToList();
                }
                //string Connection = "Data Source=MSI/SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
                //string selectCommand = "SELECT Description, Amount, Date FROM [dbo].[ExpenseCategory] where " +
                //    "Convert.ToDateTime(dtpFromDate.Text) < expenses.Date && Convert.ToDateTime(dtpToDate.Text) > expenses.Date";
                //SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, Connection);

                //SqlCommandBuilder cmd = new SqlCommandBuilder(dataAdapter);

                //dataAdapter.Fill(dataSet);
                //bindingsource.DataSource = dataSet;
                //dataGrid.DataSource = bindingsource;
            } 


        }
    }
}
