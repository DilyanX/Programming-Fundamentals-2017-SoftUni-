using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            char a = (char)first;
            char b = (char)second;

            for (char i = a; i <= b; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
