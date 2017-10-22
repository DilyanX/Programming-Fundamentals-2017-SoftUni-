using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("C: \\Users\\Dilyan\\Desktop\\Examples.txt");
            List<string> output = new List<string>();
            for (int i = 1; i < text.Length; i += 2)
            {
                output.Add(text[i]);
            }
            File.WriteAllLines("C:\\Users\\Dilyan\\Desktop\\output.txt", output);
            Console.WriteLine(string.Join(" \n", output));
        }
    }
}
