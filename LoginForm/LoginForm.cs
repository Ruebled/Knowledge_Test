using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DataAdministration;
using ObjectDefines;
using System.Drawing;
using System.Dynamic;
using UI_Forms;

namespace UI_Forms
{
    public partial class Login : Form
    {
        userLogin user;

        public Login()
        {
            InitializeComponent();

            user = new userLogin();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblWelcome;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                lblMessage.ForeColor = Color.Red;
                return;
            }
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User logedUser = user.getUser(username, password);

            if (logedUser == null)
            {
                lblMessage.Text = "User not exist";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            lblMessage.Text = "";

            if(logedUser is Stud)
            {
                StudUI studUI = new StudUI(logedUser, this);

                studUI.Show();
                ///this.Close();
                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you wanna exit?", "Confirm Exit!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
            return;
        }

        private bool ValidateData()
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                              @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                              @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            Regex rx = new Regex(strRegex);

            if (txtUsername.Text.Length == 0)
            {
                lblMessage.Text = "Username cannot be empty";
                return false;
            }

            if (txtPassword.Text.Length == 0)
            {
                lblMessage.Text = "Password cannot be empty";
                return false;
            }

            if(!rx.IsMatch(txtUsername.Text))
            {
                lblMessage.Text = "Wrong username inputed";
                return false;
            }

            return true;
        }
    }
}
