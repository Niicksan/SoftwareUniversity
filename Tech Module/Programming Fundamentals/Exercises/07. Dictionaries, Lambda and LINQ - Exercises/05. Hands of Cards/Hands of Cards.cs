using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> handsOfCards = new Dictionary<string, int>();
            Dictionary<string, List<string>> cardsValue = new Dictionary<string, List<string>();
            while (input != "JOKER")
            {
                string[] personAndCards = input.Split(new string[] { ": ", ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = personAndCards[0];

                List<string> cards = new List<string>();

                for (int i = 1; i < personAndCards.Length; i++)
                {
                    cards.Add(personAndCards[i]);
                }

                int sum = NewMethod(personAndCards, cards);

                cardsValue.Add(name, cards);

                input = Console.ReadLine();
            }

        }

        private static int NewMethod(string[] personAndCards, List<string> cards)
        {
            for (int i = 1; i < personAndCards.Length; i++)
            {
                cards.Add(personAndCards[i]);
            }

            int sum = 0;
            for (int i = 0; i < cards.Count; i++)
            {
                string card = cards[i];
                char firstLetter = card[0];
                char secondLetter = card[1];

                int power = 0;
                int type = 0;
                if (int.TryParse(firstLetter.ToString(), out power))
                {
                    switch (secondLetter)
                    {
                        case 'C':
                            type = 1;
                            break;
                        case 'D':
                            type = 2;
                            break;
                        case 'H':
                            type = 3;
                            break;
                        case 'S':
                            type = 4;
                            break;
                    }
                }
                else
                {
                    switch (firstLetter)
                    {
                        case 'J':
                            power = 11;
                            break;
                        case 'Q':
                            power = 12;
                            break;
                        case 'K':
                            power = 13;
                            break;
                        case 'A':
                            power = 14;
                            break;
                        default:
                            power = 10;
                            break;
                    }

                    switch (secondLetter)
                    {
                        case 'C':
                            type = 1;
                            break;
                        case 'D':
                            type = 2;
                            break;
                        case 'H':
                            type = 3;
                            break;
                        case 'S':
                            type = 4;
                            break;
                    }

                }

                sum += power * type;
            }

            return sum;
        }
    }
}
