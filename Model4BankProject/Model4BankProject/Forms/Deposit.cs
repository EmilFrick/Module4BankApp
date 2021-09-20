using Model4BankProject.AccountClasses;
using Model4BankProject.TransactionClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model4BankProject.Forms
{
    public partial class Deposit : Form
    {
        public Account _activeAccount { get; set; }
        
        public User _user { get; set; }

        public TransactionRepo _openRepo;



        public Deposit(Account account, TransactionRepo openRepo)
        {
            InitializeComponent();
            
            _user = _user;
            _openRepo = openRepo;
            _activeAccount = account;
        }

        private void btnCompleteDeposit_Click(object sender, EventArgs e)
        {
            if (_activeAccount is SavingsAccount)
{
                SavingsAccount savingsAccount = new SavingsAccount(_user,_activeAccount, _activeAccount.AccountNumber, _openRepo);
                savingsAccount.Deposit(double.Parse(txtAmount.Text));

            }
            
            
            else if (_activeAccount is PersonalAccount)
            {

            }
        }
    }
}
