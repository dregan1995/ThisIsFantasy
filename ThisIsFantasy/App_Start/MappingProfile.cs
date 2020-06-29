using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThisIsFantasy.Dtos;
using ThisIsFantasy.Models;
using AutoMapper;

namespace ThisIsFantasy.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<FantasyTeam, FantasyTeamDto>();
            Mapper.CreateMap<SelectedTeam, SelectedTeamDto>();
            Mapper.CreateMap<SelectedTeam, UpdateTeamDto>();

            Mapper.CreateMap<FantasyTeamDto, FantasyTeam>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<SelectedTeamDto, SelectedTeam>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<UpdateTeamDto, SelectedTeam>().ForMember(c => c.Id, opt => opt.Ignore());
            //Mapper.CreateMap<FantasyTeamDto, FantasyTeam>().ForMember(c => c.LeagueId, opt => opt.Ignore());
            //Mapper.CreateMap<FantasyTeamDto, FantasyTeam>().ForMember(c => c.TeamName, opt => opt.Ignore());
            //Mapper.CreateMap<FantasyTeamDto, FantasyTeam>().ForMember(c => c.UserId, opt => opt.Ignore());
        }
    }
}