using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using HæveAutomatenNet;
using Xunit.Sdk;

namespace HæveAutomaten.Tests
{
    public class AccountTest
    {
        [Theory]
        [InlineData(5000)]
        public void Withdraw_ShouldWithdrawAmountFromAccountShouldWork(double amount)
        {
            double expected = 5000;

            Account testAcc = new Account();
            testAcc.Amount = 10000;
            testAcc.Withdraw(amount);

            Assert.Equal(expected, testAcc.Amount);
        }
    }
}
