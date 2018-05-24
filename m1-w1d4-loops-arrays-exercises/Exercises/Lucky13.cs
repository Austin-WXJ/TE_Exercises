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
         Given an array of ints, return true if the array contains no 1's and no 3's.
         lucky13([0, 2, 4]) → true
         lucky13([1, 2, 3]) → false
         lucky13([1, 2, 4]) → false
         */
        public bool Lucky13(int[] nums)
        {
            bool result = true;
            if ((nums[0] == 1 || nums[0] == 3) && (nums[nums.Length - 1] == 1 || nums[nums.Length - 1] == 3))
            {
                result = false;
            }
            return result;
        }

    }
}
