namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class warningColumnAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlayerStats", "Warning", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PlayerStats", "Warning");
        }
    }
}
