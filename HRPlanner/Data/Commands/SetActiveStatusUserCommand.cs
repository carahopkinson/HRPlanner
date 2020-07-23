using HRPlanner.Data.Entities;
using HRPlanner.Data.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.Data.Commands
{
    public class SetActiveStatusUserCommand : ISetActiveStatusUserCommand
    {
        private readonly IDataContextFactory dataContextFactory;
        private readonly IGetUserByIdQuery getUsersByIdQuery;
        public SetActiveStatusUserCommand(IDataContextFactory dataContextFactory, IGetUserByIdQuery getUsersByIdQuery)
        {
            this.dataContextFactory = dataContextFactory;
            this.getUsersByIdQuery = getUsersByIdQuery;
        }

        public bool Execute(int userId, bool active)
        {
            var context = dataContextFactory.CreateContext();
            var userEntity = getUsersByIdQuery.Execute(userId);

            userEntity.Active = active;

            context.Users.Update(userEntity);
            context.SaveChanges(true);
            return true;
        }
    }
}
