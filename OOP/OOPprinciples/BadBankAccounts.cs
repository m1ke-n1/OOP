using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class BadBankAccounts
    {
        private decimal balance;

        public decimal getBalance() => this.balance;

        public decimal Deposit(decimal sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentException("Deposit amount cannot be negative or 0");
            }
            else
            {
                this.balance = sum;
            }

            return this.balance; 
        }

        public decimal Withdraw(decimal amount)
        {
            if (this.balance < amount)
            {
                throw new ArgumentException("Not enought money on balance!");
            }
            else if (amount < 0)
            {
                throw new ArgumentException("Withdra amount must be positive!");
            }
            else
            {
                this.balance -= amount;           
            }
            
            return this.balance;
        }
        
    }
}
