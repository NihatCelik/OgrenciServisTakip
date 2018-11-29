namespace OgrenciServisTakip.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class School : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblUser", "BranchID", "dbo.tblBranch");
            DropForeignKey("dbo.tblBranch", "CompanyID", "dbo.tblCompany");
            CreateIndex("dbo.tblUser", "CompanyID");
            AddForeignKey("dbo.tblUser", "CompanyID", "dbo.tblCompany", "CompanyID");
            AddForeignKey("dbo.tblUser", "BranchID", "dbo.tblBranch", "BranchID");
            AddForeignKey("dbo.tblBranch", "CompanyID", "dbo.tblCompany", "CompanyID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblBranch", "CompanyID", "dbo.tblCompany");
            DropForeignKey("dbo.tblUser", "BranchID", "dbo.tblBranch");
            DropForeignKey("dbo.tblUser", "CompanyID", "dbo.tblCompany");
            DropIndex("dbo.tblUser", new[] { "CompanyID" });
            AddForeignKey("dbo.tblBranch", "CompanyID", "dbo.tblCompany", "CompanyID", cascadeDelete: true);
            AddForeignKey("dbo.tblUser", "BranchID", "dbo.tblBranch", "BranchID", cascadeDelete: true);
        }
    }
}
