namespace AptechProject.Migrations.Identity
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class authenticationToUserRegisterDefault : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "AuthenticationType", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "AuthenticationType", c => c.String(nullable: false));
        }
    }
}
