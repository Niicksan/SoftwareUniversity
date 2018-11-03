using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    class Team
    {
        private string name;
        private List<Player> players;
        private double rating;

        public Team(string name)
        {
            this.Name = name;
            this.Players = new List<Player>();
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be emty");
                }

                name = value;
            }
        }

        private List<Player> Players
        {
            get { return this.players; }
            set { this.players = value; }
        }

        public double Rating
        {
            get
            {
                if (this.Players.Count == 0)
                {
                    return 0;
                }

                double totalRating = 0;

                foreach (var player in players)
                {
                    totalRating += GetTotalStats(player);
                }

                return totalRating / this.Players.Count;
            }
        }

        public void AddPlayer(Player player)
        {
            this.Players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            int playerIndex = -1;

            for (int index = 0; index < this.Players.Count; index++)
            {
                Player player = this.Players[index];

                if (player.Name == playerName)
                {
                    playerIndex = index;
                }
            }

            if (playerIndex > -1)
            {
                Player player = this.Players[playerIndex];

                this.Players.RemoveAt(playerIndex);
                return;
            }

            Console.WriteLine($"Player {playerName} is not in {this.name} team.");
        }

        private double GetTotalStats(Player player)
        {
            Stats stats = player.Stats;

            int totalStats = stats.Endurance + stats.Sprit + stats.Drible + stats.Passing + stats.Shooting;
            return totalStats / 5.0;
        }
    }
}