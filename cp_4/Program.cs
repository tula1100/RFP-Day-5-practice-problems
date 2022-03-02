using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp_4
{
    internal class Program
    {
        static double nthHarmonic(int n)
        {
            float harmonic = 1;

            // loop to apply the formula
            // Hn = H1 + H2 + H3 ... +
            // Hn-1 + Hn-1 + 1/n
            for (int i = 2; i <= n; i++)
            {
                harmonic += (float)1 / i;
            }

            return harmonic;
        }
        static public void Main()
        {
            int N = 10;

            Console.Write(nthHarmonic(N));
        }
    }
}