using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp_2
{
    internal class Program
    {
        static bool main(int year)
        {
            if (year % 400 == 0)
                return true;

            if (year % 100 == 0)
                return false;

            if (year % 4 == 0)
                return true;
            return false;
        }
        public static void Main()
        {
            int year = 2022;
            Console.Write(main(year) ? "Leap Year" : "Not a Leap Year");
        }

    }
}










