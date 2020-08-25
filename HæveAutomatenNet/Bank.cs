using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveAutomatenNet
{
    public class Bank
    {
        public Dictionary<Customer, Account> CustomerAccounts = new Dictionary<Customer, Account>();
        
        //Returns a new card object made from parameters
        private Card CreateCard(int pin, string cardOwnerName, Account account)
        {
            return new Card(pin, cardOwnerName, account);
        }

        //Adds a card to a customer
        public void GiveCustomerCard(Customer customer, int pin)
        {
            Account acc = FindAccountByCustomer(customer);
            customer.Card = CreateCard(pin,customer.Name, acc);
        }

        //Adds a customer and an account to the CustomerAccounts dictionary
        public void CreateAccount(Customer customer)
        {
            Account acc = new Account();
            CustomerAccounts.Add(customer, acc);
        }

        //Loops throught the CustomerAccounts dictionary to find the account matching the customer
        private Account FindAccountByCustomer(Customer customer)
        {
            foreach (KeyValuePair<Customer,Account> customerAccounts in CustomerAccounts)
            {
                if (customerAccounts.Key == customer)
                {
                    return customerAccounts.Value;
                }
            }
            throw new Exception("Customer doesn't have an account");
        }
        
    }
}
