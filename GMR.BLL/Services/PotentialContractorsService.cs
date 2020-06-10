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

                    var potentialContractorModel = Mapper.Map<ContractorModel, PotentialContractorModel>(contractor);
                    potentialContractorModel.PersonID = personId;
                    potentialContractors.Add(potentialContractorModel);
                }

                var validPotentialContractors = potentialContractors.Where(_ => _.IsValid);

                if (validPotentialContractors.Any())
                {
                    var validContractors = await CompareWithCurrentContractors(validPotentialContractors, personId);
                    potentialContractors = potentialContractors.Where(_ => !_.IsValid).Union(validContractors).ToList();
                }
            }

            return potentialContractors;
        }

        public void Dispose() => (_contractorService as IDisposable).Dispose();

        private async Task<IEnumerable<PotentialContractorModel>> CompareWithCurrentContractors(IEnumerable<PotentialContractorModel> validPotentialContractors, long personId)
        {
            var personContractors = (await _contractorService.GetContractorsAsync(personId, includes: new[] { nameof(ContractorModel.Transactions).ToLower() }))
                                    .ToDictionary(_ => ( _.ContractorID, _.Name ));

            var contractors = new Dictionary<(string ContractorID, string Name), PotentialContractorModel>();

            foreach (var potentialContractor in validPotentialContractors)
            {
                var potentialTransaction = potentialContractor.Transactions?.FirstOrDefault();

                if (personContractors.TryGetValue((potentialContractor.ContractorID, potentialContractor.Name), out var personContractor))
                {
                    if (potentialTransaction != null)
                    {
                        if (personContractor.Transactions.Contains(potentialTransaction))
                        {
                            continue; //TODO: think about error message and valid state
                        }
                        else
                        {
                            potentialContractor.ID = personContractor.ID;
                        }
                    }
                    else
                    {
                        continue; //TODO: think about error message and valid state
                    }
                }

                if (contractors.TryGetValue((potentialContractor.ContractorID, potentialContractor.Name), out var contractor))
                {
                    if (contractor.Transactions != null && potentialTransaction != null)
                    {
                        contractor.Transactions.Add(potentialTransaction);
                    }
                    else if(potentialTransaction != null)
                    {
                        contractor.Transactions = new HashSet<TransactionModel>() { potentialTransaction };
                    }
                }
                else
                {
                    contractors[(potentialContractor.ContractorID, potentialContractor.Name)] = potentialContractor;
                }
            }

            return contractors.Values.ToList();
        }
    }
}
