using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspMoment3.Models
{
    public class Artist
    {
        public int ArtistID { get; set; } //PK
        [Required]
        [Display(Name = "Artistnamn")]
        public string Name { get; set; }

        // One to many - relation
        public ICollection<Album> Albums { get; set; }
    }
}
