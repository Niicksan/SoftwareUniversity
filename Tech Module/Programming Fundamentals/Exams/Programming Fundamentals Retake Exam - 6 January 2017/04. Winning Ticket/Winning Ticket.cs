using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Regex.Split(Console.ReadLine(), @"\s*,\s+");
            Dictionary<string, string> ticketsAndAwards = new Dictionary<string, string>();

            string winnerPattern = @"[@]{6,9}|[#]{6,9}|[$]{6,9}|[\^]{6,9}";
            string jackpotPattern = @"[@]{10}|[#]{10}|[$]{10}|[\^]{10}";

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    ticketsAndAwards.Add(ticket, "invalid ticket");
                    continue;
                }

                string leftPart = new string(ticket.Take(10).ToArray());
                string rightPart = new string(ticket.Skip(10).ToArray());

                Match jackpodLeft = Regex.Match(leftPart, jackpotPattern);
                Match jackpodRight = Regex.Match(rightPart, jackpotPattern);

                Match winnerLeft = Regex.Match(leftPart, winnerPattern);
                Match winnerRight = Regex.Match(rightPart, winnerPattern);

                if (jackpodLeft.Success && jackpodRight.Success && jackpodLeft.ToString()[0].Equals(jackpodRight.ToString()[0]))
                {
                    char winningSymbol = jackpodLeft.ToString()[0];

                    ticketsAndAwards.Add(ticket, $"10{winningSymbol} Jackpot!");
                }
                else if (winnerLeft.Success && winnerRight.Success && winnerLeft.ToString()[0].Equals(winnerRight.ToString()[0]))
                {
                    char winningSymbol = winnerLeft.ToString()[0];
                    int prize = Math.Min(winnerLeft.Length, winnerRight.Length);

                    ticketsAndAwards.Add(ticket, prize.ToString() + winningSymbol);
                }
                else
                {
                    ticketsAndAwards.Add(ticket, "no match");
                }
            }

            foreach (var ticket in ticketsAndAwards)
            {
                if (ticket.Value.Equals("invalid ticket"))
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket.Key}\" - {ticket.Value}");
                }
            }
        }
    }
}
