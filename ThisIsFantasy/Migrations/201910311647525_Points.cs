namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Points : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlayerStats", "WeeklyPoints", c => c.Int(nullable: false));
            AddColumn("dbo.PlayerStats", "TotalPoints", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PlayerStats", "TotalPoints");
            DropColumn("dbo.PlayerStats", "WeeklyPoints");
        }
    }
}
