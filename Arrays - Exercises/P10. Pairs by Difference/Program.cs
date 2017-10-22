using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < input.Length; i += 1)
            {
                for (int j = i + 1 ; j < input.Length ; j += 1)
                {
                    
                    if (Math.Abs(input[i] - input[j]) == difference)
                    {
                        counter += 1;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
