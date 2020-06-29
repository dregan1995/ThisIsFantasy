using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ThisIsFantasy.Models;
using System.Data.Entity;
using System.Web.Mvc;
using ThisIsFantasy.ViewModels;

namespace ThisIsFantasy.Controllers.api
{
    public class PlayersController : ApiController
    {
        private ApplicationDbContext _context;

        public PlayersController()
        {
            _context = new ApplicationDbContext();
        }

        [System.Web.Http.HttpPost]
        public Player CreateTeam(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();

            return player;
        }

        [System.Web.Http.HttpPut]
        public void UpdatePlayer(Player player, int id)
        {

            var playerInDb = _context.Players.SingleOrDefault(c => c.Id == id);

            if (playerInDb == null)
            {
                _context.Players.Add(player);
            }
            else
            {
                playerInDb.Name = player.Name;
                playerInDb.Position = player.Position;
                playerInDb.DateOfBirth = player.DateOfBirth;
                playerInDb.CountryOfBirth = player.CountryOfBirth;
                playerInDb.Nationality = player.Nationality;
                playerInDb.ShirtNumber = player.ShirtNumber;
                playerInDb.Role = player.Role;
                playerInDb.TeamId = player.TeamId;
                playerInDb.LastUpdated = player.LastUpdated;
            }

            _context.SaveChanges();
        }

        [System.Web.Http.HttpGet]
        public IEnumerable<Player> GetPlayers()
        {
            return _context.Players.Include(c => c.Team).ToList();
        }

        //[System.Web.Http.HttpGet]
        //public JsonResult GetTeam(int teamName)
        //{
        //    _context.Configuration.ProxyCreationEnabled = false;
        //    var teams = _context.Teams.ToList();
        //    var players = _context.Players.Where(x => x.TeamId == teamName).ToList();
        //    var playerStats = _context.PlayerStats.ToList();
        //    var viewModel = new PlayerClubViewModel
        //    {
        //        Players = players,
        //        Teams = teams,
        //        PlayerStats = playerStats
        //    };
        //    var data1 = new List<SelectListItem>();
        //    foreach (var team in teams)
        //    {
        //        data1.Add(new SelectListItem { Text = team.Name, Value = team.Id.ToString() });
        //    }
        //    return Json(viewModel);

        //}
    }
}
