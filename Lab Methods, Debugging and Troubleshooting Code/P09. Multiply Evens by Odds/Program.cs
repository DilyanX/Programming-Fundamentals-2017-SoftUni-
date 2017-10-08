using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvensToOdds(input);
            Console.WriteLine(result);
        }

        static int GetSumOfEven(int input)
        {
            int evenSum = 0;

            while (input > 0)
            {
                int lastDigit = input % 10;
                input = input / 10;

                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
            }

            return evenSum;
        }

        static int GetSumOfOdd(int input)
        {
            int oddSum = 0;

            while (input > 0)
            {
                int lastDigit = input % 10;
                input = input / 10;

                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                }
            }

            return oddSum;
        }

        static int GetMultipleOfEvensToOdds(int input)
        {
            int evenSum = GetSumOfEven(input);
            int oddSum = GetSumOfOdd(input);

            return evenSum * oddSum;
        }
    }
}
