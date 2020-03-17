using GMR.DAL.Abstractions;
using System;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections.Generic;
using GMR.BLL.Abstractions.Services;
using GMR.BLL.Abstractions.Models;
using GMR.DAL.Abstractions.Entities;
using System.Linq;

namespace GMR.BLL.Services
{
    public class PersonService : IPersonService, IDisposable
    {
        private readonly IRepository<Person> _personRepository;

        public PersonService(IRepository<Person> personRepository) => _personRepository = personRepository;

        public async Task<PersonModel> GetPersonAsync(long id)
        {
            var dataModel = await _personRepository.GetAsync(id);
            return Mapper.Map<Person, PersonModel>(dataModel);
        }

        public async Task<IEnumerable<PersonModel>> GetPersonsAsync(bool includePasswords)
        {
            var query = _personRepository.GetAll();
            if (includePasswords)
            {
                query = query.Include(p => p.Password);
            }
            var dataModel = await query.ToListAsync();

            return Mapper.Map<IEnumerable<Person>, IEnumerable<PersonModel>>(dataModel);
        }

        public async Task<PersonModel> UpdatePersonAsync(PersonModel person)
        {
            var pers = Mapper.Map<PersonModel, Person>(person);

            await _personRepository.UpdateAsync(pers);

            return Mapper.Map<Person, PersonModel>(pers);
        }

        public async Task<IEnumerable<PersonModel>> GetPersonByFullName(string fullName)
        {
            var dataModels = _personRepository.GetAll();
            var query = await dataModels.Where(p => $"{p.LastName} {p.FirstName}" == fullName).ToListAsync();

            return Mapper.Map<IEnumerable<Person>, IEnumerable<PersonModel>>(query);
        }

        public void Dispose() => _personRepository?.Dispose();
    }
}
