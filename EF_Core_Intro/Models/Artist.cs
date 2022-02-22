﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Intro
{
    // Entity
    [Table("Artists")]
    public class Artist
    {
        // Properties (columns in db)
        // Primary Key: Id/ID/id EntityName+Id (WorkerId)
        public int Id { get; set; }
        [Required]          // set not null
        [MaxLength(100)]    // set max length NVarChar(100)
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Surname { get; set; }
        [Required, MaxLength(100)]
        public Country Country { get; set; } //Relationship type: Zero or One to Many
        public Album Albums { get; set; } //Relationship type: Zero or One to Many


        // Navigation Properties
        //public Department Department { get; set; }
    }
}
