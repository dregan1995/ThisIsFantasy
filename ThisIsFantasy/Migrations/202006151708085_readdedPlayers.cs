namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class readdedPlayers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FantasyTeams", "PlayerStatId1", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TotalPoints1", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "PlayerName2", c => c.String());
            AddColumn("dbo.FantasyTeams", "PlayerStatId2", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TotalPoints2", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "PlayerName3", c => c.String());
            AddColumn("dbo.FantasyTeams", "PlayerStatId3", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TotalPoints3", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "PlayerName4", c => c.String());
            AddColumn("dbo.FantasyTeams", "PlayerStatId4", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TotalPoints4", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "PlayerName5", c => c.String());
            AddColumn("dbo.FantasyTeams", "PlayerStatId5", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TotalPoints5", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "PlayerNam6", c => c.String());
            AddColumn("dbo.FantasyTeams", "PlayerStatId6", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TotalPoints6", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "PlayerName7", c => c.String());
            AddColumn("dbo.FantasyTeams", "PlayerStatId7", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TotalPoints7", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "PlayerName8", c => c.String());
            AddColumn("dbo.FantasyTeams", "PlayerStatId8", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TotalPoints8", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "PlayerName9", c => c.String());
            AddColumn("dbo.FantasyTeams", "PlayerStatId9", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TotalPoints9", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "PlayerName10", c => c.String());
            AddColumn("dbo.FantasyTeams", "PlayerStatId10", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TotalPoints10", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "PlayerName11", c => c.String());
            AddColumn("dbo.FantasyTeams", "PlayerStatId11", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TotalPoints11", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "PlayerName12", c => c.String());
            AddColumn("dbo.FantasyTeams", "PlayerStatId12", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TotalPoints12", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "PlayerName13", c => c.String());
            AddColumn("dbo.FantasyTeams", "PlayerStatId13", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TotalPoints13", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "PlayerName14", c => c.String());
            AddColumn("dbo.FantasyTeams", "PlayerStatId14", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TotalPoints14", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "PlayerName15", c => c.String());
            AddColumn("dbo.FantasyTeams", "PlayerStatId15", c => c.Int(nullable: false));
            AddColumn("dbo.FantasyTeams", "TotalPoints15", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FantasyTeams", "TotalPoints15");
            DropColumn("dbo.FantasyTeams", "PlayerStatId15");
            DropColumn("dbo.FantasyTeams", "PlayerName15");
            DropColumn("dbo.FantasyTeams", "TotalPoints14");
            DropColumn("dbo.FantasyTeams", "PlayerStatId14");
            DropColumn("dbo.FantasyTeams", "PlayerName14");
            DropColumn("dbo.FantasyTeams", "TotalPoints13");
            DropColumn("dbo.FantasyTeams", "PlayerStatId13");
            DropColumn("dbo.FantasyTeams", "PlayerName13");
            DropColumn("dbo.FantasyTeams", "TotalPoints12");
            DropColumn("dbo.FantasyTeams", "PlayerStatId12");
            DropColumn("dbo.FantasyTeams", "PlayerName12");
            DropColumn("dbo.FantasyTeams", "TotalPoints11");
            DropColumn("dbo.FantasyTeams", "PlayerStatId11");
            DropColumn("dbo.FantasyTeams", "PlayerName11");
            DropColumn("dbo.FantasyTeams", "TotalPoints10");
            DropColumn("dbo.FantasyTeams", "PlayerStatId10");
            DropColumn("dbo.FantasyTeams", "PlayerName10");
            DropColumn("dbo.FantasyTeams", "TotalPoints9");
            DropColumn("dbo.FantasyTeams", "PlayerStatId9");
            DropColumn("dbo.FantasyTeams", "PlayerName9");
            DropColumn("dbo.FantasyTeams", "TotalPoints8");
            DropColumn("dbo.FantasyTeams", "PlayerStatId8");
            DropColumn("dbo.FantasyTeams", "PlayerName8");
            DropColumn("dbo.FantasyTeams", "TotalPoints7");
            DropColumn("dbo.FantasyTeams", "PlayerStatId7");
            DropColumn("dbo.FantasyTeams", "PlayerName7");
            DropColumn("dbo.FantasyTeams", "TotalPoints6");
            DropColumn("dbo.FantasyTeams", "PlayerStatId6");
            DropColumn("dbo.FantasyTeams", "PlayerNam6");
            DropColumn("dbo.FantasyTeams", "TotalPoints5");
            DropColumn("dbo.FantasyTeams", "PlayerStatId5");
            DropColumn("dbo.FantasyTeams", "PlayerName5");
            DropColumn("dbo.FantasyTeams", "TotalPoints4");
            DropColumn("dbo.FantasyTeams", "PlayerStatId4");
            DropColumn("dbo.FantasyTeams", "PlayerName4");
            DropColumn("dbo.FantasyTeams", "TotalPoints3");
            DropColumn("dbo.FantasyTeams", "PlayerStatId3");
            DropColumn("dbo.FantasyTeams", "PlayerName3");
            DropColumn("dbo.FantasyTeams", "TotalPoints2");
            DropColumn("dbo.FantasyTeams", "PlayerStatId2");
            DropColumn("dbo.FantasyTeams", "PlayerName2");
            DropColumn("dbo.FantasyTeams", "TotalPoints1");
            DropColumn("dbo.FantasyTeams", "PlayerStatId1");
        }
    }
}
