namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNewProperties : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.StudentDetails", "Mobile");
            DropColumn("dbo.StudentDetails", "Institute");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentDetails", "Institute", c => c.String(nullable: false));
            AddColumn("dbo.StudentDetails", "Mobile", c => c.Int(nullable: false));
        }
    }
}
