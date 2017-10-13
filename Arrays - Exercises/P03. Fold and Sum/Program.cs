using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] arrFoldA = new int[arr.Length / 2];
            int[] arrFoldB = new int[arr.Length / 2];

            int n = 0;
            for (int i = arr.Length / 4 - 1; i >= 0; i--)       // взема първите числа от масива и ги разменя
            {
                arrFoldA[n] = arr[i];
                n++;
            }

            n = arr.Length / 2 - 1;
            for (int i = arr.Length - arr.Length / 4; i < arr.Length; i++) // взема последните числа от масива и ги разменя
            {
                arrFoldA[n] = arr[i];
                n--;
            }

            n = 0;
            int start = arr.Length / 4;
            int end = arr.Length - arr.Length / 4;
            for (int i = start; i < end; i++)
            {
                arrFoldB[n] = arr[i];
                n++;
            }
            //  Console.WriteLine(string.Join(string.Empty, arrFoldA));

            int[] sum = new int[arrFoldA.Length];
            for (int i = 0; i < arrFoldA.Length; i++)
            {
                sum[i] = arrFoldA[i] + arrFoldB[i];
            }
            Console.WriteLine(string.Join(" ", sum));

            // Console.WriteLine(string.Join(string.Empty, arrFoldA));
            // Console.WriteLine(string.Join(string.Empty, arrFoldB));
        }
    }
}