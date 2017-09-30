using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var skipLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        string current = "" + i + j + k; // трик за стринг
                        if (!current.Contains(skipLetter + ""))
                        {
                            Console.Write(current + " ");
                        }
                    }
                }
            }
        }
    }
}

//Write a program, which prints all 3-letter combinations, using only the letters from a given interval.
//You will also receive a third letter. Every combination, which contains this letter should not be printed.
//Input
//The input is read from the console and consists three lines: 
