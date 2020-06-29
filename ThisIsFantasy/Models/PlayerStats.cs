using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;

namespace ThisIsFantasy.Models
{
    public class PlayerStats
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ApiName { get; set; }
        public int Goals { get; set; }
        public int OwnGoals { get; set; }
        public Player Player { get; set; }
        public int PlayerId { get; set; }

        public int WeeklyPoints
        {
            get; set;
        }

        public int TotalPoints { get; set; }

        public string Warning { get; set; }

        public bool Starter { get; set; }
        public int AppearancePoints { get; set; }
    }
}