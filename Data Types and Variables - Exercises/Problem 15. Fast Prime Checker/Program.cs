using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int number = 2; number <= input; number++)
            {
                bool isPrime = true;
                for (int devider = 2; devider <= Math.Sqrt(number); devider++)
                {
                    if (number % devider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {isPrime}");
            }

        }
    }
}
