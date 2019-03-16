namespace P03_FootballBetting.Data.Models
{
    public class PlayerStatistic
    {
        // Each Game has Player Statistic
        // Foreign Key to GameId in table Game
        public int GameId { get; set; }
        public Game Game { get; set; }

        // A Player can play at one Position 
        // Foreign Key to PlayerId in table Player 
        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public int ScoredGoals { get; set; }

        public int Assists { get; set; }

        public int MinutesPlayed { get; set; }
    }
}