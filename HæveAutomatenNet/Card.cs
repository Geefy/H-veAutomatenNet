using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveAutomatenNet
{
    public class Card
    {
        public int Pin { get; set; }
        public Account Account { get; set; }
        public string CardNumber { get; set; }
        public string CardOwnerName { get; set; }

        public Card(int pin, string cardOwnerName, Account account)
        {
            this.Pin = pin;
            this.CardNumber = GenerateCardNumber();
            this.CardOwnerName = cardOwnerName;
            this.Account = account;
        }
        //Calls the connected accounts withdraw method
        public double Withdraw(double amount, int pin)
        {
            if (pin == this.Pin)
            {
                return Account.Withdraw(amount);
            }
            throw new Exception("Wrong Pin");

        }
        //Calls the connected accounts deposit method
        public void Deposit(double amount)
        {
            this.Account.Deposit(amount);
        }

        //Generates a 16 digit string to simulate a card number on a card
        private string GenerateCardNumber()
        {
            Random rnd = new Random();
            string builder = "";
            for (int i = 0; i < 16; i++)
            {
                builder += rnd.Next(0, 9);
            }
            return builder;
        }
    }
}
