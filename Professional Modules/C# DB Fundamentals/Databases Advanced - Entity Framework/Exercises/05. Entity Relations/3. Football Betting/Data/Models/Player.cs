using System.Collections.Generic;

namespace P03_FootballBetting.Data.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        public string Name { get; set; }

        public int SquadNumber { get; set; }

        // A Player can play for one 
        // Foreign Key to TownId in table Town 
        public int TeamId { get; set; }
        public Team Team { get; set; }

        // A Player can play at one Position 
        // Foreign Key to PositionId in table Position 
        public int PositionId { get; set; }
        public Position Position { get; set; }

        public bool IsInjured { get; set; }

        // Many Players take part (PlayerStatistics)
        public ICollection<PlayerStatistic> PlayerStatistics { get; set; } = new List<PlayerStatistic>();
    }
}