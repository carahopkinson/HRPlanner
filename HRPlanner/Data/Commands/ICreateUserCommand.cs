using HRPlanner.Data.Entities;

namespace HRPlanner.Data.Commands
{
    public interface ICreateUserCommand
    {
        bool Execute(Users user);
    }
}