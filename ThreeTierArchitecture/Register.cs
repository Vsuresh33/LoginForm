using System;
using System.IO;
using System.Windows.Forms;
using PL;
using DLL;
namespace Register1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textPassword.PasswordChar = '*';
            textRePassword.PasswordChar = '*';
        }
        private void labelRePassword_Click(object sender, EventArgs e)
        {
        }
        private void textUser_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnRegister;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            DataAccessLayer dl = new DataAccessLayer();
            string Gender = "",line;
            StreamReader file = new StreamReader(@"C:\Users\Suresh.vakkalakula\Desktop\Forms\ThreeTierArchitecture\ThreeTierArchitecture\RegisteredDetails.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] subString = line.Split('\t');
                if (string.Equals(textUser.Text, subString[0]))
                {
                    MessageBox.Show("Username already Present");
                    return;
                }
                if (string.Equals(textPhone.Text, subString[4]))
                {
                    MessageBox.Show("Mobile number already regstered");
                    return;
                }
            }
            file.Close();
            if (radioMale.Checked)
            {
                Gender = "Male";
            }
            if(radioFemale.Checked)
            {
                Gender = "Female";
            }
            if (textUser.Text== "" || textPassword.Text== "" || textRePassword.Text == "" || textPhone.Text == "")
            {
                MessageBox.Show("Please make sure that mandatory fields are filled");
                textPassword.Text = "";
                textRePassword.Text = "";
                return;
            }
            if(!string.Equals(textPassword.Text, textRePassword.Text))
            {
                MessageBox.Show("Re-entered password is mismatched");
                textPassword.Text = "";
                textRePassword.Text = "";
                return;
            }
            if(textPassword.Text.Length <8)
            {
                MessageBox.Show("Password Minimum length should be 8");
                textPassword.Text = "";
                textRePassword.Text = "";
                return;
            }
            dl.Store(textUser.Text, textPassword.Text,Gender,textAddr.Text,textPhone.Text);
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnRegister;
        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnRegister;
        }

        private void textAddr_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnRegister;
        }

        private void textRePassword_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnRegister;
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnRegister;
        }
    }
}