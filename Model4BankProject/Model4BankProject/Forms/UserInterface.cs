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
        private int _activeAccountNumber { get; set; }
        

        public UserInterface(User user)
        {
            InitializeComponent();
            _user = user;
            _activeAccountNumber = _user.UserAccounts.ElementAt(0).AccountNumber.AccNumber;
            PopulateListWithTransactions();

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit openDeposit = new Deposit(_user, _activeAccountNumber);
            openDeposit.Show();
        }

        private void PopulateListWithTransactions()
        {
            List<Transaction> transactionList = new List<Transaction>();
            TransactionRepo openRepo = new TransactionRepo();
            transactionList = openRepo.GenerateTransactionList(_user, _activeAccountNumber);
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
                lstTransactions.Items.Clear();
                _activeAccountNumber = _user.UserAccounts.ElementAt(0).AccountNumber.AccNumber;
                PopulateListWithTransactions();
            }
            else if (rdbPersonal.Checked)
            {
                lstTransactions.Items.Clear();
                _activeAccountNumber = _user.UserAccounts.ElementAt(1).AccountNumber.AccNumber;
                PopulateListWithTransactions();
            }
        }
    }
}
