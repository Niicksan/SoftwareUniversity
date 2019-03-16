using System;

namespace P03_FootballBetting.Data.Models
{
    public class Bet
    {
        public int BetId { get; set; }

        public decimal Amount { get; set; }

        public int Prediction { get; set; }

        public DateTime DateTime { get; set; }

        // A Bet can be placed by only one User 
        // Foreign Key to UserId in table User 
        public int UserId { get; set; }
        public User User { get; set; }

        // A Bet can be only on one Game
        // Foreign Key to GameId in table Game
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}