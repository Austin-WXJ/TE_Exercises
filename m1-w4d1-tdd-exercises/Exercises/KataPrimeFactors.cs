using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /* OPTIONAL */
    public class KataPrimeFactors
    {
        public int[] Factor(int n)
        {
            int F = 2;

            List<int> result = new List<int>();

            while (n != 1)
            {
                if (n % F == 0)
                {
                    result.Add(F);
                    n /= F;
                }
                else
                {
                    F++;
                }
            }
            return result.ToArray();
        }
    }
}
