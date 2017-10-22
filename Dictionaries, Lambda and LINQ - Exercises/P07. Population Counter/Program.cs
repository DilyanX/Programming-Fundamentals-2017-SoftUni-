using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] parameters = input.Split('|');
                string city = parameters[0]; 
                string country = parameters[1];
                long population = long.Parse(parameters[2]); //  парсва ми(преобразува) стринг към лонг

                if (!countries.ContainsKey(country)) // стандартен начин за добавяне на елементи в речник
                {
                    countries.Add(country, new Dictionary<string, long>()); //key = country , value инициализираме Dictuanary с new
                    countries[country].Add(city,population); // добавяме градът в Конкретния ключ
                }
                else
                {
                    if (!countries[country].ContainsKey(city)) // ако не съществува градът в Речникът
                    {
                        countries[country].Add(city, population);// добавяме градът 
                    }
                }
                input = Console.ReadLine();
            }
        //    countries = countries.OrderByDescending(n => n.Value.Values.Sum()) // сортираме Речникът като го запазаваме в променлива
         //       .ToDictionary(x => x.Key, x => x.Value); // терминираме го с ToList или ТоDictionary - за да работи.

            foreach (var country in countries.OrderByDescending(n => n.Value.Values.Sum())) //по адекватно от горното записване
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                } 
            }
           
        }
    }
}
