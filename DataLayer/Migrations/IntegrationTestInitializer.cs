namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    public class IntegrationTestInitializer : DbMigrationsConfiguration<AutoMotiveContext>
    {
        protected override void Seed(AutoMotiveContext context)
        {
            var sqlFiles = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.sql").OrderBy(x => x);

            foreach (string file in sqlFiles)
            {
                context.Database.ExecuteSqlCommand(File.ReadAllText(file));
            }

            base.Seed(context);
        }
    }
}