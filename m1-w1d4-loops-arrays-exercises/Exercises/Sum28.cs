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
         Given an array of ints, return true if the sum of all the 2's in the array is exactly 8.
         sum28([2, 3, 2, 2, 4, 2]) → true
         sum28([2, 3, 2, 2, 4, 2, 2]) → false
         sum28([1, 2, 3, 4]) → false
         */
        public bool Sum28(int[] nums)
        {
            int arraySum = 0;
            bool sumBool = false;

            for (int n = 0; n < nums.Length; n++)
            {
                if (nums[n] == 2)
                {
                    arraySum += nums[n];
                }

            }
            if (arraySum == 8)
            {
                sumBool = true;
            }
            return sumBool;
        }

    }
}
