using GMR.BLL.Abstractions.Models;
using GMR.BLL.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMR.BLL.Services
{
    public class PotentialContractorsService : IPotentialContractorsService, IDisposable
    {
        private  readonly IContractorService _contractorService;

        public PotentialContractorsService(IContractorService contractorService) => _contractorService = contractorService;

        public async Task<IEnumerable<PotentialContractorModel>> ValidateContractors(IEnumerable<ContractorModel> contractors, long personId)
        {
            var potentialContractors = new List<PotentialContractorModel>();

            if (contractors?.Any() == true)
            {
                foreach (var contractor in contractors)
                {
                    if (string.IsNullOrEmpty(contractor.Name) || contractor.Name.Length > 50)
                    {
                        potentialContractors.Add(new PotentialContractorModel { Error = "Имя контрагента не может быть пустым или его длина превышать 50 символов." });
                        continue;
                    }

                    var transaction = contractor.Transactions.FirstOrDefault();
                    if (transaction != null)
                    {
                        if (transaction.Value.HasValue && transaction.Value < 0)
                        {
                            potentialContractors.Add(new PotentialContractorModel { Error = "Значение транзакции не может быть отрицательным." });
                            continue;
                        }

                        if (transaction.Price.HasValue && transaction.Price < 0)
                        {
                            potentialContractors.Add(new PotentialContractorModel { Error = "Значение платежа не может быть отрицательным." });
                            continue;
                        }

                        if (transaction.Currency < 0)
                        {
                            potentialContractors.Add(new PotentialContractorModel { Error = "Курс не может быть отрицательным." });
                            continue;
                        }
                    }
                    
                    if (potentialContractors.Any(x => x.IsValid && x.ContractorID == contractor.ContractorID && x.Transactions.Contains(transaction)))
                        potentialContractors.Add(new PotentialContractorModel { Error = "Контрагент с такой транзакцией уже присутствует в файле импорта." });
                    else
                    {
                        var potentialContractorModel = Mapper.Map<ContractorModel, PotentialContractorModel>(contractor);
                        potentialContractorModel.PersonID = personId;
                        potentialContractors.Add(potentialContractorModel);
                    }
                }

                var validPotentialContractors = potentialContractors.Where(_ => _.IsValid);

                if (validPotentialContractors.Any())
                {
                    await CompareWithCurrentContractors(validPotentialContractors, personId);
                }
            }

            return potentialContractors;
        }

        public void Dispose() => (_contractorService as IDisposable).Dispose();

        private async Task CompareWithCurrentContractors(IEnumerable<PotentialContractorModel> validPotentialContractors, long personId)
        {
            var personContractors = (await _contractorService.GetContractorsAsync(personId, includes: new[] { nameof(ContractorModel.Transactions).ToLower() }))
                                    .ToDictionary(_ => new { _.ContractorID, _.Name });
        }
    }
}
