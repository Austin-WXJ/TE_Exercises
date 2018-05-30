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
         Given a string, return true if it ends in "ly".
         endsLy("oddly") → true
         endsLy("y") → false
         endsLy("oddy") → false
         */
        public bool EndsLy(string str)
        {
            bool answer = false;
            string str2 = str.ToLower();
            int lyEnd = str2.IndexOf("ly");

            if (str.Length >= 2)
            {
                if (lyEnd == (str2.Length - 2))
                {
                    answer = true;
                }

            }

            return answer;
        }
    }
}
