using HRPlanner.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.Data
{
    public class DataContext : DbContext, IDataContext
    {
        //Constructor
        public DataContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Users> Users { get; set; }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
    }
}
