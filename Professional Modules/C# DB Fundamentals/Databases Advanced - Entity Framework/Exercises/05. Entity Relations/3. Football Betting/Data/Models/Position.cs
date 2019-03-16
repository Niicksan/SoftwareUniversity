using System.Collections.Generic;

namespace P03_FootballBetting.Data.Models
{
    public class Position
    {
        public int PositionId { get; set; }

        public string Name { get; set; }

        // One Position can be played by many Players
        public ICollection<Player> Players { get; set; } = new List<Player>();
    }
}