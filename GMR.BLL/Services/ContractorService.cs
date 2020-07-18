using GMR.DAL;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.BLL.Services
{
    public class ContractorService : IContractorService, IDisposable
    {
        private readonly IContractorRepository _contractorRepository;

        public ContractorService(IContractorRepository contractorRepository)
            => _contractorRepository = contractorRepository;

        public async Task<ContractorModel> GetContractorAsync(long id, params string[] includes)
        {
            var contractor = await _contractorRepository.GetAsync(id, includes);
            return Mapper.Map<Contractor, ContractorModel>(contractor);
        }

        public async Task<IEnumerable<ContractorModel>> GetContractorsAsync(long personId, string filter = null, params string[] includes)
        {
            var contractors = await _contractorRepository.GetAll(personId, false, filter, includes);
            return Mapper.Map<IEnumerable<Contractor>, IEnumerable<ContractorModel>>(contractors);
        }

        public async Task<ContractorModel> AddContractorAsync(ContractorModel contractor)
        {
            var newContractor = Mapper.Map<ContractorModel, Contractor>(contractor);

            var contractorEntity = await _contractorRepository.CreateAsync(newContractor);

            return Mapper.Map<Contractor, ContractorModel>(contractorEntity);
        }

        public async Task<ContractorModel> UpdateContractorAsync(ContractorModel contractor)
        {
            var ctr = Mapper.Map<ContractorModel, Contractor>(contractor);

            await _contractorRepository.UpdateAsync(ctr);

            return Mapper.Map<Contractor, ContractorModel>(ctr);
        }

        public async Task RemoveContractorAsync(long id)
           => await _contractorRepository.DeleteAsync(id);

        public void Dispose() => _contractorRepository?.Dispose(); 
    }
}
