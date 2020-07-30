using GMR.DAL.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace GMR.DAL.Repositories
{
    public class ContractorRepository : IContractorRepository
    {
        private readonly GMRContext _context;

        public ContractorRepository(GMRContext context) => _context = context;

        public async Task<IEnumerable<Contractor>> GetAll(long? parentIdFilter = default, bool deleted = default, string nameFilter = default, params string[] includes)
        {
            var query = _context.Contractors.AsQueryable();
            if (includes.Contains(nameof(Contractor.Transactions).ToLower()))
                query = query.Include(_ => _.Transactions);

            if (parentIdFilter.HasValue)
                query = query.Where(_ => _.PersonID == parentIdFilter.Value);

            if (!string.IsNullOrWhiteSpace(nameFilter))
                query = query.Where(_ => _.Name.ToLower().Contains(nameFilter.ToLower()));

            return await query.Where(_ => _.Deleted == deleted).AsNoTracking().ToListAsync();
        }

        public async Task<Contractor> GetAsync(long id, params string[] includes)
        {
            var query = _context.Contractors.AsQueryable();
            if (includes.Contains(nameof(Contractor.Transactions).ToLower()))
                query = query.Include(_ => _.Transactions);

            return await query.Where(_ => _.ID == id).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<Contractor> CreateAsync(Contractor contractor)
        {
            Contractor entity = _context.Contractors.Add(contractor);
            await SaveAsync();

            return entity;
        }

        public async Task<Contractor> UpdateAsync(Contractor contractor)
        {
            var localEntity = await _context.Contractors.Where(_ => _.ID == contractor.ID).FirstOrDefaultAsync();
            if (localEntity != null)
                _context.Entry(localEntity).State = EntityState.Detached;

            _context.Set<Contractor>().AddOrUpdate(contractor);
            await SaveAsync();

            return contractor;
        }

        public async Task DeleteAsync(long id)
        {
            Contractor contractor = await _context.Contractors.FindAsync(id);

            if (contractor != null)
                _context.Contractors.Remove(contractor);

            await SaveAsync();
        }

        public void Dispose() => _context.Dispose();

        public async Task SaveAsync() => await _context.SaveChangesAsync();
    }
}
