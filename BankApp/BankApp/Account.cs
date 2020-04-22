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
        public int AccountNumber { get; set; }
        /// <summary>
        /// Email adress of the account holder
        /// </summary>
        public string EmailAdress { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedDate { get; set; }
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
