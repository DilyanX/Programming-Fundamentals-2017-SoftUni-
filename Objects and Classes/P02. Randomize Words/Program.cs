using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int possition = random.Next(0, input.Length);
                int secondPossition = random.Next(0, input.Length);

                string oldFirst = input[possition];
                input[possition] = input[secondPossition];
                input[secondPossition] = oldFirst;
            }
            Console.WriteLine(string.Join(Environment.NewLine, input));

        }
    }
}
