namespace CRUD_With_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRUDDropDown : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emps",
                c => new
                    {
                        EmpNo = c.Int(nullable: false, identity: true),
                        EmpName = c.String(nullable: false, maxLength: 20),
                        EmpAdd = c.String(nullable: false, maxLength: 50),
                        EmpSal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpNo);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CntCode = c.Int(nullable: false, identity: true),
                        CntName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CntCode);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StaCode = c.Int(nullable: false, identity: true),
                        StaName = c.String(nullable: false),
                        CntCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StaCode)
                .ForeignKey("dbo.Countries", t => t.CntCode, cascadeDelete: true)
                .Index(t => t.CntCode);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CtyCode = c.Int(nullable: false, identity: true),
                        CtyName = c.String(nullable: false),
                        StaCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CtyCode)
                .ForeignKey("dbo.States", t => t.StaCode, cascadeDelete: true)
                .Index(t => t.StaCode);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Cities", new[] { "StaCode" });
            DropIndex("dbo.States", new[] { "CntCode" });
            DropForeignKey("dbo.Cities", "StaCode", "dbo.States");
            DropForeignKey("dbo.States", "CntCode", "dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.States");
            DropTable("dbo.Countries");
            DropTable("dbo.Emps");
        }
    }
}
