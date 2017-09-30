using System;


namespace _05.Rectangle_Area
{
    class Program
    {
        static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = width * height;
            Console.WriteLine($"{area:F2}");
        }
    }
}
