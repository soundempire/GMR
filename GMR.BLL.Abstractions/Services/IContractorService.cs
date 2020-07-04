using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.BLL
{
    public interface IContractorService
    {
        Task<ContractorModel> GetContractorAsync(long id, params string[] includes);

        Task<IEnumerable<ContractorModel>> GetContractorsAsync(long personId, string filter = null, params string[] includes);

        Task<ContractorModel> AddContractorAsync(ContractorModel contractor);

        Task<ContractorModel> UpdateContractorAsync(ContractorModel contractor);

        Task RemoveContractorAsync(long id);
    }
}
