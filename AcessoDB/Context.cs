using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AcessoDB
{
    class Context:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<AspNetRoles>().ToTable("AspNetRoles");
        }

        //public DbSet<AspNetRoles> AspNetRoles { get; set; }
    }
}
