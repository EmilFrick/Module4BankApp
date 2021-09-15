using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model4BankProject
{
    class Transaction
    {
        public Account AccountInformation { get; set; } //Accountnumber and accountbalance
        
        public DateTime TransactionDate { get; set; }

        public double Amount { get; set; }
    }
}
