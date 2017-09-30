using System;


namespace Problem_2.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main()
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (profession == "Athlete")
            {
                totalPrice = quantity * 0.70;
                Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                totalPrice = quantity * 1.00;
                Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                totalPrice = quantity * 1.70;
                Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
            }
            else
            {
                totalPrice = quantity * 1.20;
                Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
            }
        }
    }
}
