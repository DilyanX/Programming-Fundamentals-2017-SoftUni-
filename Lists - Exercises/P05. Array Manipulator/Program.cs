using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var input = Console.ReadLine();
            var resultContains = 0;
            var elementNotFound = 0;

            while (true)
            {
                input = Console.ReadLine();
                var commands = input.Split().ToList();

                switch (commands[0])
                {
                    case "add":
                        int index = int.Parse(commands[1]);
                        int element = int.Parse(commands[2]);
                        list.Insert(index, element);
                        //Console.WriteLine("[" + String.Join(", ", list) + "]");
                        break;

                    case "addMany":
                        var indexOfElement = int.Parse(commands[1]);
                        var numbersToAdd = commands.Skip(2).Select(int.Parse).ToList();
                        list.InsertRange(indexOfElement, numbersToAdd);
                        //Console.WriteLine("[" + String.Join(", ", list) + "]");
                        break;

                    case "contains":

                        int index1 = int.Parse(commands[1]);
                        if (list.Contains(index1))
                        {
                            resultContains = list.IndexOf(index1);
                            Console.WriteLine(resultContains);
                        }
                        else
                        {
                            elementNotFound = -1;
                            Console.WriteLine(elementNotFound);
                        }
                        break;

                    case "remove":
                        int indexForRemoving = int.Parse(commands[1]);
                        list.RemoveAt(indexForRemoving);
                        //Console.WriteLine("[" + String.Join(", ", list) + "]");
                        break;

                    case "shift":
                        int position = int.Parse(commands[1]);
                        var rem = list.Take(position).ToList();
                        list.RemoveRange(0 , position);
                        list.AddRange(rem);
                     
                        //Console.WriteLine("[" + String.Join(", ", list) + "]");
                        break;

                    case "sumPairs":
                        for (int i = 0; i < list.Count; i++)
                        {
                            int currSum = list[i] + list[i + 1];
                            list.RemoveAt(i + 1);
                            list.RemoveAt(i);
                            list.Insert(i, currSum);
                        }
                        //Console.WriteLine("[" + String.Join(", ", list) + "]");
                        break;

                    case "print":
                        Console.WriteLine("[" + String.Join(", ", list) + "]");
                        return;
                }
            }
        }
    }
}
