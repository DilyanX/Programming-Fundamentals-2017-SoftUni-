using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPictures = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double goodForUpload = double.Parse(Console.ReadLine());
            double timeForUpload = double.Parse(Console.ReadLine());

            double filteredPictures = (goodForUpload / 100) * totalPictures; 
            filteredPictures = Math.Ceiling(filteredPictures);

            double time = totalPictures * filterTime;
            double uploadTime = timeForUpload * filteredPictures;
            double total = time + uploadTime;

            TimeSpan t = TimeSpan.FromSeconds(total); 
            string answer = string.Format("{0}:{1:D2}:{2:D2}:{3:D2}",
                t.Days,
                t.Hours,
                t.Minutes,
                t.Seconds);
            Console.WriteLine(answer);
            // time format d:HH:mm:ss
        }
    }
}
