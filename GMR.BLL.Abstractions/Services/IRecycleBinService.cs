using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.BLL
{
    public interface IRecycleBinService
    {
        Task<IEnumerable<ContractorModel>> GetContractorsAsync(long personId, params string[] includes);

        Task<IEnumerable<ContractorModel>> PutContractorsAsync(IEnumerable<ContractorModel> contractors);

        Task RemoveContractorsAsync(long[] ids);

        Task<IEnumerable<ContractorModel>> RetrieveContractorsAsync(IEnumerable<ContractorModel> contractors);
    }
}
