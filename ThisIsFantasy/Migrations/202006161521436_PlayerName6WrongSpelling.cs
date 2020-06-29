namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayerName6WrongSpelling : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FantasyTeams", "PlayerName6", c => c.String());
            DropColumn("dbo.FantasyTeams", "PlayerNam6");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FantasyTeams", "PlayerNam6", c => c.String());
            DropColumn("dbo.FantasyTeams", "PlayerName6");
        }
    }
}
