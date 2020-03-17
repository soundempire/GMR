using GMR.DAL.Abstractions;
using GMR.DAL.Abstractions.Entities;
using GMR.DAL.Context;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;


namespace GMR.DAL.Repositories
{
    public class ContractorRepository : ISpecifyRepository<Contractor>
    {
        private readonly GMRContext _context;

        public ContractorRepository(GMRContext context) => _context = context;

        public IQueryable<Contractor> GetAllFor(long id)
            => _context.Contractors.Where(c => c.PersonID == id).AsNoTracking();

        public IQueryable<Contractor> GetAll()
            => _context.Contractors.AsNoTracking();

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
