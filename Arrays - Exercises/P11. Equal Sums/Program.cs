using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (input.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                leftSum = 0;
                for (int j = i; j > 0; j--)
                {
                    int next = j - 1;
                    if (j > 0 )
                    {
                        leftSum += input[next];
                    }
                }
                rightSum = 0;
                for (int right = i; right < input.Length; right++)
                {
                    int next = right + 1;
                    if (right < input.Length - 1)
                    {
                        rightSum += input[next];
                    }
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
