namespace AptechProject.Migrations.Identity
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        StudentId = c.String(),
                        Points = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        RollNo = c.String(nullable: false),
                        City = c.String(nullable: false, maxLength: 20),
                        Country = c.String(nullable: false, maxLength: 20),
                        Contact = c.String(nullable: false, maxLength: 20),
                        Telephone = c.String(nullable: false, maxLength: 20),
                        DateOFBirth = c.String(nullable: false, maxLength: 20),
                        competition_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Competitions", t => t.competition_Id)
                .Index(t => t.competition_Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CourseName = c.String(nullable: false, maxLength: 20),
                        hours = c.String(nullable: false),
                        CourseFor = c.String(nullable: false, maxLength: 20),
                        TotalMarks = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 30),
                        City = c.String(nullable: false, maxLength: 20),
                        Contact = c.String(nullable: false, maxLength: 20),
                        NIC = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rankings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable: false),
                        SurveyName = c.String(nullable: false),
                        SurveyId = c.Int(nullable: false),
                        StudentRollNo = c.Int(nullable: false),
                        Rank = c.String(nullable: false),
                        Prize = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SurveyName = c.String(nullable: false, maxLength: 15),
                        CreatedBy = c.String(nullable: false, maxLength: 50),
                        StudentID = c.String(nullable: false, maxLength: 15),
                        Survey_1 = c.String(nullable: false, maxLength: 400),
                        Survey_1_option_1 = c.String(nullable: false, maxLength: 100),
                        Survey_1_option_2 = c.String(nullable: false, maxLength: 100),
                        Survey_1_option_3 = c.String(nullable: false, maxLength: 100),
                        Survey_2 = c.String(nullable: false, maxLength: 400),
                        Survey_2_option_1 = c.String(nullable: false, maxLength: 100),
                        Survey_2_option_2 = c.String(nullable: false, maxLength: 100),
                        Survey_2_option_3 = c.String(nullable: false, maxLength: 100),
                        Survey_3 = c.String(nullable: false, maxLength: 400),
                        Survey_3_option_1 = c.String(nullable: false, maxLength: 100),
                        Survey_3_option_2 = c.String(nullable: false, maxLength: 100),
                        Survey_3_option_3 = c.String(nullable: false, maxLength: 100),
                        Survey_4 = c.String(nullable: false, maxLength: 400),
                        Survey_4_option_1 = c.String(nullable: false, maxLength: 100),
                        Survey_4_option_2 = c.String(nullable: false, maxLength: 100),
                        Survey_4_option_3 = c.String(nullable: false, maxLength: 100),
                        Survey_5 = c.String(nullable: false, maxLength: 400),
                        Survey_5_option_1 = c.String(nullable: false, maxLength: 100),
                        Survey_5_option_2 = c.String(nullable: false, maxLength: 100),
                        Survey_5_option_3 = c.String(nullable: false, maxLength: 100),
                        dateTime = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Winners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameOfWinner = c.String(nullable: false),
                        StudentRollNo = c.String(nullable: false),
                        SurveyName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "competition_Id", "dbo.Competitions");
            DropIndex("dbo.Students", new[] { "competition_Id" });
            DropTable("dbo.Winners");
            DropTable("dbo.Surveys");
            DropTable("dbo.Rankings");
            DropTable("dbo.Faculties");
            DropTable("dbo.Courses");
            DropTable("dbo.Students");
            DropTable("dbo.Competitions");
        }
    }
}
