using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());

            var lastFirstNumber = 0;
            var lastSecondNumber = 0;
            int count = 0;

            bool isFound = false;

            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = startNum; j <= endNum; j++)
                {
                    if (i + j == magicNum)
                    {
                        lastFirstNumber = i;
                        lastSecondNumber = j;
                        isFound = true;
                    }
                    count++;
                }
            }
            if (isFound)
            {
                Console.WriteLine($"Number found! {lastFirstNumber} + {lastSecondNumber} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
        }
    }
}

//Write a program, which finds all possible combinations in the interval between two numbers.
//The program should also find the last combination, in which a number’s digits are equal to a given magical number.
//Output
//The output depends on the result:
//If there is a number with digits equal to the magical number:
//"Number found! {first number} + {second number} = {magical number}"
//If such combination does not exist:
//"Total combinations: {total number of combinations} – neither equals {magical number}"
//explonation
//    All combinations between 1 and 10 are: 1 1, 1 2, 1 3, 1 4, 1 5, ... 2 1, 2 2, ... 4 1, 4 2, 4 3 ... 10 9, 10 10. 
//    Last combination with sum of the digits equal to the magical number(5) is 4 1

