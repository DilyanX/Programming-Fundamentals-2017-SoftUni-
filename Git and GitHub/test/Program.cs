using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentNumber;
            currentNumber = int.Parse(Console.ReadLine());

            int max = int.MinValue;

            while (currentNumber != 0)
            {
                
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
                currentNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(max);
        }
        
    }
}
