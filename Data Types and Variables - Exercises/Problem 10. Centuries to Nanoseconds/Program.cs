using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte input = byte.Parse(Console.ReadLine());
            int years = 100 * input;
            int days = (int)(years * 365.242199);
            int hours = days * 24;
            decimal minutes = hours * 60M;
            decimal seconds = minutes * 60M;
            decimal miliseconds = seconds * 1000M;
            decimal microseconds = miliseconds * 1000M;
            decimal nanoseconds = microseconds * 1000M;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
            input,
            years, 
            days,
            hours,
            minutes,
            seconds,
            miliseconds,
            microseconds,
            nanoseconds );   
        }
    }
}
