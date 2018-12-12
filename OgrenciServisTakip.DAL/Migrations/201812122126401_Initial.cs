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
                .ForeignKey("dbo.tblCompany", t => t.CompanyID)
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
                .ForeignKey("dbo.tblCompany", t => t.CompanyID)
                .ForeignKey("dbo.tblBranch", t => t.BranchID)
                .Index(t => t.BranchID)
                .Index(t => t.CompanyID);
            
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
            
            CreateTable(
                "dbo.tblPaketFiyat",
                c => new
                    {
                        PaketFiyatID = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 50),
                        Fiyat = c.Double(nullable: false),
                        Aciklama = c.String(nullable: false, maxLength: 150),
                        CompanyID = c.Int(nullable: false),
                        BranchID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PaketFiyatID)
                .ForeignKey("dbo.tblBranch", t => t.BranchID)
                .ForeignKey("dbo.tblCompany", t => t.CompanyID)
                .ForeignKey("dbo.tblUser", t => t.UserID)
                .Index(t => t.CompanyID)
                .Index(t => t.BranchID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.tblSchoolClass",
                c => new
                    {
                        SchoolClassID = c.Int(nullable: false, identity: true),
                        SchoolID = c.Int(nullable: false),
                        ClassName = c.String(nullable: false, maxLength: 15),
                        CompanyID = c.Int(nullable: false),
                        BranchID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SchoolClassID)
                .ForeignKey("dbo.tblBranch", t => t.BranchID)
                .ForeignKey("dbo.tblCompany", t => t.CompanyID)
                .ForeignKey("dbo.tblUser", t => t.UserID)
                .ForeignKey("dbo.tblSchool", t => t.SchoolID)
                .Index(t => t.SchoolID)
                .Index(t => t.CompanyID)
                .Index(t => t.BranchID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.tblSchool",
                c => new
                    {
                        SchoolID = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(nullable: false, maxLength: 50),
                        CompanyID = c.Int(nullable: false),
                        BranchID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SchoolID)
                .ForeignKey("dbo.tblBranch", t => t.BranchID)
                .ForeignKey("dbo.tblCompany", t => t.CompanyID)
                .ForeignKey("dbo.tblUser", t => t.UserID)
                .Index(t => t.CompanyID)
                .Index(t => t.BranchID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblSchoolClass", "SchoolID", "dbo.tblSchool");
            DropForeignKey("dbo.tblSchool", "UserID", "dbo.tblUser");
            DropForeignKey("dbo.tblSchool", "CompanyID", "dbo.tblCompany");
            DropForeignKey("dbo.tblSchool", "BranchID", "dbo.tblBranch");
            DropForeignKey("dbo.tblSchoolClass", "UserID", "dbo.tblUser");
            DropForeignKey("dbo.tblSchoolClass", "CompanyID", "dbo.tblCompany");
            DropForeignKey("dbo.tblSchoolClass", "BranchID", "dbo.tblBranch");
            DropForeignKey("dbo.tblPaketFiyat", "UserID", "dbo.tblUser");
            DropForeignKey("dbo.tblPaketFiyat", "CompanyID", "dbo.tblCompany");
            DropForeignKey("dbo.tblPaketFiyat", "BranchID", "dbo.tblBranch");
            DropForeignKey("dbo.tblUser", "BranchID", "dbo.tblBranch");
            DropForeignKey("dbo.tblUser", "CompanyID", "dbo.tblCompany");
            DropForeignKey("dbo.tblBranch", "CompanyID", "dbo.tblCompany");
            DropIndex("dbo.tblSchool", new[] { "UserID" });
            DropIndex("dbo.tblSchool", new[] { "BranchID" });
            DropIndex("dbo.tblSchool", new[] { "CompanyID" });
            DropIndex("dbo.tblSchoolClass", new[] { "UserID" });
            DropIndex("dbo.tblSchoolClass", new[] { "BranchID" });
            DropIndex("dbo.tblSchoolClass", new[] { "CompanyID" });
            DropIndex("dbo.tblSchoolClass", new[] { "SchoolID" });
            DropIndex("dbo.tblPaketFiyat", new[] { "UserID" });
            DropIndex("dbo.tblPaketFiyat", new[] { "BranchID" });
            DropIndex("dbo.tblPaketFiyat", new[] { "CompanyID" });
            DropIndex("dbo.tblUser", new[] { "CompanyID" });
            DropIndex("dbo.tblUser", new[] { "BranchID" });
            DropIndex("dbo.tblBranch", new[] { "CompanyID" });
            DropTable("dbo.tblSchool");
            DropTable("dbo.tblSchoolClass");
            DropTable("dbo.tblPaketFiyat");
            DropTable("dbo.tblCompany");
            DropTable("dbo.tblUser");
            DropTable("dbo.tblBranch");
        }
    }
}
