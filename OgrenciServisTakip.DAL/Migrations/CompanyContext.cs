namespace OgrenciServisTakip.DAL.Migrations
{
    using OgrenciServisTakip.Model.Company;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class CompanyContext : DbMigrationsConfiguration<DAL.MyContext>
    {
        public CompanyContext()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("System.Data.SqlClient", new CustomSqlServerMigrationSqlGenerator());
        }

        protected override void Seed(DAL.MyContext context)
        {
            context.Companies.Add(new Company
            {
                CompanyName = "Nihat",
                DealerCode = "001"
            });

            context.SaveChanges();

            int companyID = context.Companies.FirstOrDefault(u => u.CompanyName == "Nihat").CompanyID;

            context.Branches.Add(new Branch
            {
                CompanyID = companyID,
                BranchName = "Merkez"
            });

            context.SaveChanges();

            int branchID = context.Branches.FirstOrDefault(u => u.BranchName == "Merkez").BranchID;

            List<User> listUsers = new List<User>
            {
                new User
                {
                    BranchID = branchID,
                    CompanyID = companyID,
                    Name = "Nihat",
                    Surname = "Çelik",
                    UserName = "Nihat",
                    Password = "123"
                },
                new User
                {
                    BranchID = branchID,
                    CompanyID = companyID,
                    Name = "Kemal",
                    Surname = "Keskin",
                    UserName = "Kemal",
                    Password = "123"
                }
            };
            context.Users.AddRange(listUsers);
        }


        //  This method will be called after migrating to the latest version.

        //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
        //  to avoid creating duplicate seed data.
    }
}

