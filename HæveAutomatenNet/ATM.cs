using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveAutomatenNet
{
    class ATM
    {
        //Calls the cards withdraw method
        public double Withdraw(Card card, double amount, int pin)
        {
            return card.Withdraw(amount, pin);
        }
        //Calls the cards deposit method
        public void Deposit(Card card, double amount)
        {
            card.Deposit(amount);
        }
    }
}
