using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model4BankProject
{
    public sealed class PersonalAccount : Account
    {

        public PersonalAccount(AccountClasses.AccountNumber accountNumber, double balance)
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
            //Conditional: Implement that withdrawals can be madee up to a defecit of 2000 SEK. 
            //If OK then procceed with the withdrawal
            //Create a new transaction
            //file the transaction in the account file
        }
    }
}
