using HRPlanner.Data.Entities;
using HRPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.Data.Queries
{
    public class GetUserByIdQuery : IGetUserByIdQuery
    {
        private readonly IDataContextFactory dataContextFactory;
        public GetUserByIdQuery(IDataContextFactory dataContextFactory)
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
