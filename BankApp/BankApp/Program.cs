using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // first create an account so that we will going to create a instance of account class
            var myFirstAccount = new Account();
            myFirstAccount.AccountNumber = 1234;
            myFirstAccount.AccountName = "My checking";
            myFirstAccount.AccountType = "Checking";
            myFirstAccount.EmailAdress = "test@test.com";
            myFirstAccount.Deposit(123456);

            var mySecondAcount = new Account();
            mySecondAcount.AccountNumber = 45678;
            mySecondAcount.AccountName = "My savings";

        }
    }
}
