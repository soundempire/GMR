using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMR.BLL.Abstractions.Models
{
    public class ValidatedContractorModel : ContractorModel
    {
        public string Error { set; get; }

        public bool IsValid => string.IsNullOrEmpty(Error);

        public static ValidatedContractorModel CreateWithError(string errorMessage) => new ValidatedContractorModel() { Error = errorMessage };
    }
}
