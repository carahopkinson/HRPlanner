using HRPlanner.Business.Factories;
using HRPlanner.Data;
using HRPlanner.Data.Commands;
using HRPlanner.Data.Queries;
using HRPlanner.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.Business
{
    public class UserService : IUserService
    {
        private readonly IGetUsersQuery getUsersQuery;
        private readonly IUserFactory userFactory;
        private readonly IUpdateUserCommand updateUserCommand;
        private readonly IGetUserByIdQuery getUserByIdQuery;
        private readonly ISetActiveStatusQuery setActiveStatusQuery;
        private readonly ISetActiveStatusUserCommand setActiveStatusUserCommand;

        public UserService(
            IGetUsersQuery getUsersQuery,
            IUserFactory userFactory,
            IUpdateUserCommand updateUserCommand,
            IGetUserByIdQuery getUserByIdQuery,
            ISetActiveStatusQuery setActiveStatusQuery,
            ISetActiveStatusUserCommand setActiveStatusUserCommand)
        {
            this.getUsersQuery = getUsersQuery;
            this.userFactory = userFactory;
            this.updateUserCommand = updateUserCommand;
            this.getUserByIdQuery = getUserByIdQuery;
            this.setActiveStatusUserCommand = setActiveStatusUserCommand;
            this.setActiveStatusQuery = setActiveStatusQuery;
        }

        public List<UserViewModel> Get()
        {
            var users = getUsersQuery.Execute();
            if (users != null && users.Any())
            {
                return userFactory.ToViewModelList(users);
            }

            return null;
        }

        public UserViewModel GetById(int id)
        {
            var user = getUserByIdQuery.Execute(id);
            if (user != null)
            {
                return userFactory.ToViewModel(user);
            }

            return null;
        }

        public bool Edit(UserViewModel userViewModel)
        {
            var user = userFactory.ToModel(userViewModel);
            updateUserCommand.Execute(user);
            return true;
        }

        public bool SetActiveStatus(int userId, bool active)
        {
            setActiveStatusUserCommand.Execute(userId, active);
            return true;
        }
    }
}
