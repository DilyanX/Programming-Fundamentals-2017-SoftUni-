using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var hex = Convert.ToString(input, 16);
            var binary = Convert.ToString(input, 2);
            Console.WriteLine(hex.ToUpper());
            Console.WriteLine(binary);

        }
    }
}
// Create a program to convert a decimal 
// number to hexadecimal and binary number and print it.