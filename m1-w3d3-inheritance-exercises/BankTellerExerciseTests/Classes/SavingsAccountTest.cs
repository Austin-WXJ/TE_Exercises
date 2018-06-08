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

        [TestInitialize]
        public void Initialize()
        {
            testSavingsAccount = new SavingsAccount();
        }

        [TestMethod]
        public void SavingsAccountNumber()
        {
            Assert.AreEqual(null, testSavingsAccount.AccountNumber);
            testSavingsAccount.AccountNumber = "ABC123";
            Assert.AreEqual("ABC123", testSavingsAccount.AccountNumber);
        }

        [TestMethod]
        public void SavingsAccount()
        {
            //BankAccount testBankAccount = new BankAccount();

            Assert.AreEqual(0M, testSavingsAccount.Balance);
            testSavingsAccount.Deposit(200M);
            Assert.AreNotEqual(2M, testSavingsAccount.Balance);
            Assert.AreEqual(200M, testSavingsAccount.Balance);
        }

        [TestMethod]
        public void SavingsDeposit()
        {

            testSavingsAccount.Deposit(5M);
            Assert.AreNotEqual(500M, testSavingsAccount.Balance);
            Assert.AreEqual(5.00M, testSavingsAccount.Balance);

        }
        [TestMethod]
        public void SavingsWithdraw()
        {
            testSavingsAccount.Withdraw(5M);
            Assert.AreNotEqual(500M, testSavingsAccount.Balance);
            Assert.AreEqual(5M, testSavingsAccount.Balance);

        }
        [TestMethod]
        public void SavingsTransfer()
        {


        }

    }
}
