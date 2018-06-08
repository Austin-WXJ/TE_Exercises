using System;
using BankTellerExercise.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class BankCustomerTest
    {
        BankCustomer testCustomer = new BankCustomer("", "", "");
        BankAccount testAccount1 = new SavingsAccount();
        BankAccount testAccount2 = new CheckingAccount();
        string name = "Joe Bob";
        string address = "123 Butter Ln.";
        string phoneNumber = "614-867-5309";

        [TestInitialize]
        public void Initialize()
        {

            testCustomer = new BankCustomer(name, address, phoneNumber);

        }
        [TestMethod]
        public void BankCustomer_Name()
        {
            Assert.AreEqual(name, testCustomer.Name);
        }
        [TestMethod]
        public void BankCustomer_Address()
        {
            Assert.AreEqual(address, testCustomer.Address);
        }
        [TestMethod]
        public void BankCustomer_PhoneNumber()
        {
            Assert.AreEqual(phoneNumber, testCustomer.PhoneNumber);
        }
        [TestMethod]
        public void BankCustomer_Accounts()
        {
            testCustomer.AddAccount(testAccount1);
            testCustomer.AddAccount(testAccount2);
            CollectionAssert.AreEquivalent(new[] { testAccount1, testAccount2}, testCustomer.Accounts);
        }
        [TestMethod]
        public void BankCustomer_IsVIP()
        {
            Ass
        }
    }
}
