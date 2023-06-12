using System;
using System.Windows.Forms;
using DataAdministration;

namespace LoginForm
{
    public partial class Login : Form
    {
        userLogin user;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtWelcome;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
