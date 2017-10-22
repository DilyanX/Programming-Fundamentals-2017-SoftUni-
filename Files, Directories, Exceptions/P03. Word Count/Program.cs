using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("D:\\C#\\Programming-Fundamentals-2017-SoftUni-\\Files, Directories, Exceptions\\P03. Word Count\\Input.txt").ToLower(); // файлът със целия текст
            string[] words = File.ReadAllText("D:\\C#\\Programming-Fundamentals-2017-SoftUni-\\Files, Directories, Exceptions\\P03. Word Count\\words.txt").ToLower().Split(' '); // думите които турсим за съответствие в lines..
            string[] lines = text
               .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' },
                StringSplitOptions.RemoveEmptyEntries); // файлът е вече само текст без разделители между думите 

            Dictionary<string, int> wordCount = new Dictionary<string, int>(); // words, value count

            foreach (var word in words)
            {
                wordCount[word] = 0;
            }
            foreach (var word in lines)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }
            wordCount.OrderByDescending(a => a.Value);

            foreach (var item in wordCount)
            {

            }
           
            Console.WriteLine(string.Join(" ", wordCount));
        }
    }
}
