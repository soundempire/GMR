using GMR.BLL.Abstractions.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.BLL.Abstractions.Services
{
    public interface IPotentialContractorsService
    {
        Task<IEnumerable<PotentialContractorModel>> ValidateContractors(IEnumerable<ContractorModel> contractors, long personId);
    }
}
