using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.BLL
{
    public interface ITransferContractorsService
    {
        Task<IEnumerable<ContractorModel>> ImportContractors(string fileName);

        Task ExportContractors(IEnumerable<ContractorModel> contractors, string fileName);
    }
}
