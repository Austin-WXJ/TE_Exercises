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
         * Given an array of strings, return a Dictionary<string, Boolean> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         * 
         * wordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * wordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * wordMultiple(["c", "c", "c", "c"]) → {"c": true}
         * 
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            int countForEach = 0;
            int countIf = 0;

            Dictionary<string, Boolean> repeatChar = new Dictionary<string, Boolean>();

            foreach (string word in words) //build dictionary key value pair
            {
                countForEach++;

                if (!repeatChar.ContainsKey(word))//if repeatChar already contains key,
                {
                    countIf++;
                    repeatChar[word] = false;// that key value switches to true
                }
                else
                {
                    repeatChar[word] = true;
                }


            }
            return repeatChar;
        }
    }
}
