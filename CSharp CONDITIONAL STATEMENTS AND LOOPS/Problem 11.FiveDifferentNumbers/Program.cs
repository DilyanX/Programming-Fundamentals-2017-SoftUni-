using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.FiveDifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numA = int.Parse(Console.ReadLine());
            var numB = int.Parse(Console.ReadLine());
            int noNumber = 0;
            for (int n1 = numA; n1 <= numB; n1 += 1)
            {
                for (int n2 = numA; n2 <= numB; n2 += 1)
                {
                    for (int n3 = numA; n3 <= numB; n3 +=1)
                    {
                        for (int n4 = numA; n4 <= numB; n4 += 1)
                        {
                            for (int n5 = numA; n5 <= numB; n5 +=1)
                            {
                                if (numA <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= numB)
                                {
                                    Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                    noNumber++;
                                }                              
                            }
                        }
                    }
                } 
            }
            if (noNumber == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
//You will be given two numbers – a and b.Generate five numbers - n1, n2, n3, n4, n5, for which the following conditions are true:
//a ≤ n1<n2<n3<n4 ≤ n5 ≤ b.If there is no number in the given interval, which satisfies the conditions – print “No”.
//Input
//The input contains two integers, each on a new line.
//Output
//Print all numbers in increasing order and on a new line.
