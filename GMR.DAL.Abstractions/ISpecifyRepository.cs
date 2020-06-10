using System.Linq;

namespace GMR.DAL
{
    public interface ISpecifyRepository<T> : IRepository<T> where T : class
    {
        IQueryable<T> GetAllFor(long id);
    }
}
