using GMR.BLL.Abstractions.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.BLL.Abstractions.Services
{
    public interface IContractorService
    {
        Task<ContractorModel> GetContractorAsync(long id);

        Task<IEnumerable<ContractorModel>> GetContractorsAsync(long personId, string filter = null);

        Task<ContractorModel> UpdateContractorAsync(ContractorModel contractor);
    }
}
