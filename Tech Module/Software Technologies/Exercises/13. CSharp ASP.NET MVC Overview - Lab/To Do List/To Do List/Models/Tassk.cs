using System;
using System.ComponentModel.DataAnnotations;

namespace To_Do_List.Models
{
    public class Tassk
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
    }
}
