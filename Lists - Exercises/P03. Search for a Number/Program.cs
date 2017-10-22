using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var second = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = first.Take(second[0]).ToList();
            result.RemoveRange(0, second[1]);

            if (result.Contains(second[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}

