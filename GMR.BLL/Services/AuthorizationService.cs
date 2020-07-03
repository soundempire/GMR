using GMR.Infrastructure;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GMR.BLL.Services
{
    public class AuthorizationService : IAuthorizationService, IDisposable
    {
        private readonly IPersonService _personService;

        private readonly IСryptographer _сryptographer;

        public AuthorizationService(IPersonService personService, IСryptographer сryptographer) 
            => (_personService, _сryptographer) = (personService, сryptographer);

        public async Task<PersonModel> AuthorizeAsync(string login, string password)
        {
            var persons = await _personService.GetPersonsAsync(true);

            var person = persons.FirstOrDefault(_ => _.Password.Login == login && _сryptographer.Decrypt(_.Password.Value) == password);

            if (person != null)
                person.Password.Value = _сryptographer.Decrypt(person.Password.Value);

            return person;
        }

        public void Dispose() => (_personService as IDisposable).Dispose();
    }
}
