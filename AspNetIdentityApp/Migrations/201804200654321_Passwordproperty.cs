namespace AspNetIdentityApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Passwordproperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Password");
        }
    }
}
