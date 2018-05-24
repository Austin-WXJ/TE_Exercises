using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {

        /*
         Given a non-negative number "num", return true if num is within 2 of a multiple of 10. Note: (a % b) 
         is the remainder of dividing a by b, so (7 % 5) is 2. 
         nearTen(12) → true
         nearTen(17) → false
         nearTen(19) → true
         */
        public bool NearTen(int num)
        {
            int remainder = num % 10;
            if (10 % remainder <=2)
            {
                return true;
            }
            return false;
        }
    }
}
