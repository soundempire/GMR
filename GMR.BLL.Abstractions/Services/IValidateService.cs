using GMR.BLL.Abstractions.Models;
using System.Collections.Generic;

namespace GMR.BLL.Abstractions.Services
{
    public interface IValidateService
    {
        IEnumerable<ValidatedContractorModel> ValidateContractors(/*IEnumerable<ContractorModel> currentContractors, */IEnumerable<ContractorModel> importedContractors);
    }
}
