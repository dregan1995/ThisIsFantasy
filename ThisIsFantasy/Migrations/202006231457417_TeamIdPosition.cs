namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamIdPosition : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FantasyTeams", "TeamSelectedId1", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TeamSelectedId2", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TeamSelectedId3", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TeamSelectedId4", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TeamSelectedId5", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TeamSelectedId6", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TeamSelectedId7", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TeamSelectedId8", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TeamSelectedId9", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TeamSelectedId10", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TeamSelectedId11", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TeamSelectedId12", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TeamSelectedId13", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TeamSelectedId14", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TeamSelectedId15", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "position1", c => c.String());
            AddColumn("dbo.FantasyTeams", "position2", c => c.String());
            AddColumn("dbo.FantasyTeams", "position3", c => c.String());
            AddColumn("dbo.FantasyTeams", "position4", c => c.String());
            AddColumn("dbo.FantasyTeams", "position5", c => c.String());
            AddColumn("dbo.FantasyTeams", "position6", c => c.String());
            AddColumn("dbo.FantasyTeams", "position7", c => c.String());
            AddColumn("dbo.FantasyTeams", "position8", c => c.String());
            AddColumn("dbo.FantasyTeams", "position9", c => c.String());
            AddColumn("dbo.FantasyTeams", "position10", c => c.String());
            AddColumn("dbo.FantasyTeams", "position11", c => c.String());
            AddColumn("dbo.FantasyTeams", "position12", c => c.String());
            AddColumn("dbo.FantasyTeams", "position13", c => c.String());
            AddColumn("dbo.FantasyTeams", "position14", c => c.String());
            AddColumn("dbo.FantasyTeams", "position15", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FantasyTeams", "position15");
            DropColumn("dbo.FantasyTeams", "position14");
            DropColumn("dbo.FantasyTeams", "position13");
            DropColumn("dbo.FantasyTeams", "position12");
            DropColumn("dbo.FantasyTeams", "position11");
            DropColumn("dbo.FantasyTeams", "position10");
            DropColumn("dbo.FantasyTeams", "position9");
            DropColumn("dbo.FantasyTeams", "position8");
            DropColumn("dbo.FantasyTeams", "position7");
            DropColumn("dbo.FantasyTeams", "position6");
            DropColumn("dbo.FantasyTeams", "position5");
            DropColumn("dbo.FantasyTeams", "position4");
            DropColumn("dbo.FantasyTeams", "position3");
            DropColumn("dbo.FantasyTeams", "position2");
            DropColumn("dbo.FantasyTeams", "position1");
            DropColumn("dbo.FantasyTeams", "TeamSelectedId15");
            DropColumn("dbo.FantasyTeams", "TeamSelectedId14");
            DropColumn("dbo.FantasyTeams", "TeamSelectedId13");
            DropColumn("dbo.FantasyTeams", "TeamSelectedId12");
            DropColumn("dbo.FantasyTeams", "TeamSelectedId11");
            DropColumn("dbo.FantasyTeams", "TeamSelectedId10");
            DropColumn("dbo.FantasyTeams", "TeamSelectedId9");
            DropColumn("dbo.FantasyTeams", "TeamSelectedId8");
            DropColumn("dbo.FantasyTeams", "TeamSelectedId7");
            DropColumn("dbo.FantasyTeams", "TeamSelectedId6");
            DropColumn("dbo.FantasyTeams", "TeamSelectedId5");
            DropColumn("dbo.FantasyTeams", "TeamSelectedId4");
            DropColumn("dbo.FantasyTeams", "TeamSelectedId3");
            DropColumn("dbo.FantasyTeams", "TeamSelectedId2");
            DropColumn("dbo.FantasyTeams", "TeamSelectedId1");
        }
    }
}
