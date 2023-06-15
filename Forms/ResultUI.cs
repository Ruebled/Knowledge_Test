using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Forms
{
    public partial class ResultUI : Form
    {
        public StudUI StudUI { get; }
        public string V { get; }
        public AdminUI AdminUI { get; }

        public ResultUI()
        {
            InitializeComponent();
        }

        public ResultUI(string results, StudUI studUI)
        {
            StudUI = studUI;

            InitializeComponent();

            lblScore.Text = results;
        }

        public ResultUI(string v, AdminUI adminUI)
        {
            V = v;
            AdminUI = adminUI;

            InitializeComponent();

            lblScore.Text = v;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(StudUI != null)
            {
                StudUI.Show();
            }
            else
            {
                AdminUI.Show();
            }

            this.Close();
        }
    }
}
