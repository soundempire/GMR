using GMR.BLL.Abstractions.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.BLL.Abstractions.Services
{
    public interface IImportService
    {
        Task<IEnumerable<ImportResultRow<ContractorModel>>> ImportContractors(string fileName, long personId);
    }
}
