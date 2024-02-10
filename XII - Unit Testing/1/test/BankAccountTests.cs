// BankAccountTests.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;
using NUnit.Framework;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount()
        {
            // Arrange
            var account = new BankAccount("John Doe", 100);

            // Act
            account.Debit(50);

            // Assert
            Assert.AreEqual(50, account.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThanZero()
        {
            // Arrange
            var account = new BankAccount("John Doe", 100);

            // Act
            account.Debit(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsMoreThanBalance()
        {
            // Arrange
            var account = new BankAccount("John Doe", 50);

            // Act
            account.Debit(100);
        }

        [TestMethod]
        public void Credit_WithValidAmount()
        {
            // Arrange
            var account = new BankAccount("Jane Doe", 100);

            // Act
            account.Credit(50);

            // Assert
            Assert.AreEqual(150, account.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Credit_WhenAmountIsLessThanZero()
        {
            // Arrange
            var account = new BankAccount("Jane Doe", 100);

            // Act
            account.Credit(-1);
        }
    }
}