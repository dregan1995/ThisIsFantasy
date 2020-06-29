using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ThisIsFantasy.Models;
using ThisIsFantasy.ViewModels;

namespace ThisIsFantasy.Controllers
{
    public class SelectedTeamController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly ApplicationDbContext _context;
        public SelectedTeamController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: ManageTeams
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Create()
        {
            string currentUserId = User.Identity.GetUserId();
            string email = User.Identity.GetUserName();
            var values = new Dictionary<string, string>
                    {
                        { "UserId", currentUserId },
                        {"TeamName", email }
                    };

            var content = new FormUrlEncodedContent(values);


            var response = await client.PostAsync("https://localhost:44324/Api/SelectedTeam", content);

            var responseString = await response.Content.ReadAsStringAsync();
            //    var cars = _context.Cars.Include(c => c.VehicleType).ToList();
            return View();

        }

        public ActionResult List()
        {
            IQueryable<SelectedTeam> loc = _context.SelectedTeams;
            string currentUserId = User.Identity.GetUserId();
            var test = loc.Where(x => x.UserId == currentUserId).ToList();
            int num = test.Count();

            if (num == 0)
            {
                return RedirectToAction("Create");
            }

            else
            {
                return View(test);
            }
            //var oFCars = _context.listOFCars.ToList();
            //return View(oFCars);
        }

        [Route("TeamSelection")]
        public ActionResult TEdit(int id)
        {
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
            var items = _context.PlayerStats.OrderByDescending(u => u.TotalPoints).Take(5);

            return View(viewModel);


        }
        [Route("TeamSelection")]
        public ActionResult SelectTeam(int id)
        {
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
            var items = _context.PlayerStats.OrderByDescending(u => u.TotalPoints).Take(5);

            return View(viewModel);


        }

        public ActionResult SelectedTeamPartialView(int id)
        {
            var fantasyTeam = _context.SelectedTeams.SingleOrDefault(c => c.Id == id);

            if (fantasyTeam == null)
                return HttpNotFound();

            return PartialView("SelectedTeamPartialView", fantasyTeam);

        }

        public ActionResult edit()
        {
            return View();
        }
    }
}