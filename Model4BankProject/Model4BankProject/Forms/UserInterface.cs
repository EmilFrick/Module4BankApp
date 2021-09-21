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
        private SavingsAccount _activeSavingsAccount { get; set; }
        private PersonalAccount _activePersonalAccount { get; set; }
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


        #region Eventbased Methods
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

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (_activeAccount is SavingsAccount)
            {
                Deposit openDeposit = new Deposit(_activeSavingsAccount, _accountBalance, _openRepo);
                openDeposit.Show();
            }
            else if (_activePersonalAccount is PersonalAccount)
            {
                Deposit openDeposit = new Deposit(_activePersonalAccount, _accountBalance, _openRepo);
                openDeposit.Show();
            }
        }



        #endregion

        #region Processes for UserInterFace
        private void PopulateListWithTransactions(List<Transaction> transactionList)
        {   
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

        private void SetActiveAccount(int a)
        {
            AccountNumber accountNumber = new AccountNumber(_user.UserAccounts.ElementAt(a).AccountNumber.ClearingNumber, _user.UserAccounts.ElementAt(a).AccountNumber.AccNumber);
            if (accountNumber.AccNumber % 2 == 1)
            {
                _activeAccount = new SavingsAccount(accountNumber);
                _activeSavingsAccount = new SavingsAccount(accountNumber);
            }
            else if (accountNumber.AccNumber % 2 == 0)
            {
                _activeAccount = new PersonalAccount(accountNumber);
                _activePersonalAccount = new PersonalAccount(accountNumber);
            }
        }
        private void SetlstBoxAndBalance()
        {
            lstTransactions.Items.Clear();
            List<Transaction> accountRecords = _openRepo.GenerateTransactionList(_user, _activeAccount.AccountNumber.AccNumber);
            PopulateListWithTransactions(accountRecords);
            _accountBalance = _openRepo.GetBalance(accountRecords);
            lblSum.Text = _accountBalance.ToString();
        }

        #endregion
    }
}
