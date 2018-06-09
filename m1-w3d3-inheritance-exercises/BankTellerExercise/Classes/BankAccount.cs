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

        ///Properties
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        ///Constructors
        public BankAccount()
        {
            Balance = 0;
        }

        ///Methods
        public decimal Deposit(decimal ammountToDeposit)
        {
            return Balance += ammountToDeposit;
        }
        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            return Balance -= amountToWithdraw;
        }
    public void Transfer(BankAccount destinationAccount, decimal transferAmount)
        {
            Balance -= transferAmount;
            destinationAccount.Deposit(transferAmount);
        }
    }
}
