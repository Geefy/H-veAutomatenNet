using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using HæveAutomatenNet;

namespace HæveAutomatenNet.Tests
{
    public class BankTest
    {
        public Bank testBank = new Bank();
        [Fact]
        public void CreateAccount_CustomerShouldBeInDictionary()
        {
            //Arrange
            Customer gert = new Customer("Gert");
            //Act
            testBank.CreateAccount(gert);
            //Assert
            Assert.Contains(gert, testBank.CustomerAccounts.Keys);
        }
        [Fact]
        public void GiveCustomerCard_ShouldThrowException()
        {
            //Arrange
            Customer customer = new Customer("James");
            //Act
            //Assert
            Assert.Throws<Exception>(() => testBank.GiveCustomerCard(customer,1234));

        }
        [Theory]
        [InlineData(1234)]
        [InlineData(4312)]
        public void GiveCustomerCard_ShouldGiveCustomerNewCard(int pin)
        {
            //Arrange
            Customer customer = new Customer("yeet");
            int expected = pin;
            testBank.CreateAccount(customer);
            //Act
            testBank.GiveCustomerCard(customer, pin);
            //Assert
            Assert.Equal(expected, customer.Card.Pin);

        }
    }
}
