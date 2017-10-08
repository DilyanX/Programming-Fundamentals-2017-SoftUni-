using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = Math.Abs(int.Parse(Console.ReadLine()));
            int end = Math.Abs(int.Parse(Console.ReadLine()));
            string numbers = String.Join(", ", PrimeRange(start, end).ToArray());
            Console.WriteLine(numbers);

        }
        static  List<int> PrimeRange(int start, int end)
        {
            var result = new List<int>();
            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                if (i < 2) isPrime = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}

//Write a method that calculates all prime numbers in given range and returns them as list of integers:
//static List<int> FindPrimesInRange(startNum, endNum)
//{
//}
//Write a method to print a list of integers.Write a program that enters two integer numbers(each at a separate line)
//and prints all primes in their range, separated by a comma.
