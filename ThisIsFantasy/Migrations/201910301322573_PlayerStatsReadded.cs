namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayerStatsReadded : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.PlayerId, cascadeDelete: true)
                .Index(t => t.PlayerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerStats", "PlayerId", "dbo.Players");
            DropIndex("dbo.PlayerStats", new[] { "PlayerId" });
            DropTable("dbo.PlayerStats");
        }
    }
}
