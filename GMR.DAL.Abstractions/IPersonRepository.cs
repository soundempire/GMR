using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.DAL
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<IEnumerable<Person>> GetAll(long? parentIdFilter = default, params string[] includes);
    }
}
