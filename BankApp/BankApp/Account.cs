using System;
namespace BankApp
{
    /// <summary>
    /// Summery of this class
    /// this class represent a bank account
    /// where you can deposit and withdraw
    /// </summary>
    class Account
    {
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
        public string AccountType { get; set; }
        public decimal Balance { get; private set; } // put private to set so only this class can write to the balance customer can not chance balance but banker can change 
        public DateTime CreatedDate { get; private set; }
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
