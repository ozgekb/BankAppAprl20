using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {


            //myFirstAccount.AccountNumber = 1234; will be generated automaticly random number not a good idea because we should check that same number wouldnt used

            //   myFirstAccount.Deposit(123456);




            // var myFirstAccount = new Account //object initilization 
            //{
            //     AccountName = "My checking",
            // AccountType = "Checking",                      //from 18-24 we delete because we defined bank class and bank class does this action 
            //    AccountType = TypeOfAccounts.Checking,
            //    EmailAdress = "test@test.com"
            //};

            var myFirstAccount = Bank.CreateAccount("My checking", "test@test.com", TypeOfAccounts.Checking);



            //print out and see the changes
            // + concanitation process THIS IS not a good way to printout use string formating instead of it.
            // Console.WriteLine(myFirstAccount.AccountNumber + " " + myFirstAccount.EmailAdress + " " + myFirstAccount.AccountName);
            Console.WriteLine($"AN:{myFirstAccount.AccountNumber}, Name :{ myFirstAccount.AccountName}, Email:{myFirstAccount.EmailAdress}, AccountType : {myFirstAccount.AccountType}, Balance: {myFirstAccount.Balance:C}, CD:{myFirstAccount.CreatedDate}");



            // after created bank class we delete 37 to 41 
            // var mySecondAccount = new Account();// first create an account so that we will going to create a instance of account class
            //mySecondAccount.AccountNumber = 45678;
            //mySecondAccount.AccountName = "My savings";
            var mySecondAccount = Bank.CreateAccount("My saving", "test@test.com", TypeOfAccounts.Savings);

            Console.WriteLine($"AN:{mySecondAccount.AccountNumber}, Name :{mySecondAccount.AccountName}, Email:{mySecondAccount.EmailAdress}, AccountType : {mySecondAccount.AccountType}, Balance: {mySecondAccount.Balance:C}, CD:{mySecondAccount.CreatedDate}");





            //var myThirdAccount = new Account();
            var myThirdAccount = Bank.CreateAccount("My scd", "test@test.com", TypeOfAccounts.CD);

            Console.WriteLine($"AN:{myThirdAccount.AccountNumber}, Name :{myThirdAccount.AccountName}, Email:{myThirdAccount.EmailAdress}, AccountType : {myThirdAccount.AccountType}, Balance: {myThirdAccount.Balance:C}, CD:{myThirdAccount.CreatedDate}");
        }
    }
}
