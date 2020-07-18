using GMR.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMR.BLL.Services
{
    public class RecycleBinService : IRecycleBinService, IDisposable
    {
        private readonly IContractorRepository _contractorRepository;

        public RecycleBinService(IContractorRepository contractorRepository)
            => _contractorRepository = contractorRepository;

        public async Task<IEnumerable<ContractorModel>> GetContractorsAsync(long personId, params string[] includes)
        {
            var contractors = await _contractorRepository.GetAll(personId, true, includes: includes);
            return Mapper.Map<IEnumerable<Contractor>, IEnumerable<ContractorModel>>(contractors);
        }

        public async Task<IEnumerable<ContractorModel>> PutContractorsAsync(IEnumerable<ContractorModel> contractors)
        {
            foreach (var contractor in contractors)
            {
                contractor.Deleted = true;
                var contractorEntry = Mapper.Map<ContractorModel, Contractor>(contractor);
                await _contractorRepository.UpdateAsync(contractorEntry);
            }

            return contractors.ToList();
        }

        public async Task RemoveContractorsAsync(long[] ids)
        {
            foreach (var id in ids)
                await _contractorRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ContractorModel>> RetrieveContractorsAsync(IEnumerable<ContractorModel> contractors)
        {
            foreach (var contractor in contractors)
            {
                contractor.Deleted = false;
                var contractorEntry = Mapper.Map<ContractorModel, Contractor>(contractor);
                await _contractorRepository.UpdateAsync(contractorEntry);
            }

            return contractors.ToList();
        }

        public void Dispose() => _contractorRepository?.Dispose();
    }
}
