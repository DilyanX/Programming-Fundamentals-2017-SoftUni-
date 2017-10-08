using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] input = new int[num];
            for (int i = 0; i < num; i++)
            {
                input[i] = int.Parse(Console.ReadLine());

            }
            for (int i = num - 1; i >= 0; i--)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
