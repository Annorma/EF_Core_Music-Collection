using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF_Core_Intro
{
    public class Genre
    {
        public Genre()
        {
            Albums = new HashSet<Album>();
        }
        [Key]   // set primary key
        public string Name { get; set; }
        [MaxLength(40)]

        // Navigation Properties
        public ICollection<Album> Albums { get; set; } //Relationship type: One to Many
    }
}
