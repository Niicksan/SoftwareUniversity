using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SkandauLyrics.Data.Models
{
    public class Singer
    {
        public Singer()
        {
            this.Songs = new HashSet<Song>();
        }

        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
