namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SelectedTeamsReadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SelectedTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Goalkeeper1 = c.String(),
                        GoalkeeperId1 = c.Int(nullable: false),
                        GoalkeeperPoints1 = c.Int(nullable: false),
                        GoalkeeperTeamId1 = c.Int(nullable: false),
                        GoalkeeperPosition1 = c.String(),
                        Goalkeeper2 = c.String(),
                        GoalkeeperId2 = c.Int(nullable: false),
                        GoalkeeperPoints2 = c.Int(nullable: false),
                        GoalkeeperTeamId2 = c.Int(nullable: false),
                        GoalkeeperPosition2 = c.String(),
                        Defender1 = c.String(),
                        DefenderId1 = c.Int(nullable: false),
                        DefenderPoints1 = c.Int(nullable: false),
                        DefenderTeamId1 = c.Int(nullable: false),
                        DefenderPosition1 = c.String(),
                        Defender2 = c.String(),
                        DefenderId2 = c.Int(nullable: false),
                        DefenderPoints2 = c.Int(nullable: false),
                        DefenderTeamId2 = c.Int(nullable: false),
                        DefenderPosition2 = c.String(),
                        Defender3 = c.String(),
                        DefenderId3 = c.Int(nullable: false),
                        DefenderPoints3 = c.Int(nullable: false),
                        DefenderTeamId3 = c.Int(nullable: false),
                        DefenderPosition3 = c.String(),
                        Defender4 = c.String(),
                        DefenderId4 = c.Int(nullable: false),
                        DefenderPoints4 = c.Int(nullable: false),
                        DefenderTeamId4 = c.Int(nullable: false),
                        DefenderPosition4 = c.String(),
                        Defender5 = c.String(),
                        DefenderId5 = c.Int(nullable: false),
                        DefenderPoints5 = c.Int(nullable: false),
                        DefenderTeamId5 = c.Int(nullable: false),
                        DefenderPosition5 = c.String(),
                        Midfielder1 = c.String(),
                        MidfielderId1 = c.Int(nullable: false),
                        MidfielderPoints1 = c.Int(nullable: false),
                        MidfielderTeamId1 = c.Int(nullable: false),
                        MidfielderPosition1 = c.String(),
                        Midfielder2 = c.String(),
                        MidfielderId2 = c.Int(nullable: false),
                        MidfielderPoints2 = c.Int(nullable: false),
                        MidfielderTeamId2 = c.Int(nullable: false),
                        MidfielderPosition2 = c.String(),
                        Midfielder3 = c.String(),
                        MidfielderId3 = c.Int(nullable: false),
                        MidfielderPoints3 = c.Int(nullable: false),
                        MidfielderTeamId3 = c.Int(nullable: false),
                        MidfielderPosition3 = c.String(),
                        Midfielder4 = c.String(),
                        MidfielderId4 = c.Int(nullable: false),
                        MidfielderPoints4 = c.Int(nullable: false),
                        MidfielderTeamId4 = c.Int(nullable: false),
                        MidfielderPosition4 = c.String(),
                        Midfielder5 = c.String(),
                        MidfielderId5 = c.Int(nullable: false),
                        MidfielderPoints5 = c.Int(nullable: false),
                        MidfielderTeamId5 = c.Int(nullable: false),
                        MidfielderPosition5 = c.String(),
                        Attacker1 = c.String(),
                        AttackerId1 = c.Int(nullable: false),
                        AttackerPoints1 = c.Int(nullable: false),
                        AttackerTeamId1 = c.Int(nullable: false),
                        AttackerPosition1 = c.String(),
                        Attacker2 = c.String(),
                        AttackerId2 = c.Int(nullable: false),
                        AttackerPoints2 = c.Int(nullable: false),
                        AttackerTeamId2 = c.Int(nullable: false),
                        AttackerPosition2 = c.String(),
                        Attacker3 = c.String(),
                        AttackerId3 = c.Int(nullable: false),
                        AttackerPoints3 = c.Int(nullable: false),
                        AttackerTeamId3 = c.Int(nullable: false),
                        AttackerPosition3 = c.String(),
                        UserId = c.String(),
                        TeamName = c.String(),
                        LeagueId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SelectedTeams");
        }
    }
}
