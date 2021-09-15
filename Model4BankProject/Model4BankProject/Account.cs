using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model4BankProject
{
    public abstract class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }


        abstract public void Withdraw();
        abstract public void Deposit();
        abstract public void ShowTransactionHistory();
        abstract public double CalculateInterest();
    }
}
