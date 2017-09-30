using System;


namespace _06.Miles_to_Kilometers
{
    class Program
    {
        static void Main()
        {
            var miles = double.Parse(Console.ReadLine());
            var kilometers = miles * 1.60934;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
