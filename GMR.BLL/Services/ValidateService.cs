using GMR.BLL.Abstractions.Models;
using GMR.BLL.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMR.BLL.Services
{
    public class ValidateService : IValidateService
    {
        public IEnumerable<ValidatedContractorModel> ValidateContractors(/*IEnumerable<ContractorModel> currentContractors, */IEnumerable<ContractorModel> importedContractors)
        {
            var validatedContractors = new List<ValidatedContractorModel>();

            if (importedContractors != null /*&& currentContractors != null*/)
            {
                foreach (var ic in importedContractors)
                {
                    if (string.IsNullOrEmpty(ic.Name) || ic.Name.Length > 50)
                    {
                        validatedContractors.Add(ValidatedContractorModel.CreateWithError("Имя контрагента не может быть пустым или его длина превышать 50 символов."));
                        continue;
                    }

                    var transaction = ic.Transactions.ToList()[0];
                    if (transaction.Value != null && transaction.Value < 0)
                    {
                        validatedContractors.Add(ValidatedContractorModel.CreateWithError("Значение транзакции не может быть отрицательным."));
                        continue;
                    }

                    if (transaction.Price != null && transaction.Value < 0)
                    {
                        validatedContractors.Add(ValidatedContractorModel.CreateWithError("Значение платежа не может быть отрицательным."));
                        continue;
                    }

                    if (transaction.Currency < 0)
                    {
                        validatedContractors.Add(ValidatedContractorModel.CreateWithError("Курс не может быть отрицательным."));
                        continue;
                    }

                    if (validatedContractors.Any(x => x.IsValid && x.ContractorID == ic.ContractorID && x.Transactions.Contains(transaction)))
                        validatedContractors.Add(new ValidatedContractorModel { Error = "Контрагент с такой транзакцией уже присутствует в файле импорта." });
                    else
                        validatedContractors.Add(new ValidatedContractorModel { ContractorID = ic.ContractorID, Name = ic.Name, Transactions = ic.Transactions });
                }
            }

            return validatedContractors;
        }
    }
}
