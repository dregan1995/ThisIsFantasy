using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThisIsFantasy.Models;
using System.Data.Entity;
using System.Net.Mime;
using ThisIsFantasy.ViewModels;

namespace ThisIsFantasy.Controllers
{
    public class PlayersController : Controller
    {
        private ApplicationDbContext _context;

        public PlayersController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Players
        public ActionResult Index()
        {
            //List<PlayerClubViewModel> playerClubList = new List<PlayerClubViewModel>();
            ////var t = (from]
            ////t.ToArray();
            //var playerList = (from team in _context.Teams
            //    join player in _context.Players on team.Id equals player.TeamId
            //    select new
            //    {
            //        t1 = team.Id, t2 = team.Name, player.Id, player.TeamId, player.Name, player.Position
            //    }).ToList();
            ////var context = _context.Players.Include(c => c.Team).ToList();

            //foreach (var item in playerList)
            //{
            //    PlayerClubViewModel objcvm = new PlayerClubViewModel(); // ViewModel
            //    objcvm.TeamId = item.t1;
            //    objcvm.TeamName = item.t2;
            //    objcvm.PlayerId = item.Id;
            //    objcvm.PlayerTeamId = item.TeamId;
            //    objcvm.PlayerName = item.Name;
            //    objcvm.Position = item.Position;
            //    playerClubList.Add(objcvm);
            //}
            
            //foreach (var item in t)
            //{
            //    Console.WriteLine(item);    
            //}
            var teams = _context.Teams.ToList();
            var players = _context.Players.ToList();
            var playerStats = _context.PlayerStats.ToList();
            var viewModel = new PlayerClubViewModel
            {
                Players = players,
                Teams = teams,
                PlayerStats = playerStats
            };
            var data1 = new List<SelectListItem>();
            foreach (var team in teams)
            {
                data1.Add(new SelectListItem {Text = team.Name, Value = team.Id.ToString()});
            }
            ViewBag.drop1 = data1;
            var items = _context.PlayerStats.OrderByDescending(u => u.TotalPoints).Take(5);

            return View(viewModel);


        }

        public ActionResult Team(int selectedTeam)
        {
                var data = _context.Players.Where(f => f.TeamId == selectedTeam);

                var teams = _context.Teams.ToList();
                var players = data.ToList();
                var playerStats = _context.PlayerStats.ToList();
                var viewModel = new PlayerClubViewModel
                {
                    Players = players,
                    Teams = teams,
                    PlayerStats = playerStats
                };
                var data1 = new List<SelectListItem>();
                foreach (var team in teams)
                {
                    data1.Add(new SelectListItem { Text = team.Name, Value = team.Id.ToString() });
                }
                ViewBag.drop1 = data1;

                return View(viewModel);
        }
        public ActionResult homer(int searchResult)
        {
        //    if (searchResult == 0)
        //    {
                var teams = _context.Teams.ToList();
                var players = _context.Players.ToList();
                var playerStats = _context.PlayerStats.ToList();

                var viewModel = new PlayerClubViewModel
                {
                    Players = players,
                    Teams = teams,
                    PlayerStats = playerStats
                };
                var data1 = new List<SelectListItem>();
                foreach (var team in teams)
                {
                    data1.Add(new SelectListItem { Text = team.Name, Value = team.Id.ToString() });
                }
                ViewBag.drop1 = data1;

                return View(viewModel);
            //}

            //else
            //{ 
            //    var teams = _context.Teams.ToList();
            //    var players = _context.Players.ToList();
            //    var playerStats = _context.PlayerStats.OrderByDescending(u => u.TotalPoints).Take(5).ToList();
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
            //    ViewBag.drop1 = data1;

            //    return View(viewModel);
            //}
        }

        public JsonResult GetTeam(int teamName)
        {
            _context.Configuration.ProxyCreationEnabled = false;
            var teams = _context.Teams.ToList();
            var players = _context.Players.Where(x => x.TeamId == teamName).ToList();
            var playerStats = _context.PlayerStats.ToList();
            var viewModel = new PlayerClubViewModel
            {
                Players = players,
                Teams = teams,
                PlayerStats = playerStats
            };
            var data1 = new List<SelectListItem>();
            foreach (var team in teams)
            {
                data1.Add(new SelectListItem { Text = team.Name, Value = team.Id.ToString() });
            }
            ViewBag.drop1 = data1;
            return Json(viewModel, JsonRequestBehavior.AllowGet);

        }
        public ActionResult IndexNew()
        {
            return View();
        }

        public ActionResult OneGo(string position)
        {
            ViewBag.Position = (from r in _context.Teams select r.Name.Distinct());

            var teams = _context.Teams.ToList();
            var players = _context.Players.ToList();
            var playerStats = _context.PlayerStats.ToList();
            var viewModel = new PlayerClubViewModel
            {
                Players = players,
                Teams = teams,
                PlayerStats = playerStats
            };

            
            return View(viewModel);
    }
    }
}