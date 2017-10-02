using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            
            float timePerSec = (hours * 3600) + (minutes * 60) + seconds;
            float mps = distance / timePerSec; ;
            float kmph = (distance / 1000.0f) / (timePerSec / 3600.0f);
            float mph = kmph / 1.609f;

            Console.WriteLine(mps);
            Console.WriteLine(kmph);
            Console.WriteLine(mph);
        }
    }
}
//Create a program to ask the user for a distance(in meters) and the time taken
//(as three numbers: hours, minutes, seconds), and print the speed, in meters per second,
//kilometers per hour and miles per hour.
//Assume 1 mile = 1609 meters.
//Every number in the output should be precise up to 6 digits after the floating point
//⦁	On first line – speed in meters per second(m/s)
//⦁	On second line – speed in kilometers per hour(km/h)
//⦁	On third line – speed in miles per hour(mp/h)
