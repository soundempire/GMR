using GMR.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace GMR.DAL.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly GMRContext _context;

        public TransactionRepository(GMRContext context) => _context = context;

        public async Task<IEnumerable<Transaction>> GetAll(long? parentIdFilter = default, DateTime? startDate = default, DateTime? endDate = default, params string[] includes)
        {
            var query = _context.Transactions.AsQueryable();
            if (includes.Contains(nameof(Transaction.Contractor).ToLower()))
                query = query.Include(_ => _.Contractor);

            if (parentIdFilter.HasValue)
                query = query.Where(_ => _.ContractorID == parentIdFilter.Value);

            if (startDate.HasValue && endDate.HasValue)
                query = query.Where(_ => DbFunctions.TruncateTime(_.Date) >= DbFunctions.TruncateTime(startDate.Value) && 
                                         DbFunctions.TruncateTime(_.Date) <= DbFunctions.TruncateTime(endDate.Value));

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<Transaction> GetAsync(long id, params string[] includes)
        {
            var query = _context.Transactions.AsQueryable();
            if (includes.Contains(nameof(Transaction.Contractor).ToLower()))
                query = query.Include(_ => _.Contractor);

            return await query.Where(_ => _.ID == id).AsNoTracking().FirstOrDefaultAsync();
        }

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
