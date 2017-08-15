namespace DaSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Country : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Gender", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Seeking", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Height", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Hair", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Ethnicity", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Country", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Province", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "City", c => c.String());
            AddColumn("dbo.AspNetUsers", "PostalCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "PostalCode");
            DropColumn("dbo.AspNetUsers", "City");
            DropColumn("dbo.AspNetUsers", "Province");
            DropColumn("dbo.AspNetUsers", "Country");
            DropColumn("dbo.AspNetUsers", "Ethnicity");
            DropColumn("dbo.AspNetUsers", "Hair");
            DropColumn("dbo.AspNetUsers", "Height");
            DropColumn("dbo.AspNetUsers", "Seeking");
            DropColumn("dbo.AspNetUsers", "Gender");
        }
    }
}
