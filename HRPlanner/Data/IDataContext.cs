using HRPlanner.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRPlanner.Data
{
    public interface IDataContext
    {
        DbSet<Users> Users { get; set; }
    }

}