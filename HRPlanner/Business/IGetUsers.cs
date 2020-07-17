using HRPlanner.Models;
using System.Collections.Generic;

namespace HRPlanner.Business
{
    public interface IGetUsers
    {
        List<UserModel> Get();
    }
}