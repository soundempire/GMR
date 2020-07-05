using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.DAL
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
        Task<IEnumerable<Transaction>> GetAll(long? parentIdFilter = default, DateTime? startDate = default, DateTime? endDate = default, params string[] includes);
    }
}
