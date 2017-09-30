using System;


namespace _08.Character_Stats
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
            Console.Write("Health: ");
            for (int i = 0; i < health + 1; i++)
            {
                Console.Write("|");
            }
            for (int j = 0; j < maxHealth - health; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");

            Console.Write("Energy: ");
            for (int l = 0; l < energy + 1; l++)
            {
                Console.Write("|");
            }
            for (int k = 0; k < maxEnergy - energy; k++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");
        }
    }
}
