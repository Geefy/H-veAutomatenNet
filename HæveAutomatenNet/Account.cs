using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveAutomatenNet
{
    public class Account
    {
        public double Amount { get; set; }

        //Withdraws amount from account Amount, throws exception if fails
        public double Withdraw(double amount)
        {
            if (CanWithdraw(amount))
            {
                this.Amount -= amount;
                return amount;
            }
            throw new Exception("Not enough money on account");
        }
        //Check if amount is larger than accounts current amount
        private bool CanWithdraw(double amount)
        {
            if (this.Amount >= amount)
            {
                return true;
            }
            return false;
        }

        //Deposits amount into account amount
        public void Deposit(double amount)
        {
            this.Amount += amount;
        }
    }
}
