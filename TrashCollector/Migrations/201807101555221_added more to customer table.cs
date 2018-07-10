namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmoretocustomertable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Email", c => c.String());
            AddColumn("dbo.Customers", "DateOfBirth", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Email");
            DropColumn("dbo.Customers", "DateOfBirth");
            DropColumn("dbo.Customers", "Email");
        }
    }
}
