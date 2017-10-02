using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());

            double difference = 0.000001;
            if (Math.Abs(numA - numB) <= difference)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}

//Write a program that flosafely compares ating-point numbers(double) 
//with precision eps = 0.000001. Note that we cannot directly compare two floating-point
//numbers a and b by a==b because of the nature of the floating-point arithmetic.
//Therefore, we assume two numbers are equal if they are more closely to each other than some fixed constant eps. 
//You will receive two lines, each containing a floating-point number. Your task is to compare the values of the two numbers.
