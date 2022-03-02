using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring values
            int dividend = 90, divisor = 11;
            //Formula for quotient and remainder
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
    

