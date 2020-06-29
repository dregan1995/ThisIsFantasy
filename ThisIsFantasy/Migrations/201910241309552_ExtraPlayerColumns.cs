namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtraPlayerColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Position", c => c.String());
            AddColumn("dbo.Players", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.Players", "CountryOfBirth", c => c.String());
            AddColumn("dbo.Players", "Nationality", c => c.String());
            AddColumn("dbo.Players", "ShirtNumber", c => c.Int());
            AddColumn("dbo.Players", "Role", c => c.String());
            AddColumn("dbo.Players", "LastUpdated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "LastUpdated");
            DropColumn("dbo.Players", "Role");
            DropColumn("dbo.Players", "ShirtNumber");
            DropColumn("dbo.Players", "Nationality");
            DropColumn("dbo.Players", "CountryOfBirth");
            DropColumn("dbo.Players", "DateOfBirth");
            DropColumn("dbo.Players", "Position");
        }
    }
}
