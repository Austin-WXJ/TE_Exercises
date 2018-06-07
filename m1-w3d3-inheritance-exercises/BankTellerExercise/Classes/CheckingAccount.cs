using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    class CheckingAccount : BankAccount
    {
        ///Instance Variables


        ///Properties


        ///Constructors


        ///Methods
        ///| Withdraw override case 1| If the balance falls below $0.00                          |
        ///                          | a $10.00 overdraft fee is also withdrawn from the account.|
        ///| Withdraw override case 1| Checking account cannot be more than $100.00 overdrawn.   |
        ///                          | If a withdrawal is requested leaving the account more     |
        ///                          |than $100.00, it fails and the balance remains the same.   |


    }
}
