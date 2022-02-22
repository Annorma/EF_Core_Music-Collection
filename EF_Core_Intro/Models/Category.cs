using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF_Core_Intro
{
    public class Category
    {
        public Category()
        {
            Playlists = new HashSet<Playlist>();
        }
        [Key]   // set primary key
        public string Name { get; set; }
        [MaxLength(40)]

        // Navigation Properties
        public ICollection<Playlist> Playlists { get; set; } //Relationship type: Many to Many
    }
}
