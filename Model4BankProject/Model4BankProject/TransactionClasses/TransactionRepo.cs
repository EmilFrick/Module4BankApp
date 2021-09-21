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
            string userAccount = transaction.UserAccountNumber.AccNumber.ToString();
            string userName = User.GetCheatSheet(transaction.UserAccountNumber.AccNumber);
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
            bool fileExist = File.Exists($@"{pathway}\{accountNumber}.txt");

            if (fileExist == false)
            {
                FileStream myfile = File.Create($@"{pathway}\{accountNumber}.txt");
                myfile.Close();
            }
        }
        #endregion


        public void AddTransactionToUserAccount(Transaction transaction)
        {
            string pathway = GeneratePathway(transaction);
            string txtString = $"{transaction.PlaceHolder.AccountNumber.AccNumber}," +
                               $"{transaction.TransactionDate}," +
                               $"{transaction.AccountAntagonist.AccNumber}," +
                               $"{transaction.Amount}," +
                               $"{transaction.PlaceHolder.Balance}" +
                               $"{transaction.PlaceHolder.}";
            File.AppendAllText($@"{pathway}\{transaction.UserAccountNumber.AccNumber}.txt", txtString + "\n");
        }

        public List<Transaction> GenerateTransactionList(User user, int accountNumber)
        {
            string pathway = GeneratePathway(user, accountNumber);
            return listOfTransactions = GetDataFromJsonFile(pathway, accountNumber);
        }

        public List<Transaction> GetDataFromJsonFile(string pathway, int accountNumber)
        {
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
            double balance = 0;
            if (listOfTransactions.Count != 0)
            {
                int lastElement = (listOfTransactions.Count() - 1);
                Transaction transaction = listOfTransactions.ElementAt(lastElement);
                if (transaction.PlaceHolder is SavingsAccount)
                {
                    balance = transaction.SavingsAccountInformation.Balance;
                }
                else if (transaction.PlaceHolder is PersonalAccount)
                {
                    balance = transaction.PersonalAccountInformation.Balance;
                }
                return balance;

            }
            return 0;

        }

    }
}
