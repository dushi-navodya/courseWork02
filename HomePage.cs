using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Xunit;


using MindFusion.Charting;
using MindFusion.Charting.Components;
using MindFusion.Drawing;

using Color = System.Drawing.Color;

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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            using(MoneyPred db = new MoneyPred())
            {
                var result = (from expense in db.Expenses
                              join category in db.ExpenseCategories
                              on expense.CategoryId equals category.CategoryId
                              where expense.IsActive == 1
                              select new
                              {
                                  Amount = expense.Amount,
                                  CategoryName = category.CategoryName
                              }).ToList();

                var a = result.GroupBy(o => o.CategoryName)
                   .Select(g => new { CategoryName = g.Key, total = g.Sum(i => i.Amount) }).ToList();
                double[] total = new double[a.Count];
                string[] categoryName = new string[a.Count];

                for (int i = 0; i < a.Count; i++)
                {

                    total[i] = Convert.ToDouble(a[i].total);
                    categoryName[i] = a[i].CategoryName;
                }
                   
                pieChart.Series = new PieSeries(
                total,
                categoryName,
                categoryName)
                { Title = "Expenses For Categories" };
                pieChart.Dock = DockStyle.Fill;
                pieChart.Title = "Expenses For Categories";

                pieChart.AllowZoom = true;
                pieChart.AllowRotate = true;

                pieChart.ShowLegend = false;
                pieChart.ShowDataLabels = LabelKinds.OuterLabel;

                pieChart.Theme = new Theme();
                pieChart.Theme.SeriesFills = GetPieFills();
                pieChart.Theme.UniformSeriesStroke = new MindFusion.Drawing.SolidBrush(Color.FromArgb(240, 240, 240));
                pieChart.Theme.SeriesStrokeThicknesses = new List<List<double>>() { new List<double>() { 15 } };
                pieChart.Theme.HighlightStroke = new MindFusion.Drawing.SolidBrush(Color.White);
                pieChart.Theme.HighlightStrokeThickness = 10;
                pieChart.Theme.DataLabelsFontSize = 14;


            }
            
        }
        private List<List<MindFusion.Drawing.Brush>> GetPieFills()
        {
            var fills = new List<List<MindFusion.Drawing.Brush>>();

            fills.Add(new List<MindFusion.Drawing.Brush>() {
                new MindFusion.Drawing.SolidBrush(Color.FromArgb(102, 154, 204)),
                new MindFusion.Drawing.SolidBrush(Color.FromArgb(192, 192, 192)),
                new MindFusion.Drawing.SolidBrush(Color.FromArgb(0, 52, 102)),
                new MindFusion.Drawing.SolidBrush(Color.FromArgb(206, 0, 0)),
            });

            return fills;
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            AccountDetails accPage = new AccountDetails();
            accPage.Activate();
            accPage.Show();
        }

        private void btnAppoinment_Click(object sender, EventArgs e)
        {
            AppointmentPage appointment = new AppointmentPage();
            appointment.Activate();
            appointment.Show();
        }
    }
}
