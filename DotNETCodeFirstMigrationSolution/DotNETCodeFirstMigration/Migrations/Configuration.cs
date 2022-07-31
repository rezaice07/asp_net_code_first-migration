namespace DotNETCodeFirstMigration.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DotNETCodeFirstMigration.DotNETCodeFirstMigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DotNETCodeFirstMigration.DotNETCodeFirstMigrationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Products.Add(new Models.Product { Title = "Saree",  Price = 4521 });
            context.SaveChanges();
        }
    }
}
