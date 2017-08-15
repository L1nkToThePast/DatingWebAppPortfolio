namespace DaSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class photosdb2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        Key = c.Int(nullable: false, identity: true),
                        EmailId = c.String(maxLength: 128),
                        PathId = c.String(),
                    })
                .PrimaryKey(t => t.Key)
                .ForeignKey("dbo.AspNetUsers", t => t.EmailId)
                .Index(t => t.EmailId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Photos", "EmailId", "dbo.AspNetUsers");
            DropIndex("dbo.Photos", new[] { "EmailId" });
            DropTable("dbo.Photos");
        }
    }
}
