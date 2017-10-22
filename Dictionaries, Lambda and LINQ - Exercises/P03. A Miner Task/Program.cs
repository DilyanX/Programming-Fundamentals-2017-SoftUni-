using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.A_Miner_Task
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> resource = new Dictionary<string, int>(); //material , quantity
            int quantity;
            string material = Console.ReadLine().Trim();


            while (material != "stop")
            {
                quantity = int.Parse(Console.ReadLine().Trim());

                if (resource.ContainsKey(material))
                {
                    resource[material] += quantity;
                }
                else
                {
                    resource.Add(material, quantity);
                }

                material = Console.ReadLine();
            }

            foreach (var item in resource)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}