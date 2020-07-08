using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.BLL
{
    public interface IExcelManager
    {
        Task<IEnumerable<ContractorModel>> ImportContractors(string fileName);

        Task ExportContractors(IEnumerable<ContractorModel> contractors, string fileName);
    }
}
