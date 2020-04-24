using System;
namespace BankApp
{
     static class Bank
    {  /// <summary>
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
            return account;
        }

    }
}
