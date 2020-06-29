namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeamName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "TeamName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "TeamName");
        }
    }
}
