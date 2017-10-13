using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            List<string> items = inputLine.Split(' ').ToList();
            List<int> squares = new List<int>();

            foreach (var item in items)
            {
                int number = int.Parse(item);

                double root = Math.Sqrt(number);
                double rootAsInt = (int)root;
                if (root == rootAsInt)
                {
                    squares.Add(number);
                }
            }
            squares.Sort();
            for (int i = squares.Count; i >= 0; i--)
            {
                Console.Write(squares[i] + " ");
            }
        }
    }
}
