using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            double perimeter = 2* (width + height);
            double area = width * height ;
            double diagonal = Math.Sqrt((width * width) + (height * height));

            Console.WriteLine("{0}\r\n{1}\r\n{2}",perimeter, area, diagonal);
        }
    }
}
