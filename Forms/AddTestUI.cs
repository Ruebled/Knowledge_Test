using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAdministration;
using ObjectDefines;

namespace UI_Forms
{
    public partial class AddTestUI : Form
    {
        Test test_t;
        public AdminUI AdminUI { get; }

        public AddTestUI()
        {
            InitializeComponent();
        }

        public AddTestUI(AdminUI adminUI)
        {
            AdminUI = adminUI;
            test_t = new Test();
            InitializeComponent();
            int i = 0;

            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
            dgvTest.Rows.Add(string.Format("Question {0}", i++), "");
        }

        private void SaveTest()
        {
            if (test_t != null)
            {
                ManageTests manageTest = new ManageTests();
                manageTest.AddTestToFile(test_t);
            }
        }

        private void dgvTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
