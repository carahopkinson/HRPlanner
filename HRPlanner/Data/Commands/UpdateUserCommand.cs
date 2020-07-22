using HRPlanner.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.Data.Commands
{
    public class UpdateUserCommand : IUpdateUserCommand
    {
        private readonly IDataContextFactory dataContextFactory;
        public UpdateUserCommand(IDataContextFactory dataContextFactory)
        {
            this.dataContextFactory = dataContextFactory;
        }

        public bool Execute(Users user)
        {
            var context = dataContextFactory.CreateContext();
            context.Users.Update(user);
            context.SaveChanges(true);
            return true;
        }
    }
}
