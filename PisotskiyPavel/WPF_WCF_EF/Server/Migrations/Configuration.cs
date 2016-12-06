namespace Server.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Server.ApplicationContext context)
        {
            context.Products.AddOrUpdate(new DomainModel.Product()
            {
                Id = 1,
                Name = "Морковка",
                Price = 2.5,
                Quantity = 12530,
                Location = DomainModel.Location.InStock
            });

            context.Products.AddOrUpdate(new DomainModel.Product()
            {
                Id = 2,
                Name = "Картошка",
                Price = 4.75,
                Quantity = 11320,
                Location = DomainModel.Location.Absent
            });

            context.SaveChanges();
        }
    }
}
