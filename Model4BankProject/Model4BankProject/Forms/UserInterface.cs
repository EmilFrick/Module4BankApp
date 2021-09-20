using Model4BankProject.AccountClasses;
using Model4BankProject.Forms;
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

namespace Model4BankProject
{
    public partial class UserInterface : Form
    {
        private User _user { get; set; }
        private Account _activeAccount { get; set; }
        private double _accountBalance { get; set; }
        private TransactionRepo _openRepo { get; set; }



        public UserInterface(User user)
        {
            InitializeComponent();
            _user = user;
            _openRepo = new TransactionRepo();
            _openRepo.IsPathwayAvailable(_user, _user.UserAccounts.ElementAt(0).AccountNumber.AccNumber);
            _openRepo.IsPathwayAvailable(_user, _user.UserAccounts.ElementAt(1).AccountNumber.AccNumber);
            SetActiveAccount(0);
            SetlstBoxAndBalance();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit openDeposit = new Deposit(_activeAccount, _openRepo);
            openDeposit.Show();
        }

        private void PopulateListWithTransactions(List<Transaction> transactionList)
        {
            transactionList = _openRepo.GenerateTransactionList(_user, _activeAccount.AccountNumber.AccNumber);
            if (transactionList.Count == 0)
            {
                lstTransactions.Items.Add("No data available");
            }
            else
            {
                foreach (var t in transactionList)
                {
                    lstTransactions.Items.Add(t);
                }
            }
        }

        private void CheckChangedEvent(object sender, EventArgs e)
        {
            if (rdbSavings.Checked)
            {
                SetActiveAccount(0);
                SetlstBoxAndBalance();
            }
            else if (rdbPersonal.Checked)
            {
                SetActiveAccount(1);
                SetlstBoxAndBalance();
            }
        }


        private void SetActiveAccount(int a)
        {
            AccountNumber accountNumber = new AccountNumber(_user.UserAccounts.ElementAt(a).AccountNumber.ClearingNumber, _user.UserAccounts.ElementAt(a).AccountNumber.AccNumber);
            _activeAccount = new SavingsAccount(accountNumber);
        }
        private void SetlstBoxAndBalance()
        {
            lstTransactions.Items.Clear();
            List<Transaction> accountRecords = _openRepo.GenerateTransactionList(_user, _activeAccount.AccountNumber.AccNumber);
            PopulateListWithTransactions(accountRecords);
            _accountBalance = _openRepo.GetBalance(accountRecords);
            lblSum.Text = _accountBalance.ToString();
        }
    
    }
}
