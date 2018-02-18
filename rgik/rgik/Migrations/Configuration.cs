namespace rgik.Migrations
{
    using DAL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<rgik.DAL.rgikContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "rgik.DAL.rgikContext";
        }

        protected override void Seed(rgik.DAL.rgikContext context)
        {
            rgikInitializer.SeedRgikData(context);
        }
    }
}
