using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> sequenceLogs = new SortedDictionary<string, SortedDictionary<string, int>>();
            var input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string[] contain = Console.ReadLine().Split(' ');
                string ip = contain[0];
                string name = contain[1];
                int duration = int.Parse(contain[2]);
                

                if (!sequenceLogs.ContainsKey(name))
                {
                    sequenceLogs.Add(name, new SortedDictionary<string, int>());
                  
                }
                if (!sequenceLogs[name].ContainsKey(ip))
                {
                    sequenceLogs[name][ip] = 0;
                }

                sequenceLogs[name][ip] += duration;
            }
            
            foreach (var item in sequenceLogs)
            {
                var sum = item.Value.Values.Sum();

                Console.Write("{0}: {1} ", item.Key, sum);
                Console.Write("[");
                Console.Write(string.Join(", ", item.Value.Keys));
                Console.WriteLine("]");
            }
        }
    }
}
