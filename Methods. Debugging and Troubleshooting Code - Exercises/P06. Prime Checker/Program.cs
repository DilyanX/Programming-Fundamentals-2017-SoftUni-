using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = Math.Abs(long.Parse(Console.ReadLine()));
            Console.WriteLine(IsPrime(input));
        }

         static bool  IsPrime(long input)
        {
            if (input <= 1 || input % 2 == 0 && input != 2)
            {
                return false;
            }
            var boundary = (int)Math.Floor(Math.Sqrt(input));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (input % i == 0) return false;
            }
            return true;
        }
    }
}
