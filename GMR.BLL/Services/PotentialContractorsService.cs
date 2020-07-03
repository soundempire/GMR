using System;
using System.Collections.Generic;
using System.Linq;
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
                        AddInvalidPotentialContractor(contractor, "Имя контрагента не может быть пустым или его длина превышать 50 символов.");
                        continue;
                    }

                    var transaction = contractor.Transactions.FirstOrDefault();
                    if (transaction != null)
                    {
                        if (transaction.Value.HasValue && transaction.Value < 0)
                        {
                            AddInvalidPotentialContractor(contractor, "Значение транзакции не может быть отрицательным.");
                            continue;
                        }

                        if (transaction.Price.HasValue && transaction.Price < 0)
                        {
                            AddInvalidPotentialContractor(contractor, "Значение платежа не может быть отрицательным.");
                            continue;
                        }

                        if (transaction.Currency < 0)
                        {
                            AddInvalidPotentialContractor(contractor, "Курс не может быть отрицательным.");
                            continue;
                        }
                    }

                    var potentialContractorModel = Mapper.Map<ContractorModel, PotentialContractorModel>(contractor);
                    potentialContractorModel.PersonID = personId;
                    potentialContractors.Add(potentialContractorModel);
                }

                var validPotentialContractors = potentialContractors.Where(_ => _.IsValid);

                if (validPotentialContractors.Any())
                {
                    potentialContractors = potentialContractors.Where(_ => !_.IsValid)
                                           .Union(await CompareWithCurrentContractors(validPotentialContractors, personId))
                                           .ToList();
                }
            }

            return potentialContractors;

            void AddInvalidPotentialContractor(ContractorModel contractor, string error)
            {
                var potentialContractor = Mapper.Map<ContractorModel, PotentialContractorModel>(contractor);
                potentialContractor.Error = error;
                potentialContractors.Add(potentialContractor);
            }
        }

        public void Dispose() => (_contractorService as IDisposable).Dispose();

        private async Task<IEnumerable<PotentialContractorModel>> CompareWithCurrentContractors(IEnumerable<PotentialContractorModel> validPotentialContractors, long personId)
        {
            var personContractors = (await _contractorService.GetContractorsAsync(personId, includes: new[] { nameof(ContractorModel.Transactions).ToLower() }))
                                    .ToDictionary(_ => ( _.ContractorID, _.Name ));
            
            HashSet<PotentialContractorModel> contractors = new HashSet<PotentialContractorModel>();

            foreach (var potentialContractor in validPotentialContractors)
            {
                var potentialTransaction = potentialContractor.Transactions?.FirstOrDefault();

                if (personContractors.TryGetValue((potentialContractor.ContractorID, potentialContractor.Name), out var personContractor))
                {
                    if (potentialTransaction != null)
                    {
                        potentialContractor.ID = personContractor.ID;
                    }
                    else
                    {
                        potentialContractor.Error = "Попытка загрузить существующего контрагента без выбранных транзакций";
                        continue;
                    }
                }

                if (contractors.TryGetValue(potentialContractor, out var contractor))
                {
                    if (contractor.Transactions != null && potentialTransaction != null)
                    {
                        contractor.Transactions.Add(potentialTransaction);
                    }
                    else if (potentialTransaction != null)
                    {
                        contractor.Transactions = new List<TransactionModel>() { potentialTransaction };
                    }
                }
                else
                {
                    contractors.Add(potentialContractor);
                }
            }

            return contractors.ToList();
        }
    }
}
