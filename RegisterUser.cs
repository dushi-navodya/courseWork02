using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace courseWork02
{
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFname.Text) || string.IsNullOrWhiteSpace(txtLname.Text) || string.IsNullOrWhiteSpace(txtUserName.Text)
               || string.IsNullOrWhiteSpace(txtProf.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please Enter Values to all the fields!");
                return;

            }
            using (MoneyPred db = new MoneyPred())
            {
                User user = new User
                {
                    FirstName = txtFname.Text.ToString(),
                    LastName = txtLname.Text.ToString(),
                    EMail = txtEmail.Text.ToString(),
                    Proffesion = txtProf.Text.ToString(),
                    UserName = txtUserName.Text.ToString(),
                    Password = txtPassword.Text.ToString(),
                    isActive = 1,

                };
                db.Users.Add(user);
                db.SaveChanges();
            }
            this.Hide();
            var loginPage = new Login();
            loginPage.Activate();
            loginPage.ShowDialog();
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (!reg.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Please Enter valid Email address");
            }
        }        
        private void txtCPassword_Leave(object sender, EventArgs e)
        {
            if (string.Compare(txtCPassword.Text, txtPassword.Text, true) == 1)
            {
                MessageBox.Show("Passwords Dont Match!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox textbox = new TextBox();
            int count = panel1.Controls.OfType<TextBox>().ToList().Count;
            textbox.Location = new System.Drawing.Point(10, 25 * count);
            textbox.Size = new System.Drawing.Size(80, 20);
            textbox.Name = "txt_" + (count + 1);
            panel1.Controls.Add(textbox);
             

            //Create the dynamic Button to remove the TextBox.
            Button button = new Button();
            button.Location = new System.Drawing.Point(95, 25 * count);
            button.Size = new System.Drawing.Size(60, 20);
            button.Name = "btnDelete_" + (count + 1);
            button.Text = "Delete";
            button.Click += new System.EventHandler(this.btnMinus_Click);
            panel1.Controls.Add(button);

            SaveAsXML(count);
        }
        private void SaveAsXML(int count)
        {
            String workingDir = Directory.GetCurrentDirectory();
            // Create a new file in the working directory
            XmlTextWriter textWriter = new XmlTextWriter("UserDetails.xml", null);
            // Opens the document
            textWriter.WriteStartDocument();
            // Write comments
            textWriter.WriteComment("Current USer Details");
            textWriter.WriteComment("UserDetails.xml in root dir");
            // Write first element
            
            textWriter.WriteStartElement("User Detail");
            // Write next element
            textWriter.WriteElementString("First Name", txtFname.Text.ToString());
            textWriter.WriteElementString("Last Name", txtLname.Text.ToString());
            textWriter.WriteElementString("User Name", txtUserName.Text.ToString());
            textWriter.WriteElementString("Email", txtEmail.Text.ToString());
            textWriter.WriteElementString("Proffession", txtProf.Text.ToString());
            for (int i = 0; i < count; i++)
            {
                var number = string.Concat("telephone", i);
                TextBox txt = (TextBox)panel1.Controls.Find("txt_" + i, true)[0];
                textWriter.WriteElementString(number, txt.Text.ToString());
            }

            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            // close writer
            textWriter.Close();
            Console.ReadLine();
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);

            //Determine the Index of the Button.
            int index = int.Parse(button.Name.Split('_')[1]);

            //Find the TextBox using Index and remove it.
            panel1.Controls.Remove(panel1.Controls.Find("txt_" + index, true)[0]);

            //Remove the Button.
            panel1.Controls.Remove(button);

            //Rearranging the Location controls.
            foreach (Button btn in panel1.Controls.OfType<Button>())
            {
                int controlIndex = int.Parse(btn.Name.Split('_')[1]);
                if (controlIndex > index)
                {
                    TextBox txt = (TextBox)panel1.Controls.Find("txt_" + controlIndex, true)[0];
                    btn.Top = btn.Top - 25;
                    txt.Top = txt.Top - 25;
                }
            }
        }
    }
}
