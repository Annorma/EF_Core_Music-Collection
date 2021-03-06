using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Intro
{
    // Entity
    [Table("Playlists")]
    public class Playlist
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(150)]
        public Song Songs { get; set; } //Relationship type: One to Many
        [Required, MaxLength(100)]
        public Category Category { get; set; } //Relationship type: Many to Many
    }
}
