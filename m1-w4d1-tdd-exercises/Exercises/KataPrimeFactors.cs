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

            if (n % F != 0)
            {
                F++;
            }
            while (n % F == 0)
            {
                result.Add(F);
                n /= F;

            }


            return result.ToArray();
        }
    }
}
