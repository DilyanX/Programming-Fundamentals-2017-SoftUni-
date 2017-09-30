using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            for (var row = 1; row <= input; row +=1)
            {
                for(var col = 0; col < row; col +=1)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
