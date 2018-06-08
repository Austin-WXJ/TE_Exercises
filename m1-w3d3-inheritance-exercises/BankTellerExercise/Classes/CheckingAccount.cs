using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        //Methods
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance <= -100)
            {
                return Balance;
            }
            else if (Balance <= 0)
            {
                return base.Withdraw(amountToWithdraw + 10M);
            }
            else
            {
                return base.Withdraw(amountToWithdraw);
            }
        }
    }
}
