namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppearancePoints : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlayerStats", "Starter", c => c.Boolean(nullable: false));
            AddColumn("dbo.PlayerStats", "AppearancePoints", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PlayerStats", "AppearancePoints");
            DropColumn("dbo.PlayerStats", "Starter");
        }
    }
}
