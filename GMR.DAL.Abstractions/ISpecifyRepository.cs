using System.Linq;

namespace GMR.DAL.Abstractions
{
    public interface ISpecifyRepository<T> : IRepository<T> where T : class
    {
        IQueryable<T> GetAllFor(long id);
    }
}
