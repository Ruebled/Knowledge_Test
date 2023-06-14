using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAdministration;
using ObjectDefines;

namespace UI_Forms
{
    public partial class StudUI : Form
    {
        List<Test> temp_Test_list;
        User User { get; set; }
        Login loginForm;

        List<Test> tests = new List<Test>();

        public StudUI(User logedUser, Login login)
        {
            User = logedUser;
            loginForm = login;
            loginForm.Hide();

            InitializeComponent();

            listViewTests.Items.Clear();

            ManageTests TestAdministration = new ManageTests();
            tests = TestAdministration.GetTests();

            Display_Tests();
        }

        private void StudUI_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblEmail;

            lblEmail.Text = User.email;
            lblName.Text = (string.Format("{0} {1}", User.firstName, User.lastName));
        }

        private void Display_Tests()
        {

            FontFamily family = new FontFamily("Calibri");
            float font_size = 18;
            FontStyle style = FontStyle.Bold;

            listViewTests.Items.Clear();

            foreach (Test test in tests)
            {
                listViewTests.Items.Add(test.Name);
            }
            return;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ManageTests TestAdministration = new ManageTests();
            tests = TestAdministration.GetTests();

            temp_Test_list = new List<Test>();

            string search_query = txtSearch.Text;

            foreach(Test test in tests)
            {
                if(test.Name.IndexOf(search_query) != -1)
                {
                    temp_Test_list.Add(test);
                }
            }

            if (search_query != string.Empty)
            {
                tests = temp_Test_list;
            }
            
            Display_Tests();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you wanna exit?", "Confirm Exit!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
                loginForm.Show();
            }
            return;
        }

        private void listViewTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listViewTests.SelectedIndex;
            TestUI test_interface = new TestUI(tests[index], this);

            test_interface.Show();
        }
    }
}
