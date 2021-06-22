namespace AptechProject.Migrations.Identity
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedFaqs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FAQs", "Question", c => c.String());
            AddColumn("dbo.FAQs", "Answer", c => c.String());
            DropColumn("dbo.FAQs", "Question1");
            DropColumn("dbo.FAQs", "Question2");
            DropColumn("dbo.FAQs", "Question3");
            DropColumn("dbo.FAQs", "Question4");
            DropColumn("dbo.FAQs", "Question5");
            DropColumn("dbo.FAQs", "Question6");
            DropColumn("dbo.FAQs", "FAQ1");
            DropColumn("dbo.FAQs", "FAQ2");
            DropColumn("dbo.FAQs", "FAQ3");
            DropColumn("dbo.FAQs", "FAQ4");
            DropColumn("dbo.FAQs", "FAQ5");
            DropColumn("dbo.FAQs", "FAQ6");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FAQs", "FAQ6", c => c.String());
            AddColumn("dbo.FAQs", "FAQ5", c => c.String());
            AddColumn("dbo.FAQs", "FAQ4", c => c.String());
            AddColumn("dbo.FAQs", "FAQ3", c => c.String());
            AddColumn("dbo.FAQs", "FAQ2", c => c.String());
            AddColumn("dbo.FAQs", "FAQ1", c => c.String());
            AddColumn("dbo.FAQs", "Question6", c => c.String());
            AddColumn("dbo.FAQs", "Question5", c => c.String());
            AddColumn("dbo.FAQs", "Question4", c => c.String());
            AddColumn("dbo.FAQs", "Question3", c => c.String());
            AddColumn("dbo.FAQs", "Question2", c => c.String());
            AddColumn("dbo.FAQs", "Question1", c => c.String());
            DropColumn("dbo.FAQs", "Answer");
            DropColumn("dbo.FAQs", "Question");
        }
    }
}
