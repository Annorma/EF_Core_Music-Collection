using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF_Core_Intro
{
    public class Country
    {
        public Country()
        {
            Artists = new HashSet<Artist>();
        }

        [Key]   // set primary key
        public string Name { get; set; }
        [MaxLength(40)]

        // Navigation Properties
        public ICollection<Artist> Artists { get; set; } //Relationship type: Zero or One to Many
    }
}
