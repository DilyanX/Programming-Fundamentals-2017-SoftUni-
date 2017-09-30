using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string ingridient;
            int totalAmount = 0;
            for (int i = 0; i < input; i++)
            {
                ingridient = Console.ReadLine().ToLower();
                if (ingridient == "tomato sauce")
                {
                    totalAmount = totalAmount + 150;
                }
                if (ingridient == "cheese")
                {
                    totalAmount = totalAmount + 500;
                }
                if (ingridient == "salami")
                {
                    totalAmount = totalAmount + 600;
                }
                if (ingridient == "pepper")
                {
                    totalAmount = totalAmount + 50;
                }
            }
            Console.WriteLine($"Total calories: {totalAmount}");
        }
    }
}
