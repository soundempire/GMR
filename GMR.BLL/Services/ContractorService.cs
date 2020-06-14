using GMR.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GMR.BLL.Services
{
    public class ContractorService : IContractorService, IDisposable
    {
        private readonly IRepository<Contractor> _contractorRepository;

        public ContractorService(IRepository<Contractor> contractorRepository)
            => _contractorRepository = contractorRepository;

        public async Task<ContractorModel> GetContractorAsync(long id)
        {
            var dataModel = await _contractorRepository.GetAsync(id);
            return Mapper.Map<Contractor, ContractorModel>(dataModel);
        }

        public async Task<IEnumerable<ContractorModel>> GetContractorsAsync(long personId, string filter = null, params string[] includes)
        {
            var query = _contractorRepository.GetAll(personId);

            if (includes.Contains(nameof(ContractorModel.Transactions).ToLower()))
            {
                query = query.Include(c=>c.Transactions);
            }

            if (!string.IsNullOrWhiteSpace(filter))
            {
                query = query.Where(c => c.Name.ToLower().Contains(filter.ToLower()));
            }

            var dataModel = await query.ToListAsync();

            return Mapper.Map<IEnumerable<Contractor>, IEnumerable<ContractorModel>>(dataModel);
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

        public void Dispose() => _contractorRepository.Dispose(); 
    }
}
