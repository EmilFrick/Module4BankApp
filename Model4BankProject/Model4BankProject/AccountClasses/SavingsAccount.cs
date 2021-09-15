using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model4BankProject
{
    public sealed class SavingsAccount : Account
    {
        public SavingsAccount(AccountClasses.AccountNumber accountNumber, double balance)
            : base(accountNumber, balance)
        {

        }

        public override double CalculateInterest()
        {
            throw new NotImplementedException();
        }

        public override void Deposit()
        {
            //create a new transaction
            //save the transaction to the accountfile
        }

        public override void ShowTransactionHistory()
        {
            //read the transacationfile for given account number
            //populate the listbox with transactions
        }

        public override void Withdraw()
        {

            //Read the account file
            //implement a check that a withdrawal cannot be negative
            //implement a check that maximum withdrawals are not > 5 via WithdrawalMadeYearly()
            //If both of the 2 conditions are met, procceed with the withdrawal
            //Create a new transaction
            //file the transaction in the account file
        }

        public int WithdrawalsMadeYearly()
        {
            int returnsAmountOfTimes = 0;
            return returnsAmountOfTimes;
        }
    }
}
