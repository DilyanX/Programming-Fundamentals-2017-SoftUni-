using System;


namespace Problem_3.Restaurant_Discount
{
    class Program
    {
        static void Main()
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            double tottal = 0;
            double discount = 0;
            double pricePerPerson = 0;

            if (groupSize > 0 && groupSize <= 50 )
            {
                Console.WriteLine("We can offer you the Small Hall");
                if (package == "Gold")
                {
                    tottal = (2500 + 750);
                    discount = tottal * 0.1;
                    pricePerPerson = (tottal - discount) / groupSize;
                }
      
                else if (package == "Platinum")
                {
                    tottal = (2500 + 1000);
                    discount = tottal * 0.15;
                    pricePerPerson = (tottal - discount) / groupSize;
                }
                else if (package == "Normal")
                {
                    tottal = (2500 + 500);
                    discount = tottal * 0.05;
                    pricePerPerson = (tottal - discount) / groupSize;
                }
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                if (package == "Gold")
                {
                    tottal = (5000 + 750);
                    discount = tottal * 0.1;
                    pricePerPerson = (tottal - discount) / groupSize;
                }
                else if (package == "Platinum")
                {
                    tottal = (5000 + 1000);
                    discount = tottal * 0.15;
                    pricePerPerson = (tottal - discount) / groupSize;
                }
                else if (package == "Normal")
                {
                    tottal = (5000 + 500);
                    discount = tottal * 0.05;
                    pricePerPerson = (tottal - discount) / groupSize;
                }
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                if (package == "Gold")
                {
                    tottal = (7500 + 750);
                    discount = tottal * 0.1;
                    pricePerPerson = (tottal - discount) / groupSize;
                }
                else if (package == "Platinum")
                {
                    tottal = (7500 + 1000);
                    discount = tottal * 0.15;
                    pricePerPerson = (tottal - discount) / groupSize;
                }
                else if (package == "Normal")
                {
                    tottal = (7500 + 500);
                    discount = tottal * 0.05;
                    pricePerPerson = (tottal - discount) / groupSize;
                }
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
