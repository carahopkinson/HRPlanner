namespace HRPlanner.Data
{
    public interface IDataContextFactory
    {
        IDataContext CreateContext();
    }
}