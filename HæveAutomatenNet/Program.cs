using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveAutomatenNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank danskeBank = new Bank();
            Customer customer = new Customer("Geefy");
            ATM atm = new ATM();
            
            //Creates an account for our customer
            danskeBank.CreateAccount(customer);
            //Gives the customer an account with the pincode 1234
            danskeBank.GiveCustomerCard(customer, 1234);

            //Simulates a deposit from an atm
            atm.Deposit(customer.Card, 5000);
            //Simulates a withdraw from an atm
            atm.Withdraw(customer.Card, 1000, 1234);
        }
    }
}
