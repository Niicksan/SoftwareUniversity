using System;

namespace FootballTeamGenerator
{
    class Stats
    {
        private int endurance;
        private int sprit;
        private int drible;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprit, int drible, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprit = sprit;
            this.Drible = drible;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Endurance
        {
            get { return this.endurance; }
            private set
            {
                TtrowException(value, "Endurance");
                this.endurance = value;
            }
        }

        public int Sprit
        {
            get { return this.sprit; }
            private set
            {
                TtrowException(value, "Sprit");
                this.sprit = value;
            }
        }

        public int Drible
        {
            get { return this.drible; }
            private set
            {
                TtrowException(value, "Drible");
                this.drible = value;
            }
        }

        public int Passing
        {
            get { return this.passing; }
            private set
            {
                TtrowException(value, "Passing");
                this.passing = value;
            }
        }

        public int Shooting
        {
            get { return this.shooting; }
            private set
            {
                TtrowException(value, "Shooting");
                this.shooting = value;
            }
        }

        private void TtrowException(int value, string statType)
        {
            if (!(value >= 0 && value <= 100))
            {
                throw new Exception($"{statType} should be between 0 and 100.");
            }
        }
    }
}