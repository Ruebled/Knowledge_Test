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

        private void btnExit_Click(object sender, EventArgs e)
        {
            StudUI.Show();
            this.Close();
        }
    }
}
