namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentDetails",
                c => new
                    {
                        Roll = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 30),
                        Gender = c.String(nullable: false, maxLength: 10),
                        Email = c.String(nullable: false, maxLength: 200),
                        Qualification = c.String(nullable: false, maxLength: 50),
                        DateofBirth = c.DateTime(nullable: false),
                        Percentage = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Roll);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentDetails");
        }
    }
}
