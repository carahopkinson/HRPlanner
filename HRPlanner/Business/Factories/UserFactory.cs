using HRPlanner.Data.Entities;
using HRPlanner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.Business.Factories
{
    public class UserFactory : IUserFactory
    {
        public UserViewModel ToViewModel(Users user)
        {
            return new UserViewModel() 
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Active = user.Active,
                Admin = user.Admin,
                Holidays = user.Holidays
            };
        }

        public Users ToModel(UserViewModel userViewModel)
        {
            return new Users()
            {
                UserId = userViewModel.UserId,
                FirstName = userViewModel.FirstName,
                LastName = userViewModel.LastName,
                UserName = userViewModel.UserName,
                Active = userViewModel.Active,
                Admin = userViewModel.Admin,
                Holidays = userViewModel.Holidays
            };
        }

        public List<UserViewModel> ToViewModelList(List<Users> users)
        {
            return users.Select(x => ToViewModel(x)).ToList();
        }
    }
}
