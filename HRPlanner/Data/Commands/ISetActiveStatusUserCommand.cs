using HRPlanner.Data.Entities;

namespace HRPlanner.Data.Commands
{
    public interface ISetActiveStatusUserCommand
    {
        bool Execute(int userId, bool active);
    }
}