using System;


namespace _07.Beverage_Labels
{
    class Program
    {
        static void Main()
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());

            var kcal = (volume * energy) / 100;
            var gram = (volume * sugar) / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kcal}kcal, {gram}g sugars");

        }
    }
}
