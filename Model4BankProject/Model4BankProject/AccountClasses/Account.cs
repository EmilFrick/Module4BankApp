using Model4BankProject.AccountClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model4BankProject
{
    public abstract class Account
    {
        public AccountNumber AccountNumber { get; set; }
        public double Balance { get; set; }

        protected Account(AccountNumber accountNumber)
        {
            AccountNumber = accountNumber;
        }

        protected Account(AccountNumber accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance; //Create a balance calculator from file
        }




        //In this application we will have a simple button to start up the application and will logon to a users Account.
        //At the logging in event
        //The accountnumbers will be assigned to a user.
        //The application will use this users details as reference (accounts)
        //This should simulate the same process as for any other user, fetching and assigning values accordingly. 


        abstract public void Withdraw();
        abstract public void Deposit();
        abstract public void ShowTransactionHistory();
        abstract public double CalculateInterest();
    }
}
