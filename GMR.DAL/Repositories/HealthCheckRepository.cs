using GMR.DAL.Context;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace GMR.DAL.Repositories
{
    public class HealthCheckRepository : IHealthCheckRepository, IDisposable
    {
        private readonly GMRContext _context;

        public HealthCheckRepository(GMRContext context) => _context = context;

        public async Task<bool> IsDatabaseAvailable()
        {
            await _context.Contractors.CountAsync();

            return true;
        }

        public void Dispose() => _context.Dispose();
    }
}
