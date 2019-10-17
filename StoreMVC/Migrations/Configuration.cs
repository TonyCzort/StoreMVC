namespace StoreMVC.Migrations
{
    using StoreMVC.DAL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<StoreMVC.DAL.EquipmentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "StoreMVC.DAL.EquipmentContext";
        }

        protected override void Seed(StoreMVC.DAL.EquipmentContext context)
        {
            EquipmentInitializer.SeedEquimpentData(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
