using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace P13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFactorial(input));         
        }
        private static BigInteger GetFactorial(int input)
        {
            BigInteger factorial = 1;
            while (true)
            {
                if (input <= 1)
                {
                    break;
                }
                factorial *= input;
                input--;
            }
            return factorial;
        }
    }
}
