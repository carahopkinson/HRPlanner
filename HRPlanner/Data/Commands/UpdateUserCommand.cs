﻿using HRPlanner.Data.Entities;
using HRPlanner.Data.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.Data.Commands
{
    public class UpdateUserCommand : IUpdateUserCommand
    {
        private readonly IDataContextFactory dataContextFactory;
        private readonly IGetUserByIdQuery getUsersByIdQuery;
        public UpdateUserCommand(IDataContextFactory dataContextFactory, IGetUserByIdQuery getUsersByIdQuery)
        {
            this.dataContextFactory = dataContextFactory;
            this.getUsersByIdQuery = getUsersByIdQuery;
        }

        public bool Execute(Users user)
        {
            var context = dataContextFactory.CreateContext();
            var userEntity = getUsersByIdQuery.Execute(user.UserId);

            userEntity.FirstName = user.FirstName;
            userEntity.LastName = user.LastName;
            userEntity.UserName = user.UserName;
            userEntity.Admin = user.Admin;
            userEntity.Holidays = user.Holidays;

            context.Users.Update(userEntity);
            context.SaveChanges(true);
            return true;
        }
    }
}
