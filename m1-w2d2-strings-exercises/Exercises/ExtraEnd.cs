using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return a new string made of 3 copies of the last 2 chars of the original string. The string 
         length will be at least 2.
         extraEnd("Hello") → "lololo"
         extraEnd("ab") → "ababab"
         extraEnd("Hi") → "HiHiHi"
         */
        public string ExtraEnd(string str)
        {
            string extraEnds = "";

            if (str.Length > 2)
            {
                extraEnds = string.Concat(
                    str[str.Length - 2], str[str.Length - 1],
                    str[str.Length - 2], str[str.Length - 1], 
                    str[str.Length - 2], str[str.Length - 1]);
            }
            else if (str.Length <= 2)
            {
                extraEnds = string.Concat(str, str, str);
            }
            return extraEnds;
        }
    }
}
