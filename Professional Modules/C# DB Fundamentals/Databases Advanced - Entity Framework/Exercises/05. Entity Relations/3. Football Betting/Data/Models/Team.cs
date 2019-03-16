using System.Collections.Generic;

namespace P03_FootballBetting.Data.Models
{
    public class Team
    {
        public int TeamId { get; set; }

        public string Name { get; set; }

        public string LogoUrl { get; set; }

        public string Initials { get; set; }

        public decimal Budget { get; set; }

        //Foreign Key to PrimaryKitColorId in table Color 
        public int PrimaryKitColorId { get; set; }
        public Color PrimaryKitColor { get; set; }

        //Foreign Key to SecondaryKitColorId in table Color 
        public int SecondaryKitColorId { get; set; }
        public Color SecondaryKitColor { get; set; }

        // A Team residents in one Town
        // Foreign Key to TownId in table Town 
        public int TownId { get; set; }
        public Town Town { get; set; }

        // One Team can have many Players
        public ICollection<Player> Players { get; set; } = new List<Player>();

        // One Team can have many HomeGames
        public ICollection<Game> HomeGames { get; set; } = new List<Game>();

        // One Team can have many AwayGames
        public ICollection<Game> AwayGames { get; set; } = new List<Game>();
    }
}