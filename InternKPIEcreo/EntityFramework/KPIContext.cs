namespace InternKPIEcreo.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class KPIContext : DbContext
    {
        // Your context has been configured to use a 'KPIContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'InternKPIEcreo.EntityFramework.KPIContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'KPIContext' 
        // connection string in the application configuration file.
        public KPIContext()
            : base("name=KPIContext")
        {
            //Create database always, even If exists
            Database.SetInitializer<KPIContext>(new DropCreateDatabaseIfModelChanges<KPIContext>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.


        public DbSet<Company> Companies { get; set; }
        public DbSet<Projects> Projectses { get; set; }
        public DbSet<ProjectTaskList> ProjectTaskLists { get; set; }
        public DbSet<TimeOfTasks> TimeOfTaskses { get; set; }
        public DbSet<TimeTotal> TimeTotals { get; set; }

    }
  
}