using System;


namespace _09.Character_Stats_Second
{
    class Program
    {
        static void Main()
        {
            var name = Console.ReadLine();
            var health = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");

        }
    }
}
