using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            int maxCounter = 0;
            int number = 0;
            for (int i = 0; i < array.Length; i++)
            {

                for (int j = i; j < array.Length; j++)
                {

                    if (array[i] == array[j])
                    {
                        counter = counter + 1;
                    }
                    if (counter > maxCounter)
                    {
                        number = array[i];
                        maxCounter = counter;
                    }
                    else
                    {
                        counter = 0;

                    }
                }
            }
            Console.WriteLine(number);
        }
    }
}
