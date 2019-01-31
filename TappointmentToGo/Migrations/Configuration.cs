namespace TappointmentToGo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<TappointmentToGo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TappointmentToGo.Models.ApplicationDbContext";
        }

        protected override void Seed(TappointmentToGo.Models.ApplicationDbContext context)
        {
            var filePath = AppDomain.CurrentDomain.BaseDirectory + @"..\App_Data\SampleData - .NET.sql";
            context.Database.ExecuteSqlCommand(File.ReadAllText(filePath, Encoding.UTF7));
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
