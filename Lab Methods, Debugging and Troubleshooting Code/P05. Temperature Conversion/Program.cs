using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            FahrenheitToCelsius(fahrenheit);
        }
        static void FahrenheitToCelsius(double fahrenheit)
        {
            var celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{celsius :F2}");
        }
    }
}
