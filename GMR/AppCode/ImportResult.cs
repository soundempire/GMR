using GMR.Models;
using System.Collections.Generic;

namespace GMR
{
    internal class ImportResult
    {
        public ContractorViewModel[] SuccessContractors { get; set; }

        public bool OverwriteExistingNames { get; set; }
    }
}
