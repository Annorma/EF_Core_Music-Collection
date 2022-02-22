using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Intro
{
    // Entity
    [Table("Albums")]
    public class Album
    {
        // Properties (columns in db)
        // Primary Key: Id/ID/id EntityName+Id (WorkerId)
        public int Id { get; set; }
        [Required]          // set not null
        [MaxLength(100)]    // set max length NVarChar(100)
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public Artist Artist { get; set; } //Relationship type: One to Many
        public Song Songs { get; set; } //Relationship type: One to Many
        public int Year { get; set; }
        public int Listens { get; set; }
        public Genre Genre { get; set; } //Relationship type: One to Many


        // Navigation Properties
        //public Department Department { get; set; }
    }
}
