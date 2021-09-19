using Model4BankProject.AccountClasses;
using Model4BankProject.TransactionClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model4BankProject.Forms
{
    public partial class Deposit : Form
    {
        public Account _activeAccount { get; set; }
        
        public User _user { get; set; }



        public Deposit(User _user, int accountnumber)
        {
            InitializeComponent();
            
            this._user = _user;
            Set_acticeAccount(accountnumber);


        }

        private void Set_acticeAccount(int accountnumber)
        {

            foreach (var a in _user.UserAccounts)
            {
                if (accountnumber == a.AccountNumber.AccNumber)
                {
                    if (a is SavingsAccount)
                    {
                        SavingsAccount passThisAccount = new SavingsAccount(new AccountNumber(9999, accountnumber));
                        _activeAccount = passThisAccount;
                    }
                    else
                    {
                        PersonalAccount passThisAccount = new PersonalAccount(new AccountNumber(9999, accountnumber));
                        _activeAccount = passThisAccount;
                    }
                }
            }
            
        }

        private void btnCompleteDeposit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAmount.Text, out double amount))
            {
            TransactionRepo openRepo = new TransactionRepo();
            Transaction createTransaction = new Transaction();
            createTransaction.CreateTransactionDepositWithdraw(_activeAccount,amount);
            openRepo.AddTransactionToUserAccount(createTransaction);
            }
        }
    }
}
