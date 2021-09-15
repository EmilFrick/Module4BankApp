using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Model4BankProject.AccountClasses
{
    public class AccountRepository
    {
        public AccountRepository()
        {
            UserAccountSearch();
        }

        public void UserAccountSearch()
        {
            User user1 = new User();
            List<User> userDetails = user1.GetUsers();

            int firstAccount = userDetails.ElementAt(0).UserAccounts[0].AccountNumber.AccNumber;  //dela upp i metod och gör detta mer Dry
            int secondAccount = userDetails.ElementAt(0).UserAccounts[1].AccountNumber.AccNumber;
            

            string currentPath = Directory.GetCurrentDirectory();
            bool directoryExist = Directory.Exists($@"{currentPath}\Users\{userDetails.ElementAt(0).UserName}");
            if (!directoryExist)
            {

                Directory.CreateDirectory($@"{currentPath}\Users\{userDetails.ElementAt(0).UserName}\{firstAccount}");
                Directory.CreateDirectory($@"{currentPath}\Users\{userDetails.ElementAt(0).UserName}\{secondAccount}");

            }
        }

    }

    // Current>MappMedAnvändare - om användare inte finns, skapa mapp för användaren.
    // 

}
