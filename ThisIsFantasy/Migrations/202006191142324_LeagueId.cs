namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LeagueId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FantasyTeams", "LeagueId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FantasyTeams", "LeagueId");
        }
    }
}
