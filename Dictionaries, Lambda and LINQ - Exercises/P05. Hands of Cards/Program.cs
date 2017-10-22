using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
                    //playerName     //playerCard
            Dictionary<string, HashSet<string>> personHands = new Dictionary<string, HashSet<string>>();
            var input = Console.ReadLine();


            while (input != "JOKER")
            {
                var arr = input.Split(':');
                var playerName = arr[0].Trim();
                var playerCards = arr[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!personHands.ContainsKey(playerName))
                {
                    personHands.Add(playerName, new HashSet<string>());
                }

                foreach (var card in playerCards)
                {
                    personHands[playerName].Add(card);
                }
                input = Console.ReadLine();

            }

            foreach (var nameAndList in personHands)
            {
                string nameOfPerson = nameAndList.Key;

                double result = 0;
                double valueOfTheCards = 0;
                double typeOfCards = 0;
                foreach (var hands in nameAndList.Value)
                {
                    string power = hands.Remove(hands.Length - 1, 1);
                    switch (power)
                    {
                        case "2": valueOfTheCards = 2; break;
                        case "3": valueOfTheCards = 3; break;
                        case "4": valueOfTheCards = 4; break;
                        case "5": valueOfTheCards = 5; break;
                        case "6": valueOfTheCards = 6; break;
                        case "7": valueOfTheCards = 7; break;
                        case "8": valueOfTheCards = 8; break;
                        case "9": valueOfTheCards = 9; break;
                        case "10": valueOfTheCards = 10; break;
                        case "J": valueOfTheCards = 11; break;
                        case "Q": valueOfTheCards = 12; break;
                        case "K": valueOfTheCards = 13; break;
                        case "A": valueOfTheCards = 14; break;
                    }

                    char lastLetter = hands[hands.Length - 1];

                    switch (lastLetter)
                    {
                        case 'C': typeOfCards = 1; break;
                        case 'D': typeOfCards = 2; break;
                        case 'H': typeOfCards = 3; break;
                        case 'S': typeOfCards = 4; break;
                    }

                    result += valueOfTheCards * typeOfCards;
                }
                Console.WriteLine($"{nameOfPerson}: {result}");
            }
        }
    }
}
