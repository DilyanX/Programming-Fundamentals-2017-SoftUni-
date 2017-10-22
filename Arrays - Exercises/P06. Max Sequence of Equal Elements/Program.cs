using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int maxCounter = 1;
            int bestSequence = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
             
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    bestSequence = input[i];
                }
            }
            for (int i = 0; i < maxCounter; i++) // обхождаме елементите които са се събрали в макскаунтър
            {
                Console.Write("{0} ", bestSequence);
            }
        }
    }
}
