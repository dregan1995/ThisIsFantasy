namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastUpdateRenamed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "LastUpdated", c => c.DateTime(nullable: false));
            DropColumn("dbo.Teams", "LastUpdate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "LastUpdate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Teams", "LastUpdated");
        }
    }
}
