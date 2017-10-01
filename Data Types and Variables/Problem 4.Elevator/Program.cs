using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)n / p);
            Console.WriteLine(courses);

        }
    }
}
//Calculate how many courses will be needed to elevate n persons by using an 
//elevator of capacity of p persons.The input holds two lines: the number 
//of people n and the capacity p of the elevator.