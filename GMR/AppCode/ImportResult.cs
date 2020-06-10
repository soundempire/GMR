using GMR.BLL;
using System.Collections.Generic;

namespace GMR
{
    internal class ImportResult
    {
        public IEnumerable<ContractorModel> SuccessContractors { get; set; }

        public bool OverwriteExistingNames { get; set; }
    }
}
