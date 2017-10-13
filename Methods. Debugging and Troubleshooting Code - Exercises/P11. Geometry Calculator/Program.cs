using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            switch (figure)
            {
                case "triangle":
                    double b = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", PrintTriangleArea(b, h));
                    break;
                case "square":
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", PrintSquareArea(a));
                    break;
                case "rectangle":
                    double w = double.Parse(Console.ReadLine());
                    double hRec = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", PrintRectangleArea(w, hRec));
                    break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", PrintCircleArea(r));
                    break;
            }
        }
        static double PrintTriangleArea(double b, double h)
        {
            return (b * h) / 2;
        }
        static double PrintSquareArea(double a)
        {
            return a * a;
        }
        static double PrintRectangleArea(double w, double hRec)
        {
            return w * hRec;
        }
        static double PrintCircleArea(double r)
        {
            return Math.PI * r * r;
        }
    }
}
//            string typeOfFigure = Console.ReadLine();
//            GetAreaOfFigures(typeOfFigure);
//        }
//        static void GetAreaOfFigures(string typeOfFigure)
//        {
//            double result = 0;
//            if (typeOfFigure == "triangle")
//            {
//                double side = double.Parse(Console.ReadLine());
//                double height = double.Parse(Console.ReadLine());
//                result = (side * height) / 2;
//                Console.WriteLine($"{result:F2}");
//            }
//            else if (typeOfFigure == "square")
//            {
//                double side = double.Parse(Console.ReadLine());
//                result = (side * side);
//                Console.WriteLine($"{result:F2}");
//            }
//            else if (typeOfFigure == "rectangle")
//            {
//                double width = double.Parse(Console.ReadLine());
//                double height = double.Parse(Console.ReadLine());
//                result = (width * height);
//                Console.WriteLine($"{result:F2}");
//            }
//            else if (typeOfFigure == "circle")
//            {
//                double radius = double.Parse(Console.ReadLine());
//                result = Math.PI * radius * radius;
//                Console.WriteLine($"{result:F2}");
//            }
//        }
//    }
//}
