namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FantasyTeamsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FantasyTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerName1 = c.String(),
                        PlayerStatId1 = c.Int(nullable: false),
                        TotalPoints1 = c.Int(nullable: false),
                        PlayerName2 = c.String(),
                        PlayerStatId2 = c.Int(nullable: false),
                        TotalPoints2 = c.Int(nullable: false),
                        PlayerName3 = c.String(),
                        PlayerStatId3 = c.Int(nullable: false),
                        TotalPoints3 = c.Int(nullable: false),
                        PlayerName4 = c.String(),
                        PlayerStatId4 = c.Int(nullable: false),
                        TotalPoints4 = c.Int(nullable: false),
                        PlayerName5 = c.String(),
                        PlayerStatId5 = c.Int(nullable: false),
                        TotalPoints5 = c.Int(nullable: false),
                        PlayerNam6 = c.String(),
                        PlayerStatId6 = c.Int(nullable: false),
                        TotalPoints6 = c.Int(nullable: false),
                        PlayerName7 = c.String(),
                        PlayerStatId7 = c.Int(nullable: false),
                        TotalPoints7 = c.Int(nullable: false),
                        PlayerName8 = c.String(),
                        PlayerStatId8 = c.Int(nullable: false),
                        TotalPoints8 = c.Int(nullable: false),
                        PlayerName9 = c.String(),
                        PlayerStatId9 = c.Int(nullable: false),
                        TotalPoints9 = c.Int(nullable: false),
                        PlayerName10 = c.String(),
                        PlayerStatId10 = c.Int(nullable: false),
                        TotalPoints10 = c.Int(nullable: false),
                        PlayerName11 = c.String(),
                        PlayerStatId11 = c.Int(nullable: false),
                        TotalPoints11 = c.Int(nullable: false),
                        PlayerName12 = c.String(),
                        PlayerStatId12 = c.Int(nullable: false),
                        TotalPoints12 = c.Int(nullable: false),
                        PlayerName13 = c.String(),
                        PlayerStatId13 = c.Int(nullable: false),
                        TotalPoints13 = c.Int(nullable: false),
                        PlayerName14 = c.String(),
                        PlayerStatId14 = c.Int(nullable: false),
                        TotalPoints14 = c.Int(nullable: false),
                        PlayerName15 = c.String(),
                        PlayerStatId15 = c.Int(nullable: false),
                        TotalPoints15 = c.Int(nullable: false),
                        UserId = c.String(),
                        TeamName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FantasyTeams");
        }
    }
}
