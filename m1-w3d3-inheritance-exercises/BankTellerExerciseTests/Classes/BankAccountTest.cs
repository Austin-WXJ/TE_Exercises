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
        BankAccount testBankAccountTwo = new BankAccount();

        [TestInitialize]
        public void Initialize()
        {
            testBankAccount = new BankAccount();
            testBankAccountTwo = new BankAccount();
        }

        [TestMethod]
        public void BankAccount_Constructor()
        {
            Assert.AreEqual(null, testBankAccount.AccountNumber);

            string testAccountNumber = testBankAccount.AccountNumber = "ABC123";
            string testAccountTwoNumber = testBankAccountTwo.AccountNumber = "XYZ456";

            Assert.AreEqual(testAccountNumber, testBankAccount.AccountNumber);
            Assert.AreEqual(testAccountTwoNumber, testBankAccountTwo.AccountNumber);

            Assert.AreEqual(0.0M, testBankAccount.Balance);
        }

        [TestMethod]
        public void BankAccount_Deposit()
        {
            testBankAccount.Deposit(123.5M);

            Assert.AreEqual(123.5M, testBankAccount.Balance);

        }
        [TestMethod]
        public void BankAccount_Withdraw()
        {
            testBankAccount.Withdraw(123.5M);
            Assert.AreEqual(-123.5M, testBankAccount.Balance);
        }
        [TestMethod]
        public void BankAccount_Transfer()
        {
            testBankAccount.Deposit(500M);
            testBankAccount.Transfer(testBankAccountTwo, 123M);

            Assert.AreEqual(377M, testBankAccount.Balance);
            Assert.AreEqual(123M, testBankAccountTwo.Balance);
        }

    }
}


