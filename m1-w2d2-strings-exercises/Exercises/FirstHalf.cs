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
         Given a string of even length, return the first half. So the string "WooHoo" yields "Woo".
         firstHalf("WooHoo") → "Woo"
         firstHalf("HelloThere") → "Hello"
         firstHalf("abcdef") → "abc"
         */
        public string FirstHalf(string str)
        {

            string firstHalf = str.Substring(0, str.Length / 2);

            return firstHalf;
        }
    }
}
