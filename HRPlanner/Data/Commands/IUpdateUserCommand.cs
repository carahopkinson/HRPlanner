using HRPlanner.Data.Entities;

namespace HRPlanner.Data.Commands
{
    public interface IUpdateUserCommand
    {
        bool Execute(Users user);
    }
}