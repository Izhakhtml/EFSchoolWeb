namespace EFSchoolWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SchoolMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameOfSchool = c.String(),
                        Street = c.String(),
                        IfState = c.Boolean(nullable: false),
                        NumberOfStudents = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Schools");
        }
    }
}
