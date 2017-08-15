namespace DaSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Photos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ProfilePic", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ProfilePic");
        }
    }
}
