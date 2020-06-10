using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.BLL
{
    public interface IImportService
    {
        Task<IEnumerable<ContractorModel>> ImportContractors(string fileName);
    }
}
