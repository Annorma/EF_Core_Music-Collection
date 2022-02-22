using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Intro
{
    // Entity
    [Table("Songs")]
    public class Song
    {
        // Properties (columns in db)
        // Primary Key: Id/ID/id EntityName+Id (WorkerId)
        public int Id { get; set; }
        [Required]          // set not null
        [MaxLength(100)]    // set max length NVarChar(100)
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public Album Album { get; set; } //Relationship type: One to Many
        [Required]
        public int Listens { get; set; }
        public double Duration { get; set; }

        // Navigation Properties
        //public Department Department { get; set; }
    }
}
