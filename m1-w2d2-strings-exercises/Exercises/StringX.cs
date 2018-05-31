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
        Given a string, return a version where all the "x" have been removed. 
        Except an "x" at the very start or end 
        should not be removed.
        stringX("xxHxix") → "xHix"
        stringX("abxxxcd") → "abcd"
        stringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            //string answer = "";

            string result = str;
            // check if first char is x and if str contains x and str length is greater than 1
            if (str.IndexOf('x') == 0 && str.Contains('x') == true && str.Length > 1)
            {
                result = ($"x{str.Replace("x", "")}x");
            }
            // if the first char is not x and string contains x 
            else if (str.IndexOf("x") != 0 && str.Contains('x') == true && str.IndexOf("x") != str.Length-1)
            {
                result = str.Replace("x", "");
            }
                //return null;
                return result;
        }
    }
}

