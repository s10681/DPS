namespace DPS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using DPS.Model;

    public class DPSModelContext : DbContext
    {
        // Your context has been configured to use a 'DPSModelContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DPS.DPSModelContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DPSModelContext' 
        // connection string in the application configuration file.
        public DPSModelContext()
            : base("name=DPSModelContext")
        {
        }


        public virtual DbSet<Kontrahent> Kontrahent { get; set; }
        public virtual DbSet<TypKontrahenta> TypKontrahenta { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }


    }


}