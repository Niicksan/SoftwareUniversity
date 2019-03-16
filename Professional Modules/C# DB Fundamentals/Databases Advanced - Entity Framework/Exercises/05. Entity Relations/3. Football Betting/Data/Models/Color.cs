using System.Collections.Generic;

namespace P03_FootballBetting.Data.Models
{
    public class Color
    {
        public int ColorId { get; set; }

        public string Name { get; set; }

        // A Color has many PrimaryKitTeams
        public ICollection<Team> PrimaryKitTeams { get; set; } = new List<Team>();

        // A Color has many many SecondaryKitTeams
        public ICollection<Team> SecondaryKitTeams { get; set; } = new List<Team>();
    }
}