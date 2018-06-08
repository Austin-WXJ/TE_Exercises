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
        public void CheckingAccountNumber()
        {
            Assert.AreEqual(null, testCheckingAccount.AccountNumber);
            testCheckingAccount.AccountNumber = "ABC123";
            Assert.AreEqual("ABC123", testCheckingAccount.AccountNumber);
        }

        [TestMethod]
        public void CheckingAccount()
        {
            //BankAccount testBankAccount = new BankAccount();

            Assert.AreEqual(0M, testCheckingAccount.Balance);
            testCheckingAccount.Deposit(200M);
            Assert.AreNotEqual(2M, testCheckingAccount.Balance);
            Assert.AreEqual(200M, testCheckingAccount.Balance);
        }

        [TestMethod]
        public void CheckingDeposit()
        {

            testCheckingAccount.Deposit(5M);
            Assert.AreNotEqual(500M, testCheckingAccount.Balance);
            Assert.AreEqual(5M, testCheckingAccount.Balance);

        }
        [TestMethod]
        public void CheckingWithdraw()
        {
            testCheckingAccount.Withdraw(5M);
            Assert.AreEqual(-15M, testCheckingAccount.Balance);
            testCheckingAccount = new CheckingAccount();
            Assert.AreEqual(-110,testCheckingAccount.Withdraw(100));
            Assert.AreEqual(-110, testCheckingAccount.Withdraw(10));
        }
        [TestMethod]
        public void CheckingWithdrawOverDraft()
        {
            testCheckingAccount.Withdraw(5M);
            Assert.AreNotEqual(20.5M, testCheckingAccount.Balance);
            Assert.AreEqual(-5M, testCheckingAccount.Balance);

        }
        [TestMethod]
        public void CheckingTransfer()
        {


        }

    }
}
