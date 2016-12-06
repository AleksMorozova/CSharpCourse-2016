namespace Server
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DomainModel;
    using Migrations;

    public partial class ApplicationContext : DbContext
    {
        static ApplicationContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationContext, Configuration>());
        }

        public ApplicationContext()
            : base("name=ApplicationContext")
        {
            
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
