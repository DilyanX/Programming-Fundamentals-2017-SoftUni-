using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(GetResult(n, power));    
        }
        static double GetResult(double n, double power)
        {
            double total = Math.Pow(n, power);
            return total;
        }
    }
}
