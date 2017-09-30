using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            var count = 0;
            var result = 0.0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {

                    if (result >= boundary)
                    {
                        break;
                    }
                    result += (i * j) * 3;
                    count++;

                }
            }
            if (result >= boundary)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {result} >= {boundary}");

            }
            else
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {result}");
            }
        }
    }
}
//Write a program, which finds all the possible combinations between two numbers – N and M.
//The first digit decreases from N to 1, and the second digit increases from 1 to M.
//The two digits form a number.Multiply the two digits, then multiply their product by 3. Add the result to the total sum.
//You will also be given a third number, which will be the maximum boundary of the sum.
//If the sum is equal or greater than this number you should stop the program. See the examples for further information. 
//The input is read from the console and consists of three lines: 
//First line – N – integer in the interval[1…100]
//Second line – M – integer in the interval[1…100]
//Third line – maximum sum boundary – integer in the interval[1…1000000]
