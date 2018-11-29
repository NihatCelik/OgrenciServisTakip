namespace OgrenciServisTakip.DAL
{
    using OgrenciServisTakip.Model;
    using OgrenciServisTakip.Model.Company;
    using OgrenciServisTakip.Model.School;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class MyContext : DbContext
    {
        // Your context has been configured to use a 'CompanyContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'OgrenciServisTakip.DAL.CompanyContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CompanyContext' 
        // connection string in the application configuration file.
        public MyContext()
            : base("name=DbConnectionString")
        {
            Database.SetInitializer<MyContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<SchoolClass> SchoolClasses { get; set; }

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