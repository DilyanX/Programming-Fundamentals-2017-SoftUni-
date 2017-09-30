using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoDmg = int.Parse(Console.ReadLine());
            var goshoDmg = int.Parse(Console.ReadLine());

            int goshoHealth = 100;
            int peshoHealth = 100;

            int round = 0;

            while (peshoHealth > 0 && goshoHealth > 0)
            {
                round++;
                if (round % 2 != 0)
                {
                    goshoHealth -= peshoDmg;
                    if (goshoHealth < 1)
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else
                {
                    peshoHealth -= goshoDmg;
                    if (peshoHealth < 1)
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
                    if (round % 3 == 0)
                    {
                        peshoHealth += 10;
                        goshoHealth += 10;
                    }
                }
            }
        }
    }

