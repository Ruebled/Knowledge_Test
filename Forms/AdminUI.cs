using DataAdministration;
using ObjectDefines;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace UI_Forms
{
    public partial class AdminUI : Form
    {
        List<Test> temp_Test_list;
        List<User> temp_User_list;
        public List<User> users { get; set; }
        public List<Test> tests { get; set; }
        public User User { get; }
        public Login Login { get; }

        bool state = false;

        public AdminUI()
        {
            InitializeComponent();
        }

        public AdminUI(User user, Login login)
        {
            User = user;
            Login = login;

            InitializeComponent();

            lstBox.Items.Clear();

            ManageTests manageTests = new ManageTests();
            tests = manageTests.GetTests();

            ManageUsers manageUsers = new ManageUsers();
            users = manageUsers.GetUsers();

            Display();
        }

        public void Display()
        {
            if (state)
            {
                Display_Users();
                btnAddTest.Visible = false;
                lblEdit.Text = "Editing Users";
            }
            else
            {
                Display_Tests();
                btnAddTest.Visible = true;
                lblEdit.Text = "Editing Tests";
            }
            return;
        }

        private void Display_Tests()
        {

            FontFamily family = new FontFamily("Calibri");
            float font_size = 18;
            FontStyle style = FontStyle.Bold;

            lstBox.Items.Clear();

            foreach (Test test in tests)
            {
                lstBox.Items.Add(test.Name);
            }
            return;
        }

        private void Display_Users()
        {

            FontFamily family = new FontFamily("Calibri");
            float font_size = 18;
            FontStyle style = FontStyle.Bold;

            lstBox.Items.Clear();

            foreach (User user in users)
            {
                lstBox.Items.Add(user.firstName+ " " + user.lastName);
            }
            return;
        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            state = !state;
            Display();
            return;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (state)
            {
                ManageUsers manageUsers = new ManageUsers();
                users = manageUsers.GetUsers();
                searchUser(txtQuery.Text);
            }
            else
            {
                ManageTests manageTests = new ManageTests();
                tests = manageTests.GetTests();
                searchTest(txtQuery.Text);
            }
        }

        private void searchTest(string search_query)
        {
            temp_Test_list = new List<Test>();

            foreach (Test test in tests)
            {
                if (test.Name.IndexOf(search_query) != -1)
                {
                    temp_Test_list.Add(test);
                }
            }

            if (search_query != string.Empty)
            {
                tests = temp_Test_list;
            }

            Display();
        }

        private void searchUser(string search_query)
        {
            temp_User_list = new List<User>();

            foreach (User user in users)
            {
                if (user.firstName.IndexOf(search_query) != -1 || user.lastName.IndexOf(search_query) != -1)
                {
                    temp_User_list.Add(user);
                }
            }

            if(search_query != string.Empty)
            {
                users = temp_User_list;
            }
            
            Display();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you wanna exit?", "Confirm Exit!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
                Login.Show();
            }
            return;
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstBox.SelectedIndex;

            if (state)
            {
                ManageUsers manageUsers = new ManageUsers();
                manageUsers.DeleteUser(users[index]);

                AddUserUI addUserUI = new AddUserUI(users[index], this);
                users = manageUsers.GetUsers();

                addUserUI.Show();
                this.Hide();
            }
            else
            {
                /*ManageTests manageTests = new ManageTests();
                tests = manageTests.GetTests();*/
            }
            
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            AddTestUI addTestUI = new AddTestUI(this);
            addTestUI.Show();
            this.Hide();
        }
    }
}
