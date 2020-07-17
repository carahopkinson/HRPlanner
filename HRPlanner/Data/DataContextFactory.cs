using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.Data
{
    public class DataContextFactory : IDataContextFactory
    {
        public IDataContext CreateContext()
        {
            var contextOptionsBuilder = new DbContextOptionsBuilder();
            contextOptionsBuilder.UseSqlServer("Data Source=R2CLT057;Initial Catalog=HRPlanner;Integrated Security=True");
            return new DataContext(contextOptionsBuilder.Options);
        }
    }
}
