using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first_n, second_n, third_n;

            Console.WriteLine("Enter the first number : ");
            first_n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            second_n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            third_n = int.Parse(Console.ReadLine());

            if (first_n > second_n)
            {
                if (first_n > third_n)
                {
                    Console.WriteLine("largest number : " + first_n);
                }
                else
                {
                    Console.WriteLine("largest number : " + third_n);
                }
            }
            else
            {
                if (second_n > third_n)
                {
                    Console.WriteLine("largest number : " + second_n);
                }
                else
                {
                    Console.WriteLine("largest number : " + third_n);
                }
            }
        }
    }
}




