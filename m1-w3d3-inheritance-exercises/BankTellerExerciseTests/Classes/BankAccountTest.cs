using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class BankAccountTest
    {
        BankAccount testBankAccount = new BankAccount();

        [TestInitialize]
        public void Initialize()
        {
            testBankAccount = new BankAccount();
        }
        [TestMethod]
        public void AccountNumber()
        {
            Assert.AreEqual(null, testBankAccount.AccountNumber);
            testBankAccount.AccountNumber = "ABC123";
            Assert.AreEqual("ABC123", testBankAccount.AccountNumber);
        }

        [TestMethod]
        public void BankAccount()
        {
            Assert.AreEqual(0M, testBankAccount.Balance);
            testBankAccount.Deposit(200M);
            Assert.AreNotEqual(2M, testBankAccount.Balance);
            Assert.AreEqual(200M, testBankAccount.Balance);
        }

        [TestMethod]
        public void Deposit()
        {
            
            testBankAccount.Deposit(5M);
            Assert.AreNotEqual(20.5M, testBankAccount.Balance);
            Assert.AreEqual(205M, testBankAccount.Balance);

        }
        [TestMethod]
        public void Withdraw()
        {
            testBankAccount.Deposit(5M);
            Assert.AreNotEqual(20.5M, testBankAccount.Balance);
            Assert.AreEqual(205M, testBankAccount.Balance);

        }
        [TestMethod]
        public void Transfer()
        {
            

        }

    }
}


