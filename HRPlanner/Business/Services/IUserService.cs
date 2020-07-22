using HRPlanner.ViewModels;
using System.Collections.Generic;

namespace HRPlanner.Business
{
    public interface IUserService
    {
        List<UserViewModel> Get();
        UserViewModel GetById(int id);
    }
}