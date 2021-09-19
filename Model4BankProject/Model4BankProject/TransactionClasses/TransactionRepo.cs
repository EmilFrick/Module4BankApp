using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model4BankProject.TransactionClasses
{
    public class TransactionRepo
    {

        List<Transaction> listOfTransactions = new List<Transaction>();

        public TransactionRepo()
        {
        }


        

        public void AddTransactionToUserAccount(Transaction transaction)
        {
            string pathway = GeneratePathway(transaction);
            string jsonString = JsonConvert.SerializeObject(transaction);
            File.AppendAllText(pathway, jsonString + "\n");
        }

        public string GeneratePathway(Transaction transaction)
        {
            string userAccount = transaction.AccountInformation.AccountNumber.AccNumber.ToString();
            string userName = User.GetCheatSheet(transaction.AccountInformation.AccountNumber.AccNumber);
            return $@"{userName}\{userAccount}\{userAccount}.json";
        }

        public List<Transaction> GenerateTransactionList(User user, int accountNumber)
        {
            string pathway = GeneratePathway(user, accountNumber);
            if (File.Exists(pathway))                                   //bygg ut på denna och applicera denna på samtliga readers och writers.
            {
                StreamReader reader = new StreamReader(pathway);

                string jsonString = "";
                using (reader)
                {
                    while ((jsonString = reader.ReadLine()) != null)
                    {
                        Transaction jsonTransaction = JsonConvert.DeserializeObject<Transaction>(jsonString);
                        listOfTransactions.Add(jsonTransaction);
                    }
                }
            }
            return listOfTransactions;
        }

        public string GeneratePathway(User user, int accountNumber)
        {
            string userAccount = accountNumber.ToString();
            string userName = user.UserName;
            return $@"{userName}\{userAccount}\{userAccount}.json";
        }
    }
}
