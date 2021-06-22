namespace AptechProject.Migrations.Identity
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class faq : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FAQs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FAQ1 = c.String(),
                        FAQ2 = c.String(),
                        FAQ3 = c.String(),
                        FAQ4 = c.String(),
                        FAQ5 = c.String(),
                        FAQ6 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FAQs");
        }
    }
}
