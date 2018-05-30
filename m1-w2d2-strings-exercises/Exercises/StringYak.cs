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
         Suppose the string "yak" is unlucky. Given a string, 
         return a version where all the "yak" are removed, but 
         the "a" can be any char. The "yak" strings will not overlap.
         stringYak("yakpak") → "pak"
         stringYak("pakyak") → "pak"
         stringYak("yak123ya") → "123ya"
         */
        public string StringYak(string str)
        {
            string answer = "";
            //loop
            //step through the whole string;
            //look at current char and the next one over
            //if the first char 
            int i = 0;
            for (i = 0; i < str.Length - 2; i++)
            {
                if (str[i] == 'y' && str[i + 2] == 'k')
                {
                    i += 2;
                }
                else
                {
                    answer += (str.Substring(i, 1));
                }
            }
            while (i < str.Length)
            {
                answer += str.Substring(i, 1);
                i++;
            }
            //if 

            //return null;
            return answer;
        }
    }
}
