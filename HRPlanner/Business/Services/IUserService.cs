using HRPlanner.ViewModels;
using System.Collections.Generic;

namespace HRPlanner.Business
{
    public interface IUserService
    {
        List<UserViewModel> Get();
        UserViewModel GetById(int id);
        bool Edit(UserViewModel model);
        bool SetActiveStatus(int userId, bool active);
    }
}