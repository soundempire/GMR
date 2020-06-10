using System;
using System.Linq;
using System.Threading.Tasks;

namespace GMR.BLL.Services
{
    public class AuthorizationService : IAuthorizationService, IDisposable
    {
        private readonly IPersonService _personService;

        public AuthorizationService(IPersonService personService) => _personService = personService;

        public async Task<PersonModel> AuthorizeAsync(string login, string password)
        {
            var persons = await _personService.GetPersonsAsync(true);

            return persons.FirstOrDefault(person => person.Password.Login == login && person.Password.Value == password);
        }

        public void Dispose() => (_personService as IDisposable).Dispose();
    }
}
