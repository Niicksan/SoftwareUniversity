using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftUni.Models
{
    //[Table("Towns")]
    public class Town
    {
        public Town()
        {
            Addresses = new HashSet<Address>();
        }

        public int TownId { get; set; }
        public string Name { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
