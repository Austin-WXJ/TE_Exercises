using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BankTellerExercise.Classes;


namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class SavingsAccountTest
    {
        SavingsAccount testSavingsAccount = new SavingsAccount();
        SavingsAccount testSavingsAccountTwo = new SavingsAccount();

        [TestInitialize]
        public void Initialize()
        {
            testSavingsAccount = new SavingsAccount();
            testSavingsAccountTwo = new SavingsAccount();
        }

        [TestMethod]
        public void SavingsAccount_Constructor()
        {
            Assert.AreEqual(null, testSavingsAccount.AccountNumber);

            string testAccountNumber = testSavingsAccount.AccountNumber = "ABC123";
            string testAccountTwoNumber = testSavingsAccountTwo.AccountNumber = "XYZ456";

            Assert.AreEqual(testAccountNumber, testSavingsAccount.AccountNumber);
            Assert.AreEqual(testAccountTwoNumber, testSavingsAccountTwo.AccountNumber);

            Assert.AreEqual(0.0M, testSavingsAccount.Balance);
        }

        [TestMethod]
        public void SavingsAccount_Deposit()
        {
            testSavingsAccount.Deposit(123.5M);

            Assert.AreEqual(123.5M, testSavingsAccount.Balance);

        }
        [TestMethod]
        public void SavingsAccount_Withdraw()
        {
            testSavingsAccount.Withdraw(123.5M);
            Assert.AreEqual(0M, testSavingsAccount.Balance);
            testSavingsAccount.Deposit(100M);
            Assert.AreEqual(100M, testSavingsAccount.Balance);
            testSavingsAccount.Withdraw(48M);
            Assert.AreEqual(50M, testSavingsAccount.Balance);
            testSavingsAccount.Deposit(250M);
            Assert.AreEqual(300M, testSavingsAccount.Balance);
            testSavingsAccount.Withdraw(299M);
            Assert.AreEqual(1M, testSavingsAccount.Balance);

        }
        [TestMethod]
        public void SavingsAccount_Transfer()
        {
            testSavingsAccount.Deposit(500M);
            testSavingsAccount.Transfer(testSavingsAccountTwo, 123M);

            Assert.AreEqual(377M, testSavingsAccount.Balance);
            Assert.AreEqual(123M, testSavingsAccountTwo.Balance);
        }

    }
}
