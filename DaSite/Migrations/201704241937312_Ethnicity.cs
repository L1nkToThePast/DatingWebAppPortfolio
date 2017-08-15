namespace DaSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ethnicity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Gender", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Ethnicity", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Country", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Province", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Province", c => c.Int(nullable: false));
            AlterColumn("dbo.AspNetUsers", "Country", c => c.Int(nullable: false));
            AlterColumn("dbo.AspNetUsers", "Ethnicity", c => c.Int(nullable: false));
            AlterColumn("dbo.AspNetUsers", "Gender", c => c.Int(nullable: false));
        }
    }
}
