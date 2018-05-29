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
         Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
         altPairs("kitten") → "kien"
         altPairs("Chocolate") → "Chole"
         altPairs("CodingHorror") → "Congrr"
         */
        public string AltPairs(string str)
        {
            string altPairs = str;
            string result = "";

            for (int i = 0; i < altPairs.Length; i += 4)
            {
                result = String.Concat(result, altPairs.Substring(i, 1));

                if (i + 1 < altPairs.Length)
                {
                    result = String.Concat(result, altPairs.Substring(i + 1, 1));
                    // concatenating a string instead of building an array
                    //see if altPairs.Substring to see if i+1 is still less than altPairs.Substring and if is take in one more character
                }
            }
            return result;
            //return null;

        }
    }
}
