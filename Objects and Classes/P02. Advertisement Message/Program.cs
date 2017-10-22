﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            string[] phrases = {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            for (int i = 0; i < input; i++)
            {
                int phraseIndex = random.Next(0, phrases.Length);
                int eventsIndex = random.Next(0, events.Length);
                int authorIndex = random.Next(0, author.Length);
                int citiesIndex = random.Next(0, cities.Length);

                Console.WriteLine(phrases[phraseIndex] + " " + events[eventsIndex] + " " + author[authorIndex] + " - " + cities[citiesIndex]);
            }
        }
    }
}

