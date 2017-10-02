using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

            try
            {
                long num = long.Parse(input);
                Console.WriteLine("{0} can fit in:", input);
                if (num >= sbyte.MinValue && num <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (num >= byte.MinValue && num <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }
                if (num >= short.MinValue && num <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }
                if (num >= ushort.MinValue && num <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (num >= int.MinValue && num <= int.MaxValue)
                {
                    Console.WriteLine("* int");
                }
                if (num >= uint.MinValue && num <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }
                if (num >= long.MinValue && num <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("{0} can't fit in any type",input);
            }
        }
    }
}

//Given an input integer, you must determine which primitive data types are capable
//of properly storing that input.
//Input
//⦁	You receive N – integer which can be arbitrarily large or small
