using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("C: \\Users\\Dilyan\\Desktop\\Examples.txt");
            string[] output = new string[text.Length];

            for (int i = 0; i < output.Length; i++)
            {
             output[i] = (i + 1) + ". "+ text[i];
            }
            File.WriteAllLines("C:\\Users\\Dilyan\\Desktop\\output.txt",output);
            Console.WriteLine(string.Join(" \n", output));
        }
    }
}
