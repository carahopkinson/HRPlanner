using HRPlanner.Data.Entities;
using HRPlanner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.Business.Factories
{
    public interface IUserFactory
    {
        UserViewModel ToViewModel(Users user);
        List<UserViewModel> ToViewModelList(List<Users> users);
        Users ToModel(UserViewModel userViewModel);
    }
}
