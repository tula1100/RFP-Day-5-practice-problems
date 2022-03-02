using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp_3
{
    internal class Program
    {
        public static int Powerof2(int n)
        {
            int result = 0;
            for (int i = n; i >= 1; i--)
            {
                if ((i & (i - 1)) == 0)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
        static public void Main()
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32((string)Console.ReadLine());
            Powerof2(number);
        }
    }

}
    

