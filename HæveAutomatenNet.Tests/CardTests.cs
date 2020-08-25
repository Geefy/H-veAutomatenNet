using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using HæveAutomatenNet;

namespace HæveAutomatenNet.Tests
{
    public class CardTests
    {
        [Theory]
        [InlineData(1234)]
        public void CardWithdraw_ShouldThrowException(int pin)
        {
            //Arrange
            Account acc = new Account();
            Card testCard = new Card(4321, "", acc);
            //Act
            //Assert
            Assert.Throws<Exception>(() => testCard.Withdraw(100, pin));
        }

        [Fact]
        public void CardWithdraw_ShouldReturnAmount()
        {
            //Arrange
            double expected = 100;
            Account acc = new Account();
            acc.Amount = 100;
            Card testCard = new Card(4321, "", acc);
            //Act
            double actual = testCard.Withdraw(100, 4321);
            //Assert 
            Assert.Equal(expected, actual);
        }
      
    }
}
