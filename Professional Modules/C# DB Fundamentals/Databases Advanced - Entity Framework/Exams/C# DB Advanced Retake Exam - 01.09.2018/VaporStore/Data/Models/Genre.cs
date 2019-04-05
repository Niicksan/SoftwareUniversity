namespace VaporStore.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Genre
    {
        // Id – integer, Primary Key
        // Name – text(required)
        // Games - collection of type Game

        public Genre()
        {
            this.Games = new List<Game>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
