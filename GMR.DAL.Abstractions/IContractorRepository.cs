using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.DAL
{
    public interface IContractorRepository : IRepository<Contractor>
    {
        Task<IEnumerable<Contractor>> GetAll(long? parentIdFilter = default, string nameFilter = default, params string[] includes);
    }
}
