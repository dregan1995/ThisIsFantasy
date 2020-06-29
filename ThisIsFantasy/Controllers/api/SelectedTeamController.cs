using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ThisIsFantasy.Dtos;
using ThisIsFantasy.Models;

namespace ThisIsFantasy.Controllers.api
{
    public class SelectedTeamController : ApiController
    {
        private ApplicationDbContext _context;

        public SelectedTeamController()
        {
            _context = new ApplicationDbContext();
        }
        [System.Web.Http.HttpGet]
        public IEnumerable<FantasyTeam> GetTeams(int id)
        {
            return _context.FantasyTeams.Where(c => c.LeagueId == id).ToArray();
        }

        [HttpPost]
        public IHttpActionResult CreateSelectedTeam(SelectedTeamDto selectedTeamDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

             var ft = Mapper.Map<SelectedTeamDto, SelectedTeam>(selectedTeamDto);

            _context.SelectedTeams.Add(ft);
            _context.SaveChanges();

            selectedTeamDto.Id = ft.Id;

            return Created(new Uri(Request.RequestUri + "/" + ft.Id), selectedTeamDto);
        }

        //[HttpPut]
        //public IHttpActionResult UpdateFantasyTeams(int id, FantasyTeam fantasyTeam)
        //{

        //    var teamInDb = _context.FantasyTeams.Single(c => c.Id == fantasyTeam.Id);

        //    if (teamInDb.PlayerName1 == "" || teamInDb.PlayerName1 == null)
        //    {
        //        teamInDb.PlayerName1 = fantasyTeam.PlayerName1;
        //        teamInDb.PlayerStatId1 = fantasyTeam.PlayerStatId1;
        //        teamInDb.TotalPoints1 = fantasyTeam.TotalPoints1;
        //    }
        //    else if (teamInDb.PlayerName2 == "" || teamInDb.PlayerName2 == null)
        //    {
        //        teamInDb.PlayerName2 = fantasyTeam.PlayerName2;
        //        teamInDb.PlayerStatId2 = fantasyTeam.PlayerStatId2;
        //        teamInDb.TotalPoints2 = fantasyTeam.TotalPoints2;
        //    }
        //    else if (teamInDb.PlayerName3 == "" || teamInDb.PlayerName3 == null)
        //    {
        //        teamInDb.PlayerName3 = fantasyTeam.PlayerName3;
        //        teamInDb.PlayerStatId3 = fantasyTeam.PlayerStatId3;
        //        teamInDb.TotalPoints3 = fantasyTeam.TotalPoints3;
        //    }
        //    else if (teamInDb.PlayerName4 == "" || teamInDb.PlayerName4 == null)
        //    {
        //        teamInDb.PlayerName4 = fantasyTeam.PlayerName4;
        //        teamInDb.PlayerStatId4 = fantasyTeam.PlayerStatId4;
        //        teamInDb.TotalPoints4 = fantasyTeam.TotalPoints4;
        //    }
        //    else if (teamInDb.PlayerName5 == "" || teamInDb.PlayerName5 == null)
        //    {
        //        teamInDb.PlayerName5 = fantasyTeam.PlayerName5;
        //        teamInDb.PlayerStatId5 = fantasyTeam.PlayerStatId5;
        //        teamInDb.TotalPoints5 = fantasyTeam.TotalPoints5;
        //    }
        //    else if (teamInDb.PlayerName6 == "" || teamInDb.PlayerName6 == null)
        //    {
        //        teamInDb.PlayerName6 = fantasyTeam.PlayerName6;
        //        teamInDb.PlayerStatId6 = fantasyTeam.PlayerStatId6;
        //        teamInDb.TotalPoints6 = fantasyTeam.TotalPoints6;
        //    }
        //    else if (teamInDb.PlayerName7 == "" || teamInDb.PlayerName7 == null)
        //    {
        //        teamInDb.PlayerName7 = fantasyTeam.PlayerName7;
        //        teamInDb.PlayerStatId7 = fantasyTeam.PlayerStatId7;
        //        teamInDb.TotalPoints7 = fantasyTeam.TotalPoints7;
        //    }
        //    else if (teamInDb.PlayerName8 == "" || teamInDb.PlayerName8 == null)
        //    {
        //        teamInDb.PlayerName8 = fantasyTeam.PlayerName8;
        //        teamInDb.PlayerStatId8 = fantasyTeam.PlayerStatId8;
        //        teamInDb.TotalPoints8 = fantasyTeam.TotalPoints8;
        //    }
        //    else if (teamInDb.PlayerName9 == "" || teamInDb.PlayerName9 == null)
        //    {
        //        teamInDb.PlayerName9 = fantasyTeam.PlayerName9;
        //        teamInDb.PlayerStatId9 = fantasyTeam.PlayerStatId9;
        //        teamInDb.TotalPoints9 = fantasyTeam.TotalPoints9;
        //    }
        //    else if (teamInDb.PlayerName10 == "" || teamInDb.PlayerName10 == null)
        //    {
        //        teamInDb.PlayerName10 = fantasyTeam.PlayerName10;
        //        teamInDb.PlayerStatId10 = fantasyTeam.PlayerStatId10;
        //        teamInDb.TotalPoints10 = fantasyTeam.TotalPoints10;
        //    }
        //    else if (teamInDb.PlayerName11 == "" || teamInDb.PlayerName11 == null)
        //    {
        //        teamInDb.PlayerName11 = fantasyTeam.PlayerName11;
        //        teamInDb.PlayerStatId11 = fantasyTeam.PlayerStatId11;
        //        teamInDb.TotalPoints11 = fantasyTeam.TotalPoints11;
        //    }
        //    else if (teamInDb.PlayerName12 == "" || teamInDb.PlayerName12 == null)
        //    {
        //        teamInDb.PlayerName12 = fantasyTeam.PlayerName12;
        //        teamInDb.PlayerStatId12 = fantasyTeam.PlayerStatId12;
        //        teamInDb.TotalPoints12 = fantasyTeam.TotalPoints12;
        //    }
        //    else if (teamInDb.PlayerName13 == "" || teamInDb.PlayerName13 == null)
        //    {
        //        teamInDb.PlayerName13 = fantasyTeam.PlayerName13;
        //        teamInDb.PlayerStatId13 = fantasyTeam.PlayerStatId13;
        //        teamInDb.TotalPoints13 = fantasyTeam.TotalPoints13;
        //    }
        //    else if (teamInDb.PlayerName14 == "" || teamInDb.PlayerName14 == null)
        //    {
        //        teamInDb.PlayerName14 = fantasyTeam.PlayerName14;
        //        teamInDb.PlayerStatId14 = fantasyTeam.PlayerStatId14;
        //        teamInDb.TotalPoints14 = fantasyTeam.TotalPoints14;
        //    }
        //    else if (teamInDb.PlayerName15 == "" || teamInDb.PlayerName15 == null)
        //    {
        //        teamInDb.PlayerName15 = fantasyTeam.PlayerName15;
        //        teamInDb.PlayerStatId15 = fantasyTeam.PlayerStatId15;
        //        teamInDb.TotalPoints15 = fantasyTeam.TotalPoints15;
        //    }
        //    //customerInDb. = customer.Name;
        //    //customerInDb.DateOfBirth = customer.DateOfBirth;
        //    //customerInDb.MembershipTypeId = customer.MembershipTypeId;
        //    //customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
        //    _context.SaveChanges();
        //    return Ok();
        //}

        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, UpdateTeamDto updateTeamDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var teamInDb = _context.SelectedTeams.SingleOrDefault(c => c.Id == id);

            if (teamInDb == null)
                return NotFound();

            Mapper.Map(updateTeamDto, teamInDb);

            _context.SaveChanges();

            return Ok();
        }


    }
}