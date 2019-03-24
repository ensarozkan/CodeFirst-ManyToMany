namespace nt_codeFirsManyToMany.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<nt_codeFirsManyToMany.Universite>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "nt_codeFirsManyToMany.Universite";
        }

        protected override void Seed(nt_codeFirsManyToMany.Universite context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
