using DataAdministration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectDefines;

namespace UI_Forms
{
    public partial class AddUserUI : Form
    {

        Login Login { get; set; }
        public User User { get; }
        public AdminUI AdminUI { get; }

        public AddUserUI(Login login)
        {
            Login = login;

            InitializeComponent();

            lblWelcome.Text = "Sign Up";

            dtpBirth.MaxDate = DateTime.Today;
            dtpBirth.Value = dtpBirth.MinDate;

        }

        public AddUserUI(User user, AdminUI adminUI)
        {
            User = user;
            AdminUI = adminUI;

            InitializeComponent();

            lblWelcome.Text = "Edit User";
            btnCancel.Text = "Delete";
            btnSignup.Text = "Add";

            txtFirstname.Text = user.firstName;
            txtLastname.Text = user.lastName;
            txtUsername.Text = user.email;

            string[] dateBirthTemp = user.birthDate.Split('-');

            dtpBirth.Value = new DateTime(
                Convert.ToInt32(dateBirthTemp[2]),
                Convert.ToInt32(dateBirthTemp[1]),
                Convert.ToInt32(dateBirthTemp[0])
                );
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(this.AdminUI != null)
            {
                this.Close();
                AdminUI.Show();

                ManageUsers manageUsers = new ManageUsers();
                AdminUI.users = manageUsers.GetUsers();

                AdminUI.Display();
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you wanna exit registration?", "Confirm Cancel!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
                Login.Show();
            }
            return;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            msgErr.Text = "";
            msgErr.ForeColor = Color.Black;

            if (!ValidateData())
            {
                return;
            }

            User user_t = new User();

            user_t.firstName = txtFirstname.Text;
            user_t.lastName = txtLastname.Text;

            string birthDay =
                dtpBirth.Value.Date.Day.ToString() + "-" +
                dtpBirth.Value.Date.Month.ToString() + "-" +
                dtpBirth.Value.Date.Year.ToString();

            user_t.birthDate = birthDay;
            user_t.ocupation = 2;
            user_t.email = txtUsername.Text;
            user_t.password = txtPassword.Text;

            ManageUsers manageUsers = new ManageUsers();
            manageUsers.AddUserToFile(user_t);

            ClearComponents();

            if (Login != null)
            {
                this.Close();
                Login.Show();
            }
        }

        private void ClearComponents()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            dtpBirth.Value = dtpBirth.MinDate;
        }
        
        private bool ValidateData()
        {
            if (txtFirstname.Text == string.Empty)
            {
                msgErr.Text = "FirstName required";
                msgErr.ForeColor = Color.Red;
                return false;
            }

            if(txtLastname.Text == string.Empty)
            {
                msgErr.Text = "LastName required";
                msgErr.ForeColor = Color.Red;
                return false;
            }

            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                              @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                              @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            Regex rx = new Regex(strRegex);

            if (!rx.IsMatch(txtUsername.Text))
            {
                msgErr.Text = "Wrong username inputed";
                msgErr.ForeColor = Color.Red;
                return false;
            }

            if (txtPassword.Text == string.Empty)
            {
                msgErr.Text = "Password required";
                msgErr.ForeColor = Color.Red;
                return false;
            }

            // Check for existing users
            ManageUsers manageUsers = new ManageUsers();

            List<User> users = manageUsers.GetUsers();

            foreach(User user in users)
            {
                if(user.email == txtUsername.Text)
                {
                    msgErr.Text = "Email atached to another account";
                    msgErr.ForeColor = Color.Red;
                    return false;
                }
            }

            return true;
        }
    }
}
