using BankikngSystem;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Test
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void DepositShouldIncreaseBalance()
        {
            {

                //Arrange
                BankAccount bankAccount = new BankAccount(123);
                decimal depositAmount = 100;
                //Act
                bankAccount.Deposit(depositAmount);
                //Assert
                Assert.AreEqual(depositAmount, bankAccount.Balance);
            }
        }

        [Test]
        public void AccountInicializeWhithPositiveValue()
        {
            {
                //Arrange

                //Act
                BankAccount bankAccount = new BankAccount(123, 2000m);
                //Assert
                Assert.AreEqual(2000m, bankAccount.Balance);
            }
        }
    }
}
