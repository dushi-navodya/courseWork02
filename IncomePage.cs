using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static courseWork02.Login;

namespace courseWork02
{
    public partial class IncomePage : Form
    {
        public IncomePage()
        {
            InitializeComponent();
        }

        private void IncomePage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String workingDir = Directory.GetCurrentDirectory();
            // Create a new file in the working directory
            XmlTextWriter textWriter = new XmlTextWriter("myXMLFile.xml", null);
            // Opens the document
            textWriter.WriteStartDocument();
            // Write comments
            textWriter.WriteComment(txtDescription.Text);
            textWriter.WriteComment("myXmlFile.xml in root dir");
            // Write first element
            textWriter.WriteStartElement("Student");
            // Write next element
            textWriter.WriteStartElement("Name", "");
            textWriter.WriteString("Some_Student");
            textWriter.WriteEndElement();
            // Write some more elements
            textWriter.WriteStartElement("Course", "");
            textWriter.WriteString("BSc Computer Science");
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Modules", "");
            //nested element
            textWriter.WriteStartElement("Module", "");
            textWriter.WriteString("ECSE501 OOD");
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            // Ends the document.
            textWriter.WriteEndDocument();
            // close writer
            textWriter.Close();
            Console.ReadLine();

            using (MoneyPred db = new MoneyPred())
            {
                Income income = new Income
                {
                    Description = txtDescription.Text.ToString(),
                    PayerName = txtPayerName.Text.ToString(),
                    Amount = Convert.ToDecimal(txtAmount.Text),
                    Date = DateTime.Parse(dtpDate.Text),
                    IsRecurringIncome = Convert.ToByte(chkReurEvent.Checked),
                    ISActive = 1,
                    IsEndMonth = Convert.ToByte(rbIncomeEnd.Checked),
                    IsBeginingMonth = Convert.ToByte(rbIncomeBegining.Checked),
                    IsSpecDate = Convert.ToByte(rbIncomeSpecific.Checked),
                    SpecDate = DateTime.Parse(dtpSpecDate.Text),
                    UserID = UserDetails.UserId
                };
                db.Incomes.Add(income);
                db.SaveChanges();
            }
         }
    }
}
