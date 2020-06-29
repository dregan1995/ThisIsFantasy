namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayerStatsDropped : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PlayerStats", "PlayerId", "dbo.Players");
            DropIndex("dbo.PlayerStats", new[] { "PlayerId" });
            DropTable("dbo.PlayerStats");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PlayerStats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ApiName = c.String(),
                        Goals = c.Int(nullable: false),
                        OwnGoals = c.Int(nullable: false),
                        PlayerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.PlayerStats", "PlayerId");
            AddForeignKey("dbo.PlayerStats", "PlayerId", "dbo.Players", "Id", cascadeDelete: true);
        }
    }
}
