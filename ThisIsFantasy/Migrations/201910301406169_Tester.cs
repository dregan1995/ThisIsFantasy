namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tester : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Emiliano Mart�nez', 3141, 'Mart�nez E.', 0, 0)");
        }
        
        public override void Down()
        {
        }
    }
}
