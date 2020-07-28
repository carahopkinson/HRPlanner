using HRPlanner.Data.Entities;
using System.Collections.Generic;

namespace HRPlanner.Data.Queries
{
    public interface IGetUsersQuery
    {
        List<Users> Execute(bool show);
    }
}