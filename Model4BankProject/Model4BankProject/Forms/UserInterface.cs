using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model4BankProject
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //Ett fönster för Deposit
            //Skicka värdet från fönster 2? 
            //Knappen bekräfta insättning ska göra en Transaction och spara ned den på Personkontot via StreamWriter till Jsonfilen.
            //If Statement implementeras för WithDraw och NewTransaction
            //Skapa en listbox som hämter värdet till vilket konto insättningen görs till. "från kontot blir alltid 00"
            //Deposit och Withdraw ska ha accountnumber 00

            //Skapa insättning

        }
    }
}
