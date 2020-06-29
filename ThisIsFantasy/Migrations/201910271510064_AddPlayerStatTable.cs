namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPlayerStatTable : DbMigration
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
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PlayerStats");
        }
    }
}
