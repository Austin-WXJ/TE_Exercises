﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /* 
         Given a List of Integers, and an int value, 
         return true if the int value appears two or more times in 
         the list.
         foundIntTwice( [5, 7, 9, 5, 11], 5 ) -> true
         foundIntTwice( [6, 8, 10, 11, 13], 8 -> false
         foundIntTwice( [9, 23, 44, 2, 88, 44], 44) -> true
         */
        public bool FoundIntTwice(List<int> integerList, int intToFind)
        {
            bool answer = false;
            List<int> sameInt = new List<int>();

            foreach (int singleInt in integerList)
            {
                if (singleInt == intToFind)
                {
                    sameInt.Add(intToFind);
                }
            }
            if (sameInt.Count == 2)
            {
                answer = true;
            }


            return answer;
        }

    }
}
