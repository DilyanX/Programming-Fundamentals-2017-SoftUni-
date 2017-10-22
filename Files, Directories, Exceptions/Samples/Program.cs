using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("C: \\Users\\Dilyan\\Desktop\\mentori.txt");
            string[] lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = i + " " + lines[i];
            }
            foreach (var item in lines)
            {
                Console.WriteLine(lines);
            }
        }
    }
}
//четене на текстови файлове 

// File.ReadAllText("някакъв файл или път към директория");
// string[] lines = File.ReadAllLines("file.txt");

    // писане на текстови файлове

    
