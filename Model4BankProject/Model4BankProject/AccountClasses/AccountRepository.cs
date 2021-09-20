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
            
        }

        public void CreateUserPathway(User user)
        {
            
            int firstAccount = user.UserAccounts[0].AccountNumber.AccNumber;  //dela upp i metod och gör detta mer Dry
            int secondAccount = user.UserAccounts[1].AccountNumber.AccNumber;
            

            string currentPath = Directory.GetCurrentDirectory();
            bool directoryExist = Directory.Exists($@"{currentPath}\Users\{user.UserName}");
            if (!directoryExist)
            {
                Directory.CreateDirectory($@"{currentPath}\Users\{user.UserName}\{firstAccount}");
                Directory.CreateDirectory($@"{currentPath}\Users\{user.UserName}\{secondAccount}");
            }
        }


    }

    // Current>MappMedAnvändare - om användare inte finns, skapa mapp för användaren.
    // 

}
