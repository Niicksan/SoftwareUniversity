using System;

namespace _01._Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double teamTechnical = 0;
            double teamTheoretical = 0;
            double teamPractical = 0;

            string winTeam = "";

            for (int i = 1; i <= n; i++)
            {
                int distance = int.Parse(Console.ReadLine());
                double cargo = double.Parse(Console.ReadLine());
                string team = Console.ReadLine();

                double fuelExpenses = 0.7 * (distance * 1600) * 2.5;
                double cargoIncome = 1.5 * (cargo * 1000);
                double participantEarnedMoney = cargoIncome - fuelExpenses;

                if (team == "Technical")
                {
                    teamTechnical += participantEarnedMoney;
                }
                else if (team == "Theoretical")
                {
                    teamTheoretical += participantEarnedMoney;
                }
                else if (team == "Practical")
                {
                    teamPractical += participantEarnedMoney;
                }
            }

            double win = 0;
            double winner = 0;
            if (teamPractical > teamTheoretical)
            {
                winTeam = "Practical Trainers";
                winner = teamPractical;
                win = Math.Max(teamPractical, teamTheoretical);
            }
            else
            {
                winTeam = "Theoretical Trainers";
                winner = teamTheoretical;
                win = Math.Max(teamPractical, teamTheoretical);
            }

            if (win < teamTechnical)
            {
                winTeam = "Technical Trainers";
                winner = teamTechnical;
            } 

            Console.WriteLine($"The {winTeam} win with ${winner:F3}.");
        }
    }
}
