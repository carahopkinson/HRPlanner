using HRPlanner.Data.Entities;
using HRPlanner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.Data.Commands
{
    public class CreateUserCommand : ICreateUserCommand
    {
        private readonly IDataContextFactory dataContextFactory;
        public CreateUserCommand(IDataContextFactory dataContextFactory)
        {
            this.dataContextFactory = dataContextFactory;
        }

        public bool Execute(Users user)
        {
            var context = dataContextFactory.CreateContext();
            user.Active = true;
            context.Users.Add(user);
            context.SaveChanges(true);
            return true;
        }
    }
}
