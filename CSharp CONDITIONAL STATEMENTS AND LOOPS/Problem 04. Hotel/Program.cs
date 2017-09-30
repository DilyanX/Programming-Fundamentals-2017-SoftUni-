using System;

namespace Problem_4.Hotel
{
    class Program
    {
        static void Main()
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;
            double price = 0;
            double tottal = 0;


            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;

                if (nights > 7)
                {
                    price = studioPrice * 0.05;
                    tottal = studioPrice - price;
                    studioPrice = tottal;
                }
             
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;

                if (nights > 14)
                {
                    price = doublePrice * 0.1;
                    tottal = doublePrice - price;
                    doublePrice = tottal;
                }

            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;
                if (nights > 14)
                {
                    price = (suitePrice * 0.15);
                    tottal = suitePrice - price;
                    suitePrice = tottal;
                }
            }

            var tottalStudioPrice = studioPrice * nights;
            var tottalDoublePrice = doublePrice * nights;
            var tottalSuitePrice = suitePrice * nights;


            if ((month == "September" || month == "October") && nights > 7)
            {
                tottalStudioPrice -= studioPrice;
            }
       
            Console.WriteLine($"Studio: {tottalStudioPrice:F2} lv.");
            Console.WriteLine($"Double: {tottalDoublePrice:F2} lv.");
            Console.WriteLine($"Suite: {tottalSuitePrice:F2} lv.");
        }
    }
}
