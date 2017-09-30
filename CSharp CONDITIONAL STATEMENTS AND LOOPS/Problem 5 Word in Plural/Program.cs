using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (input.EndsWith("y"))
            {
              input = input.Remove(input.Length - 1);
                Console.WriteLine(input + "ies");
            }
            else if (input.EndsWith("o") || input.EndsWith("ch") || input.EndsWith("s") || input.EndsWith("sh") || input.EndsWith("x") || input.EndsWith("z"))
            {
                Console.WriteLine(input + "es");
            }
            else
            {
                Console.WriteLine(input + "s");
            }
        }
    }
}
