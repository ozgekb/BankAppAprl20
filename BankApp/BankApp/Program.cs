using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // first create an account so that we will going to create a instance of account class
            var myFirstAccount = new Account();
            //myFirstAccount.AccountNumber = 1234; will be generated automaticly random number not a good idea because we should check that same number wouldnt used
            myFirstAccount.AccountName = "My checking";
            myFirstAccount.AccountType = "Checking";
            myFirstAccount.EmailAdress = "test@test.com";
            myFirstAccount.Deposit(123456);
            //print out and see the changes
            // + concanitation process THIS IS not a good way to printout use string formating instead of it.
            // Console.WriteLine(myFirstAccount.AccountNumber + " " + myFirstAccount.EmailAdress + " " + myFirstAccount.AccountName);
            Console.WriteLine($"AN:{myFirstAccount.AccountNumber}, Name :{ myFirstAccount.AccountName}, Email:{myFirstAccount.EmailAdress}, AccountType : {myFirstAccount.AccountType}, Balance: {myFirstAccount.Balance}, CD:{myFirstAccount.CreatedDate}");
           
            var mySecondAccount = new Account();
            //mySecondAccount.AccountNumber = 45678;
            mySecondAccount.AccountName = "My savings";
            Console.WriteLine($"AN:{mySecondAccount.AccountNumber}, Name :{mySecondAccount.AccountName}, Email:{mySecondAccount.EmailAdress}, AccountType : {mySecondAccount.AccountType}, Balance: {mySecondAccount.Balance}, CD:{mySecondAccount.CreatedDate}");

        }
    }
}
