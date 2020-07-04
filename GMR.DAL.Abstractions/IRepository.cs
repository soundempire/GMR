using System;
using System.Threading.Tasks;

namespace GMR.DAL
{
    public interface IRepository<T> : IDisposable where T : class
    {
        Task<T> GetAsync(long id, params string[] includes);

        Task<T> CreateAsync(T item);

        Task<T> UpdateAsync(T item);

        Task DeleteAsync(long id);

        Task SaveAsync();
    }
}
