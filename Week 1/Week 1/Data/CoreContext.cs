using System;
using System.Collections.Generic;
using Week_1.Models;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Week_1.Data
{
    public class CoreContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public CoreContext()
            : base("CoreContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}