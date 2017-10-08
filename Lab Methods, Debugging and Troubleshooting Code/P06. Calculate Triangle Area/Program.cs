﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseT = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            CalculateTriangleArea(baseT , height);
        }

        static void CalculateTriangleArea(double baseT, double height)
        {
            double area = (baseT / 2) * height;
            Console.WriteLine(area);
        }

    }
}