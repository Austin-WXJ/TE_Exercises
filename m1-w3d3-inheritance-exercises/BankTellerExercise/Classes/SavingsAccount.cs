using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        ///Methods
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance <= amountToWithdraw)
            {
                return Balance;
            }
            else if (Balance < 150)
            {
                return base.Withdraw(amountToWithdraw + 2M);
            }
            return base.Withdraw(amountToWithdraw);
        }
    }
}
