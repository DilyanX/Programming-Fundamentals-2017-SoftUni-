using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            GetReversed(input);
        }

        static void GetReversed(string input)
        {
            char[] reverseArr = input.ToCharArray();
            Array.Reverse(reverseArr);
            new string(reverseArr);
            Console.WriteLine(reverseArr);
        }
    }
}
