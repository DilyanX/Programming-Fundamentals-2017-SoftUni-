using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 1; i < inputLine.Count ; i++)
            {
                if (inputLine[i] == inputLine[i - 1]) // сравняваме индексите дали са равни
                {
                    inputLine[i] = inputLine[i] + inputLine[i - 1];
                    inputLine.Remove(inputLine[i - 1]);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", inputLine));
        }
    }
}
