using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Fix_Emails
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, string> sequence = new Dictionary<string, string>(); //name , email(key,value)
            string email;
            string name = Console.ReadLine().Trim();


            while (name != "stop")
            {
                email = Console.ReadLine().Trim();

                if (sequence.ContainsKey(name))
                {
                    sequence[name] = name;
                }
                else
                {
                    sequence.Add(name, email);
                }

                name = Console.ReadLine();
            }

            foreach (var item in sequence)
            {
                if (!item.Value.EndsWith("bg"))
                {
                    sequence.Remove(item.Value);
                    sequence.Remove(item.Key);
                    break;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                }


            }
        }
    }
}