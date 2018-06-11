using System;
using BankTellerExercise.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class BankCustomerTest
    {
        BankCustomer testCustomer = new BankCustomer("", "", "");
        BankAccount testAccount1 = new SavingsAccount();
        BankAccount testAccount2 = new CheckingAccount();
        BankAccount testAccount3 = new CheckingAccount();
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
            testCustomer.AddAccount(testAccount3);
            testAccount1.Deposit(50000M);
            testAccount2.Deposit(400M);
            testAccount3.Deposit(3M);
            BankAccount[] accountArray = { testAccount1, testAccount2, testAccount3 };
            CollectionAssert.AreEquivalent(accountArray, testCustomer.Accounts);
        }
        [TestMethod]
        public void BankCustomer_IsVIP()
        {
            testCustomer.AddAccount( testAccount1 );
            testAccount1.Deposit( 500M );
            Assert.IsFalse( testCustomer.IsVIP );

            testAccount1.Deposit( 49500M );
            Assert.IsTrue( testCustomer.IsVIP );

            testAccount1.Withdraw( 30000M );
            Assert.IsFalse( testCustomer.IsVIP );

            testCustomer.AddAccount( testAccount2 );
            testAccount2.Deposit( 5001M );
            Assert.IsTrue( testCustomer.IsVIP );

        }
    }
}
