using ObjectDefines;
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
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
        }

        public AdminUI(User user, Login login)
        {
            User = user;
            Login = login;
        }

        public User User { get; }
        public Login Login { get; }
    }
}
