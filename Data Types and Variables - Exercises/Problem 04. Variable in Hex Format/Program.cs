using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(input, 16));
        }
    }
}

//Write a program that reads a number in hexadecimal format (0x##) 
//convert it to decimal format and prints it.
