using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string FizzBuzz(int n)
        {
            string result = "";
            if (n > 0 && n <= 100)
            {

                if (n % 5 == 0 && n % 3 == 0)
                {
                    result = "FizzBuzz";
                }
                else if (n % 5 == 0)
                {
                    result = "Buzz";
                }
                else if (n % 3 == 0)
                {
                    result = "Fizz";
                }
                else
                {
                    result = n.ToString();
                }
            }
            return result;
        }
    }
}

