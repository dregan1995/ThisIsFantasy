using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThisIsFantasy.Dtos
{
    public class SelectedTeamDto
    {
        public int Id { get; set; }
        //public string Goalkeeper1 { get; set; }
        //public int GoalkeeperId1 { get; set; }
        //public int GoalkeeperPoints1 { get; set; }
        //public int GoalkeeperTeamId1 { get; set; }
        //public string GoalkeeperPosition1 { get; set; }
        //public string Goalkeeper2 { get; set; }
        //public int GoalkeeperId2 { get; set; }
        //public int GoalkeeperPoints2 { get; set; }
        //public int GoalkeeperTeamId12 { get; set; }
        //public string GoalkeeperPosition2 { get; set; }
        //public string Defender1 { get; set; }
        //public int DefenderId1 { get; set; }
        //public int DefenderPoints1 { get; set; }
        //public int DefenderTeamId1 { get; set; }
        //public string DefenderPosition1 { get; set; }
        //public string Defender2 { get; set; }
        //public int DefenderId2 { get; set; }
        //public int DefenderPoints2 { get; set; }
        //public int DefenderTeamId12 { get; set; }
        //public string DefenderPosition2 { get; set; }
        //public string Defender3 { get; set; }
        //public int DefenderId3 { get; set; }
        //public int DefenderPoints3 { get; set; }
        //public int DefenderTeamId3 { get; set; }
        //public string DefenderPosition3 { get; set; }
        //public string Defender4 { get; set; }
        //public int DefenderId4 { get; set; }
        //public int DefenderPoints4 { get; set; }
        //public int DefenderTeamId14 { get; set; }
        //public string DefenderPosition4 { get; set; }
        //public string Defender5 { get; set; }
        //public int DefenderId5 { get; set; }
        //public int DefenderPoints5 { get; set; }
        //public int DefenderTeamId15 { get; set; }
        //public string DefenderPosition5 { get; set; }
        //public string Midfielder1 { get; set; }
        //public int MidfielderId1 { get; set; }
        //public int MidfielderPoints1 { get; set; }
        //public int MidfielderTeamId1 { get; set; }
        //public string MidfielderPosition1 { get; set; }
        //public string Midfielder2 { get; set; }
        //public int MidfielderId2 { get; set; }
        //public int MidfielderPoints2 { get; set; }
        //public int MidfielderTeamId12 { get; set; }
        //public string MidfielderPosition2 { get; set; }
        //public string Midfielder3 { get; set; }
        //public int MidfielderId3 { get; set; }
        //public int MidfielderPoints3 { get; set; }
        //public int MidfielderTeamId3 { get; set; }
        //public string MidfielderPosition3 { get; set; }
        //public string Midfielder4 { get; set; }
        //public int MidfielderId4 { get; set; }
        //public int MidfielderPoints4 { get; set; }
        //public int MidfielderTeamId14 { get; set; }
        //public string MidfielderPosition4 { get; set; }
        //public string Midfielder5 { get; set; }
        //public int MidfielderId5 { get; set; }
        //public int MidfielderPoints5 { get; set; }
        //public int MidfielderTeamId15 { get; set; }
        //public string MidfielderPosition5 { get; set; }

        //public string Attacker1 { get; set; }
        //public int AttackerId1 { get; set; }
        //public int AttackerPoints1 { get; set; }
        //public int AttackerTeamId1 { get; set; }
        //public string AttackerPosition1 { get; set; }
        //public string Attacker2 { get; set; }
        //public int AttackerId2 { get; set; }
        //public int AttackerPoints2 { get; set; }
        //public int AttackerTeamId12 { get; set; }
        //public string AttackerPosition2 { get; set; }
        //public string Attacker3 { get; set; }
        //public int AttackerId3 { get; set; }
        //public int AttackerPoints3 { get; set; }
        //public int AttackerTeamId3 { get; set; }
        //public string AttackerPosition3 { get; set; }
        public string UserId { get; set; }
        public string TeamName { get; set; }
        //public int LeagueId { get; set; }
    }

    public class UpdateTeamDto
    {
        public int Id { get; set; }
        public string Goalkeeper1 { get; set; }
        public int GoalkeeperId1 { get; set; }
        public int GoalkeeperPoints1 { get; set; }
        public int GoalkeeperTeamId1 { get; set; }
        public string GoalkeeperPosition1 { get; set; }
        public string Goalkeeper2 { get; set; }
        public int GoalkeeperId2 { get; set; }
        public int GoalkeeperPoints2 { get; set; }
        public int GoalkeeperTeamId2 { get; set; }
        public string GoalkeeperPosition2 { get; set; }
        public string Defender1 { get; set; }
        public int DefenderId1 { get; set; }
        public int DefenderPoints1 { get; set; }
        public int DefenderTeamId1 { get; set; }
        public string DefenderPosition1 { get; set; }
        public string Defender2 { get; set; }
        public int DefenderId2 { get; set; }
        public int DefenderPoints2 { get; set; }
        public int DefenderTeamId2 { get; set; }
        public string DefenderPosition2 { get; set; }
        public string Defender3 { get; set; }
        public int DefenderId3 { get; set; }
        public int DefenderPoints3 { get; set; }
        public int DefenderTeamId3 { get; set; }
        public string DefenderPosition3 { get; set; }
        public string Defender4 { get; set; }
        public int DefenderId4 { get; set; }
        public int DefenderPoints4 { get; set; }
        public int DefenderTeamId4 { get; set; }
        public string DefenderPosition4 { get; set; }
        public string Defender5 { get; set; }
        public int DefenderId5 { get; set; }
        public int DefenderPoints5 { get; set; }
        public int DefenderTeamId5 { get; set; }
        public string DefenderPosition5 { get; set; }
        public string Midfielder1 { get; set; }
        public int MidfielderId1 { get; set; }
        public int MidfielderPoints1 { get; set; }
        public int MidfielderTeamId1 { get; set; }
        public string MidfielderPosition1 { get; set; }
        public string Midfielder2 { get; set; }
        public int MidfielderId2 { get; set; }
        public int MidfielderPoints2 { get; set; }
        public int MidfielderTeamId2 { get; set; }
        public string MidfielderPosition2 { get; set; }
        public string Midfielder3 { get; set; }
        public int MidfielderId3 { get; set; }
        public int MidfielderPoints3 { get; set; }
        public int MidfielderTeamId3 { get; set; }
        public string MidfielderPosition3 { get; set; }
        public string Midfielder4 { get; set; }
        public int MidfielderId4 { get; set; }
        public int MidfielderPoints4 { get; set; }
        public int MidfielderTeamId4 { get; set; }
        public string MidfielderPosition4 { get; set; }
        public string Midfielder5 { get; set; }
        public int MidfielderId5 { get; set; }
        public int MidfielderPoints5 { get; set; }
        public int MidfielderTeamId5 { get; set; }
        public string MidfielderPosition5 { get; set; }

        public string Attacker1 { get; set; }
        public int AttackerId1 { get; set; }
        public int AttackerPoints1 { get; set; }
        public int AttackerTeamId1 { get; set; }
        public string AttackerPosition1 { get; set; }
        public string Attacker2 { get; set; }
        public int AttackerId2 { get; set; }
        public int AttackerPoints2 { get; set; }
        public int AttackerTeamId2 { get; set; }
        public string AttackerPosition2 { get; set; }
        public string Attacker3 { get; set; }
        public int AttackerId3 { get; set; }
        public int AttackerPoints3 { get; set; }
        public int AttackerTeamId3 { get; set; }
        public string AttackerPosition3 { get; set; }
    }
}