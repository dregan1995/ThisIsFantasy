using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ThisIsFantasy.Models;

namespace ThisIsFantasy.Controllers.api
{
    public class TeamsController : ApiController
    {
        private ApplicationDbContext _context;

        public TeamsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public Team CreateTeam(Team team)
        {
            _context.Teams.Add(team);
            _context.SaveChanges();

            return team;
        }

        [HttpPut]
        public void UpdateTeam(Team team, int id)
        {

            var teamInDb = _context.Teams.SingleOrDefault(c => c.Id == id);

            if (teamInDb == null)
            {
                _context.Teams.Add(team);
            }
            else
            {
                teamInDb.Name = team.Name;
                //teamInDb.Venue = team.Venue;
                //teamInDb.ClubColors = team.ClubColors;
                //teamInDb.LastUpdated = team.LastUpdated;
            }

            _context.SaveChanges();
        }

        [HttpGet]
        public IEnumerable<Team> GetTeams()
        {
            return _context.Teams.ToList();
        }
    }
}
