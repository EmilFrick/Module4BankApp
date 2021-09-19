using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model4BankProject.AccountClasses
{
    public class AccountNumber
    {
        public int ClearingNumber { get; set; }
        public int AccNumber { get; set; }

        

        public AccountNumber(int clearingNumber, int accNumber)
        {
            ClearingNumber = clearingNumber;
            AccNumber = accNumber;
        }


        //An accountnumber should have 2 components. First the ClearingNumber. At this bank they only have one clearingnumber that they provide their users
        //which will allwlays be 9999. Set this in the constructor

    }
}
