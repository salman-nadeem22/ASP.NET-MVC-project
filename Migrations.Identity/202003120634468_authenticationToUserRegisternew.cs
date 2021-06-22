namespace AptechProject.Migrations.Identity
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class authenticationToUserRegisternew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "AuthenticationType", c => c.String(nullable: false));
            DropColumn("dbo.AspNetUsers", "Authentication");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Authentication", c => c.String());
            DropColumn("dbo.AspNetUsers", "AuthenticationType");
        }
    }
}
