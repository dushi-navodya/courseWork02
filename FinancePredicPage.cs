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
    public partial class FinancePredicPage : Form
    {
        public FinancePredicPage()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FinancePredicPage_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            using (MoneyPred db = new MoneyPred())
            {
                var allIncomes = from income in db.Incomes
                                  where income.Date < DateTime.Now
                                  && income.Date > startDate
                                  select income.Amount;

                var totalIncome = allIncomes.Sum();

                txtIncome.Text = totalIncome.ToString();

                var allExpense = from expense in db.Expenses
                                 where expense.Date < DateTime.Now
                                  && expense.Date > startDate
                                 select expense.Amount;

                var totalExpense = allExpense.Sum();

                txtExpense.Text = totalExpense.ToString();
            }
        }

        private void btnPredcWeek_Click(object sender, EventArgs e)
        {

            int method = 1;
            var amount = PredExpense(method);
            txtWeekExp.Visible = true;
            lblPerWeek.Visible = true;
            txtPerDay.Visible = false;
            lblPerDay.Visible = false;
            txtWeekExp.Text = amount.ToString();
        }
        private double PredExpense(int prefMethod)
        {
            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            var avarageExpense = Convert.ToDouble(txtExpense.Text); ;
            var noOfDays = (DateTime.Now - startDate).TotalDays;

            var perDayExpens = avarageExpense / noOfDays;
            if(prefMethod == 1)
            {
                return perDayExpens * 7;
            }
            else if(prefMethod == 2)
            {
                return perDayExpens;
            }

            return perDayExpens;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int method = 2;
            var amount = PredExpense(method);
            txtWeekExp.Visible = false;
            lblPerWeek.Visible = false;
            txtPerDay.Visible = true;
            lblPerDay.Visible = true;
            txtPerDay.Text = amount.ToString();
        }
    }
}
