using System;
using System.Windows.Forms;
using System.IO;
using Register1;
using BLL;
namespace PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter UserName and Password");
                return;
            }
            BusinessLayer bl = new BusinessLayer();
            bl.Check(txtName.Text, txtPassword.Text);
            txtPassword.Text = "";
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = loginButton;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = loginButton;
        }
    }
}
