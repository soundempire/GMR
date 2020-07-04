using GMR.DAL.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GMR.DAL.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly GMRContext _context;

        public PersonRepository(GMRContext context) => _context = context;

        public async Task<IEnumerable<Person>> GetAll(long? parentIdFilter = default, params string[] includes)
        {
            var query = _context.Persons.AsQueryable();
            if (includes.Contains(nameof(Person.Password).ToLower()))
                query = query.Include(_ => _.Password);

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<Person> GetAsync(long id, params string[] includes)
        {
            var query = _context.Persons.AsQueryable();
            if (includes.Contains(nameof(Person.Password).ToLower()))
                query = query.Include(_ => _.Password);

            return await query.Where(_ => _.ID == id).AsNoTracking().FirstOrDefaultAsync();
        }

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
