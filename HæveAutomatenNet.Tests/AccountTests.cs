using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HæveAutomatenNet;
using Xunit;

namespace HæveAutomatenNet.Tests
{
    public class AccountTest
    {
        [Theory]
        [InlineData(5000, 5000)]
        [InlineData(10000, 0)]
        public void Withdraw_ShouldWithdrawAmountFromAccountShouldWork(double amount, double expected)
        {
            //Arrange
            Account testAcc = new Account();
            testAcc.Amount = 10000;
            //Act
            testAcc.Withdraw(amount);
            //Assert
            Assert.Equal(expected, testAcc.Amount);
        }

        [Fact]
        public void Withdraw_ShouldThrowException()
        {
            //Arrange
            Account testAcc = new Account();
            testAcc.Amount = 10000;
            //Act
            //Assert
            Assert.Throws<Exception>(() => testAcc.Withdraw(15000));
        }

        [Theory]
        [InlineData(10000, 20000)]
        [InlineData(double.MaxValue, double.MaxValue)]
        [InlineData(-10000, 0)]
        public void Deposit_ShouldDepositAmountIntoAccount(double amount, double expected)
        {
            //Arrange
            Account testAcc = new Account();
            testAcc.Amount = 10000;
            //Act
            testAcc.Deposit(amount);
            //Assert
            Assert.Equal(expected, testAcc.Amount);
        }
    }
}
