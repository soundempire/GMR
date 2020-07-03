using GMR.DAL;
using System;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using GMR.Infrastructure;

namespace GMR.BLL.Services
{
    public class PersonService : IPersonService, IDisposable
    {
        private readonly ILanguagesService _languagesService;

        private readonly IRepository<Person> _personRepository;

        private readonly IСryptographer _сryptographer;

        public PersonService(ILanguagesService languagesService, IRepository<Person> personRepository, IСryptographer сryptographer) 
            => (_languagesService, _personRepository, _сryptographer) = (languagesService, personRepository, сryptographer);

        public async Task<PersonModel> GetPersonAsync(long id)
        {
            var person = await _personRepository.GetAsync(id);
            var personModel = Mapper.Map<Person, PersonModel>(person);
            personModel.Language = (await _languagesService.GetLanguages(personModel.Language.Id)).FirstOrDefault();
            return personModel;
        }

        public async Task<IEnumerable<PersonModel>> GetPersonsAsync(bool includePasswords)
        {
            var query = _personRepository.GetAll();
            if (includePasswords)
                query = query.Include(p => p.Password);

            var persons = await query.ToListAsync();
            var personModels = Mapper.Map<IEnumerable<Person>, IEnumerable<PersonModel>>(persons)
                                    .GroupBy(_ => _.Language.Id)
                                    .ToDictionary(group => group.Key, group => group.ToList());

            var languages = await _languagesService.GetLanguages(personModels.Keys.ToArray());

            foreach (var language in languages)
            {
                if (personModels.TryGetValue(language.Id, out var models))
                    models.ToList().ForEach(_ => _.Language = language);
            }

            return personModels.SelectMany(_ => _.Value);
        }

        public async Task<PersonModel> UpdatePersonAsync(PersonModel person)
        {
            if (person.Password != null)
                person.Password.Value = _сryptographer.Encrypt(person.Password.Value);

            var personEntity = Mapper.Map<PersonModel, Person>(person);

            await _personRepository.UpdateAsync(personEntity);

            return Mapper.Map<Person, PersonModel>(personEntity);
        }

        public async Task<PersonModel> AddPersonAsync(PersonModel person)
        {
            person.Password.Value = _сryptographer.Encrypt(person.Password.Value);

            var newPerson = Mapper.Map<PersonModel, Person>(person);

            var personEntity = await _personRepository.CreateAsync(newPerson);

            return Mapper.Map<Person, PersonModel>(personEntity);
        }

        public async Task RemovePersonAsync(long id)
           => await _personRepository.DeleteAsync(id);

        public void Dispose() => _personRepository?.Dispose();
    }
}
