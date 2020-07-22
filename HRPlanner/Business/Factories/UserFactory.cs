using HRPlanner.Data.Entities;
using HRPlanner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.Business.Factories
{
    public class UserFactory
    {
        public UserViewModel ToViewModel(Users user)
        {
            UserViewModel userViewModel = new UserViewModel() 
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Active = user.Active,
                Admin = user.Admin,
                Holidays = user.Holidays
            };

            return (userViewModel);
        }
    }
}
