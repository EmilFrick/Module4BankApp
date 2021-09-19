using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model4BankProject.AccountClasses;

namespace Model4BankProject
{
    public class User
    {
        public string UserName { get; set; }
        public Account[] UserAccounts { get; set; }

        public User(int getUserByNumber)
        {
            GenerateUser(getUserByNumber);
        }


        public static string GetCheatSheet(int account)
        {
            if (account == 1000001 || account == 1000002)
            {
                return "User1";
            }
            else
            {
                return "User2";
            }
        }



        public void GenerateUser(int getUserByNumber)
        {
            if (getUserByNumber == 1)
            {
                UserName = "User1";
                AccountNumber user1Savings = new AccountNumber(9999, 1000001);
                AccountNumber user1Personal = new AccountNumber(9999, 1000002);
                SavingsAccount user1SavingsAccount = new SavingsAccount(user1Savings, 0);
                PersonalAccount user1PersonalAccount = new PersonalAccount(user1Personal, 0);
                UserAccounts = new Account[] { user1SavingsAccount, user1PersonalAccount };
            }

            else if (getUserByNumber == 2)
            {
                UserName = "User2";
                AccountNumber user1Savings = new AccountNumber(9999, 1000003);
                AccountNumber user1Personal = new AccountNumber(9999, 1000004);
                SavingsAccount user1SavingsAccount = new SavingsAccount(user1Savings, 0);
                PersonalAccount user1PersonalAccount = new PersonalAccount(user1Personal, 0);
                UserAccounts = new Account[] { user1SavingsAccount, user1PersonalAccount };
            }
        }

    }
}
