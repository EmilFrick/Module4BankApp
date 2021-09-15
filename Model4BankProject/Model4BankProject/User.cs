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
        List<User> users = new List<User>();


        public User()
        {
            GenerateUsers();
        }

        public User(string userName, Account[] userAccounts)
        {
            UserName = userName;
            UserAccounts = userAccounts;
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public void GenerateUsers()
        {
            string user1Name = "User1";
            AccountNumber user1Savings = new AccountNumber(9999, 1000001);
            AccountNumber user1Personal = new AccountNumber(9999, 1000002);
            SavingsAccount user1SavingsAccount = new SavingsAccount(user1Savings, 0);
            PersonalAccount user1PersonalAccount = new PersonalAccount(user1Personal, 0);
            Account[] user1Accounts = new Account[] { user1SavingsAccount, user1PersonalAccount };

            User user1 = new User(user1Name, user1Accounts);
            users.Add(user1);
        }
    }
}
