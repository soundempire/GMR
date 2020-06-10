using GMR.DAL.Context;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace GMR.DAL.Repositories
{
    public class PasswordRepository : IRepository<Password>
    {
        private readonly GMRContext _context;

        public PasswordRepository(GMRContext context) => _context = context;

        public IQueryable<Password> GetAll()
            => _context.Passwords.AsNoTracking();

        public async Task<Password> GetAsync(long id)
            => await _context.Passwords.FindAsync(id);

        public async Task<Password> CreateAsync(Password pwd)
        {
            Password entity = _context.Passwords.Add(pwd);
            await SaveAsync();

            return entity;
        }

        public async Task<Password> UpdateAsync(Password pwd)
        {
            _context.Set<Password>().AddOrUpdate(pwd);
            await SaveAsync();

            return pwd;
        }

        public async Task DeleteAsync(long id)
        {
            Password pwd = _context.Passwords.Find(id);

            if (pwd != null)
                _context.Passwords.Remove(pwd);

            await SaveAsync();
        }

        public async Task SaveAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}
