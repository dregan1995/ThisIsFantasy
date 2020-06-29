using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThisIsFantasy.Models;

namespace ThisIsFantasy.ViewModels
{
    public class PlayerClubViewModel
    {
        public List<Team> Teams { get; set; }
        public List<Player> Players { get; set; }
        public List<PlayerStats> PlayerStats { get; set; }
    }
}