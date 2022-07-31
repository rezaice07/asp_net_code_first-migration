using DotNETCodeFirstMigration.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DotNETCodeFirstMigration
{
    public class DotNETCodeFirstMigrationContext:DbContext
    {
        public DotNETCodeFirstMigrationContext():base("DotNETCodeFirstMigrationContext")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}