using System;
using System.Collections.Generic;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class Town
    {
        public int TownId {get; set;}

        public string Name { get; set; }

        // A Town can be placed in one Country 
        // Foreign Key to CountryId in table Country
        public int CountryId { get; set; }
        public Country Country { get; set; }

        // One Town can host several Teams
        public ICollection<Team> Teams { get; set; } = new List<Team>();
    }
} 