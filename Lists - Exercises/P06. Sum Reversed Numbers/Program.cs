using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;

            for (int i = 0; i < input.Count; i++) // обхождам елементите на листът
            {
                int rev = 0;

                while (input[i] > 0) // алгоритъм за обръщане(reverse) , на елементите
                {
                    int reverse = input[i] % 10;
                    rev = rev * 10 + reverse;
                    input[i] = input[i] / 10;
                }
                sum += rev;
            }
           
            Console.WriteLine(sum);

            //var numbers = Console.ReadLine().Split(' ').ToList();
            //List<int> reversedNumbers = new List<int>();

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    string eachElement = numbers[i];
            //    char[] element = eachElement.ToCharArray();
            //    char[] reversed = element.Reverse().ToArray();
            //    reversedNumbers.Add(int.Parse(string.Join("", reversed)));
            //}
            //Console.WriteLine(reversedNumbers.Sum());
        }
    }
}
