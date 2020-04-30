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
    public partial class AppointmentPage : Form
    {
        public AppointmentPage()
        {
            InitializeComponent();
        }
        public static class AppoinmentDetails
        {
            public static int AppoinmentId { get; set; }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using(MoneyPred db = new MoneyPred())
            {
                Appoinment appoinmentDetails = new Appoinment
                {
                    InviteeName = txtInviteeName.Text.ToString(),
                    Location = txtLocation.Text.ToString(),
                    Purpose = txtPurpose.Text.ToString()
                };

                db.Appoinments.Add(appoinmentDetails);
                db.SaveChanges();

                var appoinmentId = from appoinment in db.Appoinments
                                   select appoinment;

                AppoinmentDetails.AppoinmentId = Convert.ToInt32(appoinmentId.First());

                btnExpense.Visible = true;
                btnIncome.Visible = true;
            }
        }

        private void txtCatIcon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatOwner_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIcon_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoryOwner_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoryType_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoryName_Click(object sender, EventArgs e)
        {

        }

        private void btnCatSearch_Click(object sender, EventArgs e)
        {
            ExpensePage expense = new ExpensePage();
            expense.Activate();
            expense.Show();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            IncomePage income = new IncomePage();
            income.Activate();
            income.Show();
        }
    }
}
