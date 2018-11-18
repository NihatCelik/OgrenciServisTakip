namespace OgrenciServisTakip.DAL
{
    using OgrenciServisTakip.Model.Company;
    using System.Data.Entity; 

    public class CompanyContext : DbContext
    {
        // Your context has been configured to use a 'CompanyContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'OgrenciServisTakip.DAL.CompanyContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CompanyContext' 
        // connection string in the application configuration file.
        public CompanyContext()
            : base("name=DbConnectionString")
        {
            Database.SetInitializer<CompanyContext>(null);
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<User> Users { get; set; }
         
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}