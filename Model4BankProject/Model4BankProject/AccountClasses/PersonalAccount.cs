using Model4BankProject.AccountClasses;
using Model4BankProject.TransactionClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model4BankProject
{
    public sealed class PersonalAccount : Account
    {

        public PersonalAccount(AccountNumber accountNumber, double balance)
        : base(accountNumber, balance)
        {

        }

        public PersonalAccount(AccountNumber accountNumber)
        : base(accountNumber)
        {

        }


        public override double CalculateInterest()
        {
            throw new NotImplementedException();
        }

        public override void Deposit(double depositAmount)
        {
            //save the transaction to the accountfile
        }

        public void Deposit(PersonalAccount account, double amount)
        {
            AccountNumber depositAccountNumber = new AccountNumber(0, 0);
            Transaction transaction = new Transaction(account, depositAccountNumber, DateTime.Now, amount);

            //save the transaction to the accountfile
        }

        public override void ShowTransactionHistory()
        {
            //read the transacationfile for given account number
            //populate the listbox with transactions

        }

        public override void Withdraw(double withdrawAmount)
        {
            //Read the account file
            //Conditional: Implement that withdrawals can be madee up to a defecit of 2000 SEK. 
            //If OK then procceed with the withdrawal
            //Create a new transaction
            //file the transaction in the account file
        }

        public override bool MinimumAmountCondition(double balance)
        {
            if (balance<2000)
            {
                return false;
            }
            return true;
        }
    }
}
