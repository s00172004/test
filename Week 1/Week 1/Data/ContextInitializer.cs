using System;
using System.Collections.Generic;
using Week_1.Models;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace Week_1.Data
{
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<CoreContext>
    {
        protected override void Seed(CoreContext context)
        {
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