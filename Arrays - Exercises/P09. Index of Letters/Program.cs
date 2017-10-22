using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            char[] arr = input.ToCharArray();

            for (int i = 0; i < input.Length ; i++)
            {
               for (int j = 0; j  < alphabet.Length; j ++)
                {
                    if (input[i] == alphabet[j])
                    {
                        Console.WriteLine("{0} -> {1}", input[i], j);
                    }
                }
            }
         }
    }
}
//if (input[i].ToString().Contains(alphabet[j]))
//{
//    Console.WriteLine("{0} -> {1}", input[i], j);
//}