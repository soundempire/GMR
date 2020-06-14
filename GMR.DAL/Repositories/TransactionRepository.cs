using GMR.DAL.Context;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace GMR.DAL.Repositories
{
    public class TransactionRepository : IRepository<Transaction>
    {
        private readonly GMRContext _context;

        public TransactionRepository(GMRContext context) => _context = context;

        public IQueryable<Transaction> GetAll(long? parentIdFilter = null)
            => _context.Transactions.AsNoTracking();

        public async Task<Transaction> GetAsync(long id)
            => await _context.Transactions.FindAsync(id);

        public async Task<Transaction> CreateAsync(Transaction transaction)
        {
            Transaction entity = _context.Transactions.Add(transaction);
            await SaveAsync();

            return entity;
        }

        public async Task<Transaction> UpdateAsync(Transaction transaction)
        {
            _context.Set<Transaction>().AddOrUpdate(transaction);
            await SaveAsync();

            return transaction;
        }

        public async Task DeleteAsync(long id)
        {
            Transaction transaction = await _context.Transactions.FindAsync(id);

            if (transaction != null)
                _context.Transactions.Remove(transaction);

            await SaveAsync();
        }

        public async Task SaveAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}
