using HRPlanner.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.Data.Queries
{
    public interface IGetUserByIdQuery
    {
        Users Execute(int userId);
    }
}
