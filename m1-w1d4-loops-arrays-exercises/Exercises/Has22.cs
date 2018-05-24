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
         Given an array of ints, return true if the array contains a 2 next to a 2 somewhere.
         has22([1, 2, 2]) → true
         has22([1, 2, 1, 2]) → false
         has22([2, 1, 2]) → false
         */
        public bool Has22(int[] nums)
        {
            bool result = false;
            for (int n = 0; n < nums.Length -1; n++)
            {
                if ((nums[n] == 2) && (nums[n+1] == 2))
                {
                    result = true;
                }

            }
            return result;
        }

    }
}
