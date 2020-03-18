using GMR.BLL.Abstractions.Models;
using GMR.BLL.Abstractions.Services;
using GMR.DAL.Abstractions;
using GMR.DAL.Abstractions.Entities;
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
        private readonly ISpecifyRepository<Contractor> _contractorRepository;

        public ContractorService(ISpecifyRepository<Contractor> contractorRepository)
            => _contractorRepository = contractorRepository;

        public async Task<ContractorModel> GetContractorAsync(long id)
        {
            var dataModel = await _contractorRepository.GetAsync(id);
            return Mapper.Map<Contractor, ContractorModel>(dataModel);
        }

        public async Task<IEnumerable<ContractorModel>> GetContractorsAsync(long personId, string filter = null)
        {
            var query = _contractorRepository.GetAllFor(personId);
            if (!string.IsNullOrWhiteSpace(filter))
            {
                query = query.Where(c => c.Name.ToLower().Contains(filter.ToLower()));
            }
            var dataModel = await query.ToListAsync();

            return Mapper.Map<IEnumerable<Contractor>, IEnumerable<ContractorModel>>(dataModel);
        }

        public async Task<ContractorModel> UpdateContractorAsync(ContractorModel contractor)
        {
            var ctr = Mapper.Map<ContractorModel, Contractor>(contractor);

            await _contractorRepository.UpdateAsync(ctr);

            return Mapper.Map<Contractor, ContractorModel>(ctr);
        }

        public void Dispose() => _contractorRepository.Dispose();
    }
}
