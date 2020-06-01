using System;
using System.Collections.Generic;
using System.Linq;

namespace BankApp
{
     static class Bank
    {
        private static BankContext db = new BankContext();//creating new connection to database
        //private static List<Transaction> transactions = new List<Transaction>(); //temp storage we dont need this temp storage anymore because we created database
       // private static List<Account> accounts = new List<Account>();
    /// <summary>
    /// create an account with the bank
    /// </summary>
    /// <param name="accountName">name of the account</param>
    /// <param name="emailAddress"></param>
    /// <param name="accountType"></param>
    /// <returns></returns>
        public static Account CreateAccount(string accountName,string emailAddress, TypeOfAccounts accountType)// return type is Account because we will return full account information
        {
            var account = new Account
            {
                AccountName = accountName,
                EmailAdress = emailAddress,
                AccountType = accountType
            };
            // accounts.Add(account); no need this column because we will add to database in the below
            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }

        public static IEnumerable<Account> GetAccounts()
        {
            return db.Accounts;
        }

        public static void Deposit(int accountNumber,decimal amount)
        {
            //locate the account


            // foreach (var account in accounts)
            // {
            //   if (account.AccountNumber == accountNumber)
            // {
            //  account.Deposit(amount);
            //  break;
            // }
            // }


            //LINQ same with foreach 
            //accounts.Where(account=>account.AccountNumber == accountNumber); // might bring more than one same number(account number)

            var account = db.Accounts.SingleOrDefault(account => account.AccountNumber == accountNumber);
            //Deposit on the account
            if (account == null)
                return;

            account.Deposit(amount);
            //add a transactios
            //create instance of transaction needs to store in a list
            var transaction = new Transaction
                {
                    TransactionDate = DateTime.Now,
                    Description = "Branch deposit",
                    Amount = amount,
                    TransactionType = TypeOfTransaction.Credit,
                    AccountNumber = accountNumber

                };
            db.Transactions.Add(transaction);
            db.SaveChanges();
            Console.WriteLine("Deposit successfully completed!");

        }   
    }
}
