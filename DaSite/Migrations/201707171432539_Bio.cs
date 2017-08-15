namespace DaSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Toption", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "Tseeking", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "Bio", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Bio");
            DropColumn("dbo.AspNetUsers", "Tseeking");
            DropColumn("dbo.AspNetUsers", "Toption");
        }
    }
}
