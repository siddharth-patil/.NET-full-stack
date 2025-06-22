namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentDetails", "Mobile", c => c.Int(nullable: false));
            AddColumn("dbo.StudentDetails", "Institute", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentDetails", "Institute");
            DropColumn("dbo.StudentDetails", "Mobile");
        }
    }
}
