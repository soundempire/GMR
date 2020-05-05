using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMR.BLL.Abstractions.Models
{
    public class PotentialContractorModel : ContractorModel
    {
        public string Error { set; get; }

        public bool IsValid => string.IsNullOrEmpty(Error);
    }
}
