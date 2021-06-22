namespace AptechProject.Migrations.Identity
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class authenticationToUserRegister : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Authentication", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Authentication");
        }
    }
}
