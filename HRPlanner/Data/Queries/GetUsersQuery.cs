﻿using HRPlanner.Data.Entities;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.Data.Queries
{
    public class GetUsersQuery : IGetUsersQuery
    {
        private readonly IDataContextFactory dataContextFactory;
        public GetUsersQuery(IDataContextFactory dataContextFactory)
        {
            this.dataContextFactory = dataContextFactory;
        }

        public List<Users> Execute()
        {
            var context = dataContextFactory.CreateContext();
            return context.Users
                .Where(x => x.Active)
                .ToList();
        }
    }
}