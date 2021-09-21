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
        public SavingsAccount _activeSavingsAccount { get; set; }
        public PersonalAccount _activePersonalAccount { get; set; }

    public User _user { get; set; }

        public double _activeBalance { get; set; }

        public TransactionRepo _openRepo;


        //SavingsAccount Ctor
        public Deposit(SavingsAccount account, double balance,TransactionRepo openRepo)
        {
            InitializeComponent();
            _user = _user;
            _activeSavingsAccount = account;
            _activeAccount = account;
            _activeBalance = balance;
            _openRepo = openRepo;
        }

        //PersonalAccount Ctor
        public Deposit(PersonalAccount account, double balance, TransactionRepo openRepo)
        {
            InitializeComponent();
            _user = _user;
            _activePersonalAccount = account;
            _activeAccount = account;
            _activeBalance = balance;
            _openRepo = openRepo;
        }

        private void btnCompleteDeposit_Click(object sender, EventArgs e)
        {
            if (_activeAccount is SavingsAccount sAccount)
{
                SavingsAccount savingsAccount = new SavingsAccount(_user,sAccount, sAccount.AccountNumber, _openRepo);
                savingsAccount.Deposit(double.Parse(txtAmount.Text));
            }
            
            
            else if (_activeAccount is PersonalAccount)
            {

            }
        }
    }
}
