using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();


            if (arr1.Length > arr2.Length)
            {
                Console.WriteLine("{0}\n{1}", string.Join("", arr1), string.Join("", arr2));
            }
            else if (arr1.Length < arr2.Length)
            {
                Console.WriteLine("{0}\n{1}", string.Join("", arr2), string.Join("", arr1));
            }
            else if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
                {
                    if (arr1[i] > arr2[i])
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", arr2), string.Join("", arr1));
                        break;
                    }
                    if (arr2[i] > arr1[i])
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", arr1), string.Join("", arr2));
                        break;
                    }
                    if (arr2[i] == arr1[i] && i == Math.Min(arr1.Length, arr2.Length) - 1)
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", arr1), string.Join("", arr2));
                        break;
                    }


                }

            }
        }
    }
}
