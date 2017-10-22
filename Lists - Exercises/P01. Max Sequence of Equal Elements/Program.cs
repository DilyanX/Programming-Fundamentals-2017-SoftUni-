using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();// чете числа от конзолата и ги вкарва в листа 
            List<int> result = new List<int>(); // създаваме нов лист за резултат
            List<int> bestSequence = new List<int>(); // създаваме нов лист за крайния резултат в който записваме най често повтарящите се числа
            int counter = 1;
            int maxCounter = 1;
            result.Add(num[0]);
            for (int i = 0; i < num.Count - 1; i++) // с фор цикъл обхождаме листата
            {
                if (num[i] == num[i + 1]) // сравняваме първият индекс  == на вторият индекс 
                {
                    counter++;   // увеличаваме коунтъра 
                    result.Add(num[i + 1]); // добавяме индексът който е равен да първия
                }
                else
                {
                    counter = 1;
                    result.Clear();
                    result.Add(num[i + 1]);
                }
                if (counter > maxCounter)
                {
                    bestSequence.Clear();
                    maxCounter = counter;
                    bestSequence.AddRange(result);
                }
            }
            if (maxCounter == 1)
            {
                Console.WriteLine(num[0]);
                return;
            }
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
