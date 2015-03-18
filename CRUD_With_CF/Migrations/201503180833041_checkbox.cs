namespace CRUD_With_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class checkbox : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Emps", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Emps", "IsActive");
        }
    }
}
