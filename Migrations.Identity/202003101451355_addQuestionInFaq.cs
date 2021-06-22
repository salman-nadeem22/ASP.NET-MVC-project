namespace AptechProject.Migrations.Identity
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addQuestionInFaq : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FAQs", "Question1", c => c.String());
            AddColumn("dbo.FAQs", "Question2", c => c.String());
            AddColumn("dbo.FAQs", "Question3", c => c.String());
            AddColumn("dbo.FAQs", "Question4", c => c.String());
            AddColumn("dbo.FAQs", "Question5", c => c.String());
            AddColumn("dbo.FAQs", "Question6", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FAQs", "Question6");
            DropColumn("dbo.FAQs", "Question5");
            DropColumn("dbo.FAQs", "Question4");
            DropColumn("dbo.FAQs", "Question3");
            DropColumn("dbo.FAQs", "Question2");
            DropColumn("dbo.FAQs", "Question1");
        }
    }
}
