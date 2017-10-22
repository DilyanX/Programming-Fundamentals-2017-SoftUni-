using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            var phonebook = new Dictionary<string, string>();

            while (line[0] != "END")
            {

                var command = line[0];
                var name = line[1];

                if (command == "A")
                {
                    var number = line[2];
                    if (phonebook.ContainsKey(name))
                    {
                        phonebook.Remove(name);
                    }
                    phonebook.Add(name, number);

                }
                else if (command == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }

                }
                line = Console.ReadLine().Split();
            }
        }
    }
}