using HRPlanner.Data;
using HRPlanner.Data.Queries;
using HRPlanner.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.Business
{
    public class GetUsers : IGetUsers
    {
        private readonly IGetUsersQuery getUsersQuery;

        public GetUsers(IGetUsersQuery getUsersQuery)
        {
            this.getUsersQuery = getUsersQuery;
        }

        public List<UserModel> Get()
        {
            var users = getUsersQuery.Execute();
            var userModel = new List<UserModel>();

            foreach (var user in users)
            {
                userModel.Add(new UserModel()
                {
                    UserId = user.UserId,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserName = user.UserName,
                    Active = user.Active,
                    Admin = user.Admin,
                    Holidays = user.Holidays
                });
            }

            return userModel;
        }
    }
}
