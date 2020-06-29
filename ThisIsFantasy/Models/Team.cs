using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThisIsFantasy.Models
{
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Venue { get; set; }
        public string ClubColors { get; set; }
        public DateTime LastUpdated { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TeamUId { get; set; }
    }
}