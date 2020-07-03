using GMR.DAL.Context;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace GMR.DAL.Repositories
{
    public class PersonRepository : IRepository<Person>
    {
        private readonly GMRContext _context;

        public PersonRepository(GMRContext context) => _context = context;

        public IQueryable<Person> GetAll(long? parentIdFilter = null)
            => _context.Persons.AsNoTracking();

        public async Task<Person> GetAsync(long id)
            => await _context.Persons
                             .Include(p => p.Password)
                             .Where(p => p.ID == id)
                             .AsNoTracking()
                             .FirstOrDefaultAsync();

        public async Task<Person> CreateAsync(Person person)
        {
            Person entity = _context.Persons.Add(person);
            await SaveAsync();

            return entity;
        }

        public async Task<Person> UpdateAsync(Person person)
        {
            _context.Entry(person).State = EntityState.Modified;
            if (person.Password != null)
                _context.Entry(person.Password).State = EntityState.Modified;

            await SaveAsync();

            return person;
        }

        public async Task DeleteAsync(long id)
        {
            Person person = await _context.Persons.FindAsync(id);

            if (person != null)
                _context.Persons.Remove(person);

            await SaveAsync();
        }

        public async Task SaveAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}
