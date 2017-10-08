using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Draw_a_Filled_Square
{
    class Program
    {
        static void PrintingTopAndBottom(int input)
        {
            Console.WriteLine(new string('-', 2 * input));
        }
        static void PrintMiddle(int input)
        {
            Console.Write('-');
            for (int i = 1; i < input; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
         
        }

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintingTopAndBottom(input);
            for (int i = 0; i < input - 2; i++)
            {
                PrintMiddle(input);
            }
            PrintingTopAndBottom(input);
        }
    }
}
