using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOne = int.Parse(Console.ReadLine());
            var numTwo = int.Parse(Console.ReadLine());
            var min = 0;
            var max = 0;

            if (numOne > numTwo)
            {
                min = numTwo;
                max = numOne;
            }
            else if (numOne < numTwo)
            {
                min = numOne;
                max = numTwo;
            }

            for (int i = min; i <= max; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}