using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Regeh
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> firstPlayerAllCards = new Queue<string>(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            Queue<string> secondPlayerAllCards = new Queue<string>(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            int turnsCounter = 0;
            bool gameOver = false;

            while (!gameOver && turnsCounter < 1000000 && firstPlayerAllCards.Count != 0 && secondPlayerAllCards.Count != 0)
            {
                turnsCounter++;

                string firstPlayerCard = firstPlayerAllCards.Dequeue();
                string secondPlayerCard = secondPlayerAllCards.Dequeue();

                int firstValue = GetNumberValue(firstPlayerCard);
                int secondValue = GetNumberValue(secondPlayerCard);

                if (firstValue > secondValue)
                {
                    firstPlayerAllCards.Enqueue(firstPlayerCard);
                    firstPlayerAllCards.Enqueue(secondPlayerCard);
                }
                else if (secondValue > firstValue)
                {
                    secondPlayerAllCards.Enqueue(secondPlayerCard);
                    secondPlayerAllCards.Enqueue(firstPlayerCard);
                }
                else
                {
                    List<string> winnerHand = new List<string> { firstPlayerCard, secondPlayerCard };

                    while (!gameOver)
                    {
                        if (firstPlayerAllCards.Count < 3 || secondPlayerAllCards.Count < 3)
                        {
                            gameOver = true;
                            break;
                        }

                        int firstSum = 0;
                        int secondSum = 0;

                        for (int i = 0; i < 3; i++)
                        {
                            firstSum += GetCharValue(firstPlayerAllCards.Peek());
                            secondSum += GetCharValue(secondPlayerAllCards.Peek());

                            winnerHand.Add(firstPlayerAllCards.Dequeue());
                            winnerHand.Add(secondPlayerAllCards.Dequeue());
                        }

                        if (firstSum > secondSum)
                        {
                            foreach (var card in winnerHand.OrderByDescending(x => GetNumberValue(x)).ThenByDescending(x => GetCharValue(x)))
                            {
                                firstPlayerAllCards.Enqueue(card);
                            }
                            break;
                        }
                        else if (secondSum > firstSum)
                        {
                            foreach (var card in winnerHand.OrderByDescending(x => GetNumberValue(x)).ThenByDescending(x => GetCharValue(x)))
                            {
                                secondPlayerAllCards.Enqueue(card);
                            }
                            break;
                        }
                    }
                }
            }

            string winner = GetWinner(firstPlayerAllCards, secondPlayerAllCards);
            Console.WriteLine($"{winner} after {turnsCounter} turns");
        }

        private static string GetWinner(Queue<string> firstPlayerAllCards, Queue<string> secondPlayerAllCards)
        {
            if (firstPlayerAllCards.Count > secondPlayerAllCards.Count)
            {
                return "First player wins";
            }
            if (secondPlayerAllCards.Count > firstPlayerAllCards.Count)
            {
                return "Second player wins";
            }
            else
            {
                return "Draw";
            }
        }

        private static int GetCharValue(string card)
        {
            return card.Last();
        }

        private static int GetNumberValue(string playerCard)
        {
            return int.Parse(playerCard.Substring(0, playerCard.Length - 1));
        }
    }
}