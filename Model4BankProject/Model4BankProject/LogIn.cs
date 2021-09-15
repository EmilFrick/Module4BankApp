using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model4BankProject.AccountClasses;

namespace Model4BankProject
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogInUser_Click(object sender, EventArgs e)
        {

            new AccountRepository();

        }
    }
}
