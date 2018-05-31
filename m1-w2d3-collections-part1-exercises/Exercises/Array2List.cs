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
         Given an array of Strings, return a List containing the same Strings in the same order 
         array2List( {"Apple", "Orange", "Banana"} )  ->  ["Apple", "Orange", "Banana"]
         array2List( {"Red", "Orange", "Yellow"} )  ->  ["Red", "Orange", "Yellow"]
         array2List( {"Left", "Right", "Forward", "Back"} )  ->  ["Left", "Right", "Forward", "Back"] 
         */
        public List<string> Array2List(string[] stringArray)
        {
            //List<string> result = new List<string>();
            //HashSet<string> answerSet = new HashSet<string>();
            List<string> answerSet = new List<string>();

            //foreach ( string fruit in stringArray)
            //{
            //    // for each 
            //    answerSet.Add(fruit);
            //}
            for (int i = 0; i< stringArray.Length; ++i)
            {
                if (!answerSet.Contains(answerSet[i]))
                {
                    answerSet[i] = stringArray[i];
                }
            }


            //return null;
            return answerSet;
        }

    }
}
