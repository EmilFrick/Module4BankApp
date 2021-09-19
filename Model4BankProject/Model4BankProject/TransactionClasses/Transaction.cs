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
        public Account AccountInformation { get; set; }

        public AccountNumber AccountAntagonist { get; set; }

        public DateTime TransactionDate { get; set; }

        public double Amount { get; set; }

        public Transaction()
        {

        }

        public Transaction(Account accountInformation, AccountNumber accountAntagonist, DateTime transactionDate, double amount)
        {
            AccountInformation = accountInformation;
            AccountAntagonist = accountAntagonist;
            TransactionDate = transactionDate;
            Amount = amount;
        }

        public Transaction CreateTransactionDepositWithdraw(Account _useraccount, double amount)
        {
            Transaction transaction = new Transaction(_useraccount, new AccountNumber(0, 0), DateTime.Now, amount);
            return transaction;
        }

        public Transaction CreateCustomTransaction(Account _useraccount, AccountNumber receiverAccount, double amount)
        {
            Transaction transaction = new Transaction(_useraccount, receiverAccount, DateTime.Now, amount);
            return transaction;
        }
    }
}
