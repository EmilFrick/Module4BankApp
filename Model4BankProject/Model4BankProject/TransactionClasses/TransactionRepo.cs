using Model4BankProject.AccountClasses;
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



        #region Pathway methods

        public string GeneratePathway(Transaction transaction)
        {
            string userAccount = transaction.AccountInformation.AccountNumber.AccNumber.ToString();
            string userName = User.GetCheatSheet(transaction.AccountInformation.AccountNumber.AccNumber);
            return $@"Users\{userName}\{userAccount}";
        }

        public string GeneratePathway(User user, int accountNumber)
        {
            string userAccount = accountNumber.ToString();
            string userName = user.UserName;
            return $@"Users\{userName}\{userAccount}";
        }

        internal void IsPathwayAvailable(User user, int accountNumber)
        {
            string pathway = GeneratePathway(user, accountNumber);
            if (!File.Exists(pathway))
            {
                FileStream myfile = File.Create($@"{pathway}\{accountNumber}.json");
                myfile.Close();
            }
        }
        #endregion


        public void AddTransactionToUserAccount(Transaction transaction) //Använd transaction med Account\balance
        {
            string pathway = GeneratePathway(transaction);
            string jsonString = JsonConvert.SerializeObject(transaction);
            File.AppendAllText(pathway, jsonString + "\n");
        }

        public List<Transaction> GenerateTransactionList(User user, int accountNumber)
        {
            string pathway = GeneratePathway(user, accountNumber);
            return listOfTransactions = GetDataFromJsonFile(pathway, accountNumber);
        }

        public List<Transaction> GetDataFromJsonFile(string pathway, int accountNumber)
        {
            listOfTransactions.Clear();
            StreamReader reader = new StreamReader($@"{pathway}\{accountNumber}.json");

            string jsonString = "";
            using (reader)
            {
                while ((jsonString = reader.ReadLine()) != null)
                {
                    Transaction jsonTransaction = JsonConvert.DeserializeObject<Transaction>(jsonString);
                    listOfTransactions.Add(jsonTransaction);
                }
            }
            return listOfTransactions;
        }
        public double GetBalance(List<Transaction> listOfTransactions)
        {
            double balance;
            if (listOfTransactions.Count!=0)
            {
                int lastElement = (listOfTransactions.Count() - 1);
                Transaction transaction = listOfTransactions.ElementAt(lastElement);
                balance = transaction.AccountInformation.Balance;
                return balance;
            }
            else
            {
                return 0;
            }
        }

    }
}
