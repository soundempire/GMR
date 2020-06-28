using GMR.BLL;
using System.Collections.Generic;

namespace GMR
{
    internal class ImportResult
    {
        //TODO: IEnumerable?
        public IEnumerable<ContractorModel> SuccessContractors { get; set; }//TODO: should be view model

        public bool OverwriteExistingNames { get; set; }
    }
}
