using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SkandauLyrics.Data.Models
{
    public class Song
    {
        public Song()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(55)]
        public string Name { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "This Url must be exact 11 characters")]
        public string Url { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        public string Lyric { get; set; }

        [Required]
        public string SingerId { get; set; }

        public Singer Singer { get; set; }
    }
}