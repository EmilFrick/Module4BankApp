using Model4BankProject.AccountClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model4BankProject.TransactionClasses
{
    public class Transaction
    {
        #region Properties
        public Account PlaceHolder { get; set; }
        public SavingsAccount SavingsAccountInformation { get; set; }
        public PersonalAccount PersonalAccountInformation { get; set; }
        public AccountNumber UserAccountNumber { get; set; }
        public AccountNumber AccountAntagonist { get; set; }
        public DateTime TransactionDate { get; set; }
        public double Amount { get; set; }
        #endregion

        #region Constructors
        public Transaction()
        {

        }

        public Transaction(SavingsAccount accountInformation, AccountNumber accountAntagonist, DateTime transactionDate, double amount)
        {
            SavingsAccountInformation = accountInformation;
            PlaceHolder = accountInformation;
            UserAccountNumber = accountInformation.AccountNumber;
            AccountAntagonist = accountAntagonist;
            TransactionDate = transactionDate;
            Amount = amount;
        }

        public Transaction(PersonalAccount accountInformation, AccountNumber accountAntagonist, DateTime transactionDate, double amount)
        {
            PersonalAccountInformation = accountInformation;
            PlaceHolder = accountInformation;
            UserAccountNumber = accountInformation.AccountNumber;
            AccountAntagonist = accountAntagonist;
            TransactionDate = transactionDate;
            Amount = amount;
        }
        #endregion



        public int GetAccountNumber()
        {
            if (PlaceHolder is SavingsAccount)
            {
                return SavingsAccountInformation.AccountNumber.AccNumber;
            }
            else if (PlaceHolder is PersonalAccount)
            {
                return PersonalAccountInformation.AccountNumber.AccNumber;
            }
            return 0;
        }

        public Transaction CreateTransactionDepositWithdraw(Account _useraccount, double amount)
        {
            Transaction transaction = new Transaction();
            if (_useraccount is SavingsAccount sAccount)
            {
                transaction = new Transaction(sAccount, new AccountNumber(0, 0), DateTime.Now, amount);
                return transaction;
            }

            else if (_useraccount is PersonalAccount pAccount)
            {
                transaction = new Transaction(pAccount, new AccountNumber(0, 0), DateTime.Now, amount);
                return transaction;
            }
            return transaction;
        }

        public Transaction CreateCustomTransaction(Account _useraccount, AccountNumber receiverAccount, double amount)
        {
            Transaction transaction = new Transaction();
            if (_useraccount is SavingsAccount sAccount)
            {
                transaction = new Transaction(sAccount, receiverAccount, DateTime.Now, amount);
            }
            else if (_useraccount is PersonalAccount pAccount)
            {
                transaction = new Transaction(pAccount, receiverAccount, DateTime.Now, amount);
            }
            return transaction;
        }
    }
}
