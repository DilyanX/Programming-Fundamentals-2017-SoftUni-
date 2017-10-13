using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>(inputLine);
        }
    }
}
