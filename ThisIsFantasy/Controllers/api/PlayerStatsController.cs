using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ThisIsFantasy.Models;
using System.Data.Entity;

namespace ThisIsFantasy.Controllers.api
{
    public class PlayerStatsController : ApiController
    {
        public string positionNotFound = "Could not find players position";
        private ApplicationDbContext _context;

        public PlayerStatsController()
        {
            _context = new ApplicationDbContext();
        }

        //[HttpPut]
        //public void UpdatePlayerStat(string apiName, PlayerStats playerStats)
        //{
        //    int pid = -1;
        //    if (int.TryParse(apiName, out pid))
        //    {
        //        var playerStatinDb = _context.PlayerStats.SingleOrDefault(c => c.Id == pid);
        //        if (playerStats.Goals == 1 && playerStats.OwnGoals == 0)
        //        {
        //            playerStatinDb.Goals = playerStatinDb.Goals + 1;
        //        }
        //        else
        //        {
        //            playerStatinDb.OwnGoals = playerStatinDb.OwnGoals + 1;
        //        }
        //    }

        //    else
        //    {
        //        var playerStatinDb = _context.PlayerStats.SingleOrDefault(c => c.ApiName == apiName);

        //        if (playerStats.Goals == 1 && playerStats.OwnGoals == 0)
        //        {
        //            playerStatinDb.Goals = playerStatinDb.Goals + 1;
        //        }
        //        else
        //        {
        //            playerStatinDb.OwnGoals = playerStatinDb.OwnGoals + 1;
        //        }
        //    }

        //    _context.SaveChanges();
        //}

        [HttpPut]
        public void UpdatePlarStat(string apiName, PlayerStats playerStats)
        {
            int pid = -1;
            if (int.TryParse(apiName, out pid))
            {
                var playerStatinDb = _context.PlayerStats.SingleOrDefault(c => c.Id == pid);
                int id = playerStatinDb.PlayerId;
                var checkPosition = _context.PlayerStats.Include(c => c.Player).SingleOrDefault(c => c.PlayerId == id);

                if (playerStats.Starter == true)
                {
                    playerStatinDb.AppearancePoints = playerStatinDb.AppearancePoints + 2;
                    playerStatinDb.WeeklyPoints = playerStatinDb.WeeklyPoints + 2;
                    playerStatinDb.TotalPoints = playerStatinDb.TotalPoints + 2;
                }

                else if (playerStats.Goals == 1 && playerStats.OwnGoals == 0)
                {
                    playerStatinDb.Goals = playerStatinDb.Goals + 1;

                    string position = checkPosition.Player.Position;

                    switch (position)
                    {
                        case "Goalkeeper":
                            playerStatinDb.TotalPoints = playerStatinDb.TotalPoints + 10;
                            playerStatinDb.WeeklyPoints = playerStatinDb.WeeklyPoints + 10;
                            break;
                        case "Defender":
                            playerStatinDb.TotalPoints = playerStatinDb.TotalPoints + 6;
                            playerStatinDb.WeeklyPoints = playerStatinDb.WeeklyPoints + 6;
                            break;
                        case "Midfielder":
                            playerStatinDb.TotalPoints = playerStatinDb.TotalPoints + 5;
                            playerStatinDb.WeeklyPoints = playerStatinDb.WeeklyPoints + 5;
                            break;
                        case "Attacker":
                            playerStatinDb.TotalPoints = playerStatinDb.TotalPoints + 4;
                            playerStatinDb.WeeklyPoints = playerStatinDb.WeeklyPoints + 4;
                            break;
                        default:
                            playerStatinDb.Warning = positionNotFound;
                            break;
                    }
                }
                else
                {
                    playerStatinDb.OwnGoals = playerStatinDb.OwnGoals + 1;
                    playerStatinDb.WeeklyPoints = playerStatinDb.WeeklyPoints - 2;
                    playerStatinDb.TotalPoints = playerStatinDb.TotalPoints - 2;
                }
            }

            else
            {
                if (apiName.Contains("(C)") && apiName.Contains("G"))
                    apiName = apiName.Substring(0, apiName.Length - 8);

                else if (apiName.Contains("C"))
                    apiName = apiName.Substring(0, apiName.Length - 4);

                else if (apiName.Contains("G"))
                    apiName = apiName.Substring(0, apiName.Length - 4);

                var playerStatinDb = _context.PlayerStats.SingleOrDefault(c => c.ApiName == apiName);
                int id = playerStatinDb.PlayerId;
                var checkPosition = _context.PlayerStats.Include(c => c.Player).SingleOrDefault(c => c.PlayerId == id);

                if (playerStats.Starter == true)
                {
                    playerStatinDb.AppearancePoints = playerStatinDb.AppearancePoints + 2;
                    playerStatinDb.WeeklyPoints = playerStatinDb.WeeklyPoints + 2;
                    playerStatinDb.TotalPoints = playerStatinDb.TotalPoints + 2;
                }

                else if(playerStats.Goals == 1 && playerStats.OwnGoals == 0)
                { 
                    playerStatinDb.Goals = playerStatinDb.Goals + 1;

                string position = checkPosition.Player.Position;

                switch (position)
                {
                    case "Goalkeeper":
                        playerStatinDb.TotalPoints = playerStatinDb.TotalPoints + 10;
                        playerStatinDb.WeeklyPoints = playerStatinDb.WeeklyPoints + 10;
                        break;
                    case "Defender":
                        playerStatinDb.TotalPoints = playerStatinDb.TotalPoints + 6;
                        playerStatinDb.WeeklyPoints = playerStatinDb.WeeklyPoints + 6;
                            break;
                    case "Midfielder":
                        playerStatinDb.TotalPoints = playerStatinDb.TotalPoints + 5;
                        playerStatinDb.WeeklyPoints = playerStatinDb.WeeklyPoints + 5;
                            break;
                    case "Attacker":
                        playerStatinDb.TotalPoints = playerStatinDb.TotalPoints + 4;
                        playerStatinDb.WeeklyPoints = playerStatinDb.WeeklyPoints + 4;
                            break;
                        default:
                            playerStatinDb.Warning = positionNotFound;
                        break;
                    }
                }
                else
                {
                    playerStatinDb.OwnGoals = playerStatinDb.OwnGoals + 1;
                    playerStatinDb.WeeklyPoints = playerStatinDb.WeeklyPoints - 2;
                    playerStatinDb.TotalPoints = playerStatinDb.TotalPoints - 2;
                }
            }

            _context.SaveChanges();
        }
    }
}
