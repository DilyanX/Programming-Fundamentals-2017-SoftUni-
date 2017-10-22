using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        static void Main(string[] args)
        {

            string[] value = Console.ReadLine().Split();
            Point p = new Point
            {
                X = int.Parse(value[0]),
                Y = int.Parse(value[1])
            };

            string[] value2 = Console.ReadLine().Split();
            Point p2 = new Point
            {
                X = int.Parse(value[0]),
                Y = int.Parse(value[1])
            };

           
        }
    }
}
