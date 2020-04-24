using System;
namespace BankApp
{
    enum TypeOfAccounts
    {
        Checking,
        Savings,
        CD,
        Loan
    }


    /// <summary>
    /// Summery of this class
    /// this class represent a bank account
    /// where you can deposit and withdraw
    /// </summary>
    class Account
    {
        //private int lastAccountNumber = 0; to generate account number its local its need to be global to accesible to from all instance
        private static int lastAccountNumber = 0;// we put static to make global 
        #region Properties
        /// <summary>
        /// this property
        /// Uniq account number for the account 
        /// </summary>
        public int AccountNumber { get; private set; }// deleted set to make property read only. then added again to make private 
        /// <summary>
        /// Email adress of the account holder
        /// </summary>
        public string EmailAdress { get; set; }
        public string AccountName { get; set; }
        public TypeOfAccounts AccountType { get; set; } // we change to string to type of account
        public decimal Balance { get; private set; } // put private to set so only this class can write to the balance customer can not chance balance but banker can change 
        public DateTime CreatedDate { get; private set; }
        #endregion

        #region Constructor
        /// <summary>
        /// constructor is the first peace of code that executed
        /// no return type and same name with class name 
        /// </summary>
        public Account()
        {
            //lastAccountNumber += 1;
            //lastAccountNumber++; 36 and 37 line yerine 39 . line only
            //AccountNumber = lastAccountNumber;
            //AccountNumber = lastAccountNumber++; if we do after incrementing the first account will be 0 because we assigned lastaccount number =0 from begining so that we use preincrementing
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.Now;

        }
        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">amount to deposit </param>
        public void Deposit(decimal amount)
        {
            // Balance = Balance + amount;
               Balance += amount;
        }
        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }
        #endregion
    }
}
