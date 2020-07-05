namespace Week_1.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Week_1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Week_1.Data.CoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Week_1.Data.CoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var users = new List<User>
            {
                new User(){FirstName = "Billy", MidName = "Joe", LastName = "McBilly",
                    DOB = DateTime.Parse("1980-01-01")},

            new User()
            {
                FirstName = "John",
                MidName = "Jeff",
                LastName = "Jonathan",
                DOB = DateTime.Parse("1980-01-01")
            }
        };
            users.ForEach(u => context.Users.Add(u));
            base.Seed(context);
        }
    }
}
