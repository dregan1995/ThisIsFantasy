namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayersTableAddedRepeat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        TeamId = c.Int(nullable: false),
                        TeamUId = c.Guid(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropTable("dbo.Players");
        }
    }
}
