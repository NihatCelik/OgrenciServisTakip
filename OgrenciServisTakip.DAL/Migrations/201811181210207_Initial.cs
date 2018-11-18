namespace OgrenciServisTakip.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblBranch",
                c => new
                    {
                        BranchID = c.Int(nullable: false, identity: true),
                        CompanyID = c.Int(nullable: false),
                        BranchName = c.String(nullable: false, maxLength: 25),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BranchID)
                .ForeignKey("dbo.tblCompany", t => t.CompanyID, cascadeDelete: true)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.tblUser",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        BranchID = c.Int(nullable: false),
                        CompanyID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 15),
                        Name = c.String(nullable: false, maxLength: 15),
                        Surname = c.String(maxLength: 15),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.tblBranch", t => t.BranchID, cascadeDelete: true)
                .Index(t => t.BranchID);
            
            CreateTable(
                "dbo.tblCompany",
                c => new
                    {
                        CompanyID = c.Int(nullable: false, identity: true),
                        DealerCode = c.String(nullable: false, maxLength: 5),
                        CompanyName = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblBranch", "CompanyID", "dbo.tblCompany");
            DropForeignKey("dbo.tblUser", "BranchID", "dbo.tblBranch");
            DropIndex("dbo.tblUser", new[] { "BranchID" });
            DropIndex("dbo.tblBranch", new[] { "CompanyID" });
            DropTable("dbo.tblCompany");
            DropTable("dbo.tblUser");
            DropTable("dbo.tblBranch");
        }
    }
}
