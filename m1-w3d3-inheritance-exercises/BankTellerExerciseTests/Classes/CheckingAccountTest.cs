using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BankTellerExercise.Classes;


namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class CheckingAccountTest
    {
        CheckingAccount testCheckingAccount = new CheckingAccount();

        [TestInitialize]
        public void Initialize()
        {
            testCheckingAccount = new CheckingAccount();
        }

        [TestMethod]
        public void CheckingAccount_Constructor()
        {
            Assert.AreEqual(null, testCheckingAccount.AccountNumber);

            string testAccountNumber = testCheckingAccount.AccountNumber = "ABC123";

            Assert.AreEqual(testAccountNumber, testCheckingAccount.AccountNumber);

            Assert.AreEqual(0.0M, testCheckingAccount.Balance);
        }

        [TestMethod]
        public void CheckingAccount_Deposit()
        {
            testCheckingAccount.Deposit(123.5M);

            Assert.AreEqual(123.5M, testCheckingAccount.Balance);

        }
        [TestMethod]
        public void CheckingAccount_Withdraw()
        {
            testCheckingAccount.Withdraw(123.5M);
            Assert.AreEqual(-133.5M, testCheckingAccount.Balance);
            testCheckingAccount.Withdraw(1M);
            Assert.AreEqual(-133.5M, testCheckingAccount.Balance);
            testCheckingAccount.Deposit(1000M);
            Assert.AreEqual(866.5M, testCheckingAccount.Balance);
            testCheckingAccount.Withdraw(60.5M);
            Assert.AreEqual(806.0M, testCheckingAccount.Balance);

        }
        [TestMethod]
        public void CheckingAccount_Transfer()
        {
            CheckingAccount testCheckingAccountTwo = new CheckingAccount();

            testCheckingAccount.Deposit(500M);
            testCheckingAccount.Transfer(testCheckingAccountTwo, 123M);

            Assert.AreEqual(377M, testCheckingAccount.Balance);
            Assert.AreEqual(123M, testCheckingAccountTwo.Balance);
        }
    }
}
