using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspMoment3.Models
{
    public class Album
    {
        public int AlbumID { get; set; } //PK
        [Required]
        [Display(Name= "Albumets namn")]
        public string Name { get; set; }
        [Required]
        [Display(Name= "Låt antal")]
        public int NumSongs { get; set; }
        [Required]
        [Display(Name = "Utgivningsår")]
        public int Realease { get; set; }
        [Required]
        public int ArtistID { get; set; } //FK

        public Artist Artist { get; set; } //Hämtar in modellen Artist.
    }
}
