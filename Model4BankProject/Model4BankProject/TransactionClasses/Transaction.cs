using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model4BankProject.TransactionClasses
{
    class Transaction
    {
        public Account AccountInformation { get; set; } //Accountnumber and accountbalance
        
        public DateTime TransactionDate { get; set; }

        public double Amount { get; set; }

        private int myAge;

        public int MyProperty
        {
            get { return myAge; }
            set { myAge = value; }
        }

    }
}
