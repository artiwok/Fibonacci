using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static int FibonacciPositive(int num)
        {
            if (num == 0)
            {
                return 0;
            }

            if (num == 1)
            {
                return 1;
            }


            return FibonacciPositive(num - 1) + FibonacciPositive(num - 2);
        }

        static int FibonacciNegative(int num)
        {
            if (num == 0)
            {
                return 0;
            }

            if (num == 1)
            {
                return 1;
            }

            return FibonacciNegative(num + 2) - FibonacciNegative(num + 1);
        }



        static void Main(string[] args)
        {
            Console.WriteLine($"\nThe positive Fibonacci number = {FibonacciPositive(9)}");

            Console.WriteLine($"\nThe negative Fibonacci number = {FibonacciNegative(-12)}\n");


        }
    }
}
