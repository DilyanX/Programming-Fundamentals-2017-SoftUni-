using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;


namespace P03.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
           int num = int.Parse(Console.ReadLine());
           BigIntiger factorial = 1;

            for (int fact = 2; fact <= num; fact++)
            {
                factorial *= fact;
            }
            Console.WriteLine(factorial);
        }
    }
}
