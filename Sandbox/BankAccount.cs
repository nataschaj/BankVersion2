using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class BankAccount
    {
        private double balance;

        public BankAccount()
        {
            balance = 0;
        }

        public void Deposit(double amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(double amount)
        {
            if ((amount >= 0) && (amount <= balance))
            {
                balance = balance - amount;
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
