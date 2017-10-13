using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double  side = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            FindingCubeProperties(side, input);
        }
        static void FindingCubeProperties(double side, string input)
        {
            double result = 0;
            if (input == "face")
            {
                result = Math.Sqrt((2 * (Math.Pow(side,2))));
                
                Console.WriteLine($"{result:F2}");
            }
            else if (input == "volume")
            {
                result = Math.Pow(side, 3);
                Console.WriteLine($"{result:F2}");
            }
            else if (input == "area")
            {
                result = Math.Pow(side, 2) * 6;
                Console.WriteLine($"{result:F2}");
            }
            else if (input == "space")
            {
                result = Math.Sqrt((3 * (Math.Pow(side, 2))));
                Console.WriteLine($"{result:F2}");
            }
           
        }
    }
}
