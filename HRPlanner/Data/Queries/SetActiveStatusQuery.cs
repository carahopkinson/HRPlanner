using HRPlanner.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.Data.Queries
{
    public class SetActiveStatusQuery : ISetActiveStatusQuery
    {
        private readonly IDataContextFactory dataContextFactory;
        public SetActiveStatusQuery(IDataContextFactory dataContextFactory)
        {
            this.dataContextFactory = dataContextFactory;
        }
        public Users Execute(int userId)
        {
            var context = dataContextFactory.CreateContext();
            return context.Users
                .FirstOrDefault(x => x.UserId == userId);
        }
    }
}
