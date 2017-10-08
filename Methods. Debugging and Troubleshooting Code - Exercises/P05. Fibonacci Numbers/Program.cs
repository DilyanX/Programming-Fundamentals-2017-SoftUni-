using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Fibonacci_Numbers
{
    class Program
    {
        static void Fib(long n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
          Fib(n);
        }
    }
}
