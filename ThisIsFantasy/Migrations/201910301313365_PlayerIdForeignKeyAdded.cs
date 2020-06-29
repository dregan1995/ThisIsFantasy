namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayerIdForeignKeyAdded : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.PlayerStats", "OwnGoals", c => c.Int(nullable: false));
            //AddColumn("dbo.PlayerStats", "PlayerId", c => c.Int(nullable: false));
            //CreateIndex("dbo.PlayerStats", "PlayerId");
            //AddForeignKey("dbo.PlayerStats", "PlayerId", "dbo.Players", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.PlayerStats", "PlayerId", "dbo.Players");
            //DropIndex("dbo.PlayerStats", new[] { "PlayerId" });
            //DropColumn("dbo.PlayerStats", "PlayerId");
            //DropColumn("dbo.PlayerStats", "OwnGoals");
        }
    }
}
