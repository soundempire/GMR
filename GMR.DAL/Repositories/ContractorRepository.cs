using GMR.DAL.Context;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;


namespace GMR.DAL.Repositories
{
    public class ContractorRepository : IRepository<Contractor>
    {
        private readonly GMRContext _context;

        public ContractorRepository(GMRContext context) => _context = context;

        public IQueryable<Contractor> GetAll(long? parentIdFilter = null)
        {
            var query = _context.Contractors.AsQueryable();
            if (parentIdFilter.HasValue)
                query = query.Where(c => c.PersonID == parentIdFilter.Value);

            return query.AsNoTracking();
        }

        public async Task<Contractor> GetAsync(long id)
            => await _context.Contractors
                             .Include(c => c.Transactions)
                             .Where(c => c.ID == id)
                             .AsNoTracking()
                             .FirstOrDefaultAsync();

        public async Task<Contractor> CreateAsync(Contractor contractor)
        {
            Contractor entity = _context.Contractors.Add(contractor);
            await SaveAsync();

            return entity;
        }

        public async Task<Contractor> UpdateAsync(Contractor contractor)
        {
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
