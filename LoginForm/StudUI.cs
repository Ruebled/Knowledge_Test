using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectDefines;

namespace UI_Forms
{
    public partial class StudUI : Form
    {
        User User { get; set; }
        UI_Forms.Login loginForm;

        public StudUI(User logedUser, Login login)
        {
            User = logedUser;
            loginForm = login;
            loginForm.Hide();

            InitializeComponent();

        }

        private void StudUI_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblEmail;

            lblEmail.Text = User.email;
            lblName.Text = (string.Format("{0} {1}", User.firstName, User.lastName));


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
