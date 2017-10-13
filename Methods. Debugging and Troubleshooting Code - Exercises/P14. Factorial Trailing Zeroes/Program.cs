using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            BigInteger result = GetFactorial(input);
            Console.WriteLine(GetTrailingZeroes(result));

        }
        private static BigInteger GetFactorial(BigInteger input) // намира факториел
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
        static BigInteger GetTrailingZeroes(BigInteger num) // намира поредни нули в число
        {

            BigInteger timesZero = 0;
            while (num % 10 == 0)
            {
                num = num / 10;
                timesZero++;
            }
            return timesZero;
        }
    }
}
