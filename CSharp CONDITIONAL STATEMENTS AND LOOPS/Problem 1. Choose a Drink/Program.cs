using System;


namespace Problem_1.Choose_a_Drink
{
    class Program
    {
        static void Main()
        {
            var profession = Console.ReadLine();

            if (profession ==  "Athlete")
            {
                Console.WriteLine("Water");
            }
            if (profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            if (profession == "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            if (profession != "Athlete" && profession != "Businessman" && profession != "Businesswoman" && profession != "SoftUni Student")
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
//Write a program, which receives a profession(as a string) and chooses the perfect drink for the person.The possible combinations are: 
//“Water” – for “Athlete”
//“Coffee” – for “Businessman” or “Businesswoman”
//“Beer” – for “SoftUni Student”
//“Tea” – for all other professions.
//Examples
//Input   Output Input   Output
//Athlete Water Doctor  Tea
