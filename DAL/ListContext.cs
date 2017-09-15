using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StreamCar.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace StreamCar.DAL
{
    public class ListContext : DbContext
    {
        public ListContext() : base("ListContext")
        {
        }

        public DbSet<Car> Car { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}