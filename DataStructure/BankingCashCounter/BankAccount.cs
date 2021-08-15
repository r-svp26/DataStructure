using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.BankingCashCounter
{
    class BankAccount
    {
        public string accHolderName;
        public int amount;
        /// <summary>
        /// variable initialization
        /// </summary>
        /// <param name="accHolderName"></param>
        /// <param name="amount"></param>
        public BankAccount(string accHolderName, int amount)
        {
            this.accHolderName = accHolderName;
            this.amount = amount;
        }
    }
}
