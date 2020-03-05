namespace EntTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Emp4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "PhoneNumber", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Employees", "LastName", c => c.String());
        }
    }
}
