using System;

namespace FootballTeamGenerator
{
    class Player
    {
        private string name;
        private Stats stats;

        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.stats = stats;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty");
                }

                this.name = value;
            }
        }


        public Stats Stats
        {
            get { return this.stats; }
        }
    }
}