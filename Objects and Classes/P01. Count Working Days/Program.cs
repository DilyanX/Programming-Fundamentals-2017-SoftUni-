using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] officialHollidays = new DateTime[11];

            officialHollidays[0] = new DateTime(4, 01, 01);
            officialHollidays[1] = new DateTime(4, 03, 03);
            officialHollidays[2] = new DateTime(4, 05, 01);
            officialHollidays[3] = new DateTime(4, 05, 06);
            officialHollidays[4] = new DateTime(4, 05, 24);
            officialHollidays[5] = new DateTime(4, 09, 06);
            officialHollidays[6] = new DateTime(4, 09, 22);
            officialHollidays[7] = new DateTime(4, 11, 01);
            officialHollidays[8] = new DateTime(4, 12, 24);
            officialHollidays[9] = new DateTime(4, 12, 25);
            officialHollidays[10] = new DateTime(4, 12, 26);

            int workingDayCounter = 0;

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1)) // обхожда началната дата до крайната дата и пвзема общия брой дни между тях
            {
                DayOfWeek day = i.DayOfWeek;

                DateTime temp = new DateTime(4, i.Month, i.Day);

                if (!officialHollidays.Contains(temp) && (!day.Equals(DayOfWeek.Saturday) && !day.Equals(DayOfWeek.Sunday)))
                {
                    workingDayCounter++;
                }
            }
            Console.WriteLine(workingDayCounter);
        }
    }
}

