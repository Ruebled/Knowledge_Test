using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DataAdministration;
using ObjectDefines;
using System.Drawing;
using System.Dynamic;
using UI_Forms;
using System.Collections.Generic;

namespace UI_Forms
{
    public partial class Login : Form
    {
        User user;

        public Login()
        {
            InitializeComponent();

            user = null;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsername;
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

            ManageUsers manageUsers = new ManageUsers();

            List<User> users = manageUsers.GetUsers();

            foreach(User user in users)
            {
                if(user.email == username && user.password == password)
                {
                    this.user = user;
                    break;
                }
            }

            if (this.user == null)
            {
                lblMessage.Text = "User not exist";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            lblMessage.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";

            switch (this.user.ocupation)
            {
                case 1:
                    AdminUI adminUI = new AdminUI(this.user, this);

                    adminUI.Show();
                    this.Hide();
                    return;
                case 2:
                    StudUI studUI = new StudUI(this.user, this);

                    studUI.Show();
                    this.Hide();
                    return;
                default:
                    break;
                
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            AddUserUI addUserUI = new AddUserUI(this);
            addUserUI.Show();
            this.Hide();
        }
    }
}
