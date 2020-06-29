namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedTeamNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Players SET TeamName = 'Arsenal' WHERE TeamId = 57;");
        }
        
        public override void Down()
        {
        }
    }
}
