using Model4BankProject.AccountClasses;
using Model4BankProject.TransactionClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Model4BankProject
{
    public sealed class SavingsAccount : Account
    {

        #region Props
        public bool WithdrawValue { get; set; }
        private double _accountBalance { get; set; }
        #endregion


        #region fields
        private Account _userAccount { get; set; }
        private User _user { get; set; }
        private TransactionRepo _openRepo { get; set; }
        #endregion


        #region Constructors
        //Constructor when there is no instanced user
        public SavingsAccount(AccountNumber accountNumber)      
            : base(accountNumber)
        {
        }

        //Constructor when accessing the functionalities Withdraw, Deposit and Custom Transaction.
        public SavingsAccount(User user, Account account, AccountNumber accountNumber, TransactionRepo openRepo)     
            : base(accountNumber)                                                                   
        {
            _user = user;
            _openRepo = openRepo;
            _userAccount = account;
        }

        //Constructor for setting up a transaction.
        public SavingsAccount(User user, Account account, AccountNumber accountNumber, TransactionRepo openRepo, double balance, bool withdraw)
        : base(accountNumber, balance)
        {
            _user = user;
            _userAccount = account;
            //Get a list and get the balance for the last entry. This can be a thing that gets passed along from the beginning in the second constructor.
            _accountBalance = balance;
        }
        #endregion


        #region Main Functionality
        public override void Deposit(double depositAmount)
{
            Transaction transaction = new Transaction();
            _userAccount = new SavingsAccount(_user, _userAccount, _userAccount.AccountNumber, _openRepo, _accountBalance, false);
            transaction = transaction.CreateTransactionDepositWithdraw(_userAccount, depositAmount);
            _openRepo.AddTransactionToUserAccount(transaction);
        }

        public override void Withdraw(double withdrawAmount)        //Incomplete
        {

            if (MinimumAmountCondition(withdrawAmount) && ValidYearlyWithdrawals())
            {
                Transaction transaction = new Transaction();
                _userAccount = new SavingsAccount(_user, _userAccount, _userAccount.AccountNumber, _openRepo, _accountBalance, true);
                transaction = transaction.CreateTransactionDepositWithdraw(_userAccount, withdrawAmount);
                _openRepo.AddTransactionToUserAccount(transaction);
            }
        }

        public void CreateCustomTransaction()
        {

        }
        #endregion


        #region Misc Methods

        public override void ShowTransactionHistory()
        {
            //Already implemented in the Forms section. Move the functionality.
        }

        public override double CalculateInterest()
        {
            throw new NotImplementedException();
        }

        #endregion


        #region Condition Methods
        private bool ValidYearlyWithdrawals()          //Not fully developed.
        {
            int returnsAmountOfTimes = 0;
            List<Transaction> savingRecords = _openRepo.GenerateTransactionList(_user, _userAccount.AccountNumber.AccNumber);
            foreach (var t in savingRecords)
            {
                if (t.AccountInformation is SavingsAccount account)
                {
                    if (account.WithdrawValue)
                    {
                        returnsAmountOfTimes++;
                    }
                }
            }
            if (returnsAmountOfTimes<5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool MinimumAmountCondition(double balance)
        {
            if (balance < 0)
            {
                return false;
            }
            return true;
        }
        #endregion


    }
}
