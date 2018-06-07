using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        ///The BankAccount class represents a simple checking or savings account at a bank.
        ///The balance is represented in USD using the DollarAmount type.
        ///

        //Instance Variables
        private decimal accountBalanceUSD;
        private int accountNumber;
        private int destinationAccount;
        private decimal transferAmount;

        ///Properties
        ///| Property Name | Data Type | Get | Set | Description                                             |
        ///|---------------|-----------|-----|-----|-------------------------------------------------------- |
        ///| AccountNumber | string    |  X  |  X  | Returns the account number that the account belongs to. |
        ///| Balance       | decimal   |  X  |prvt | Returns the balance value of the bank account.          |
        public string AccountNumber
        { get; set; }

        public decimal Balance
        { get; private set; }

        ///Constructors
        ///| Constructor   | Description                                                      |
        ///|---------------|------------------------------------------------------------------|
        ///| BankAccount() | A new bank account's balance is defaulted to a 0 dollar balance. |
        public BankAccount()
        {
            accountBalanceUSD = 0;
        }

        ///Methods
        ///| Method Name                                                      | Return Type | Description                                                                                           |
        ///|------------------------------------------------------------------|-------------|-------------------------------------------------------------------------------------------------------|
        ///| Deposit(decimal amountToDeposit)                                 | decimal     | Adds amountToDeposit to the current balance, and returns the new balance of the bank account.         |
        ///| Withdraw(decimal amountToWithdraw)                               | decimal     | Subtracts amountToWithdraw from the current balance, and returns the new balance of the bank account. |
        ///| Transfer(BankAccount destinationAccount, decimal transferAmount) | void        | Withdraws `transferAmount` from this account and deposits it into `destinationAccount`.               |
        public decimal Deposit(decimal ammountToDeposit)
        {
            return accountBalanceUSD += ammountToDeposit;
        }
        public decimal Withdraw(decimal amountToWithdraw)
        {
            return accountBalanceUSD -= amountToWithdraw;
        }
        public void Transfer(BankAccount destinationAccount, decimal transferAmount)
        {
            this.transferAmount = accountBalanceUSD - transferAmount;
        }
    }
}
