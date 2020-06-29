using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThisIsFantasy.Models
{
        public class Player
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public int Id { get; set; }
            public string Name { get; set; }
            public Team Team { get; set; }
            public int TeamId { get; set; }

            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public Guid TeamUId { get; set; }

            public string Position { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string CountryOfBirth { get; set; }
            public string Nationality { get; set; }
            public int? ShirtNumber { get; set; }
            public string Role { get; set; }
            public DateTime LastUpdated { get; set; }
            public string TeamName { get; set; }
            
        }
}