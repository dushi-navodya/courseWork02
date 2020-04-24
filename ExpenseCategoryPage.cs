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
    public partial class ExpenseCategoryPage : Form
    {
        public ExpenseCategoryPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExpenseCategoryPage_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MoneyPred db = new MoneyPred())
            {
                ExpenseCategory category = new ExpenseCategory
                {
                    CategoryName = txtCatName.Text.ToString(),
                    CategoryOwner = txtCatOwner.Text.ToString(),
                    CategoryType = txtCatType.Text.ToString(),
                    Icon = txtCatIcon.Text.ToString(),
                };
                db.ExpenseCategories.Add(category);
                db.SaveChanges();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
