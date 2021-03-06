﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.BLL
{
    public interface IPotentialContractorsService
    {
        Task<IEnumerable<PotentialContractorModel>> ValidateContractors(IEnumerable<ContractorModel> contractors, long personId);
    }
}
