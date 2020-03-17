using GMR.BLL.Abstractions.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.BLL.Abstractions.Services
{
    public interface IPersonService
    {
        Task<PersonModel> GetPersonAsync(long id);

        Task<IEnumerable<PersonModel>> GetPersonsAsync(bool includePasswords);

        Task<PersonModel> UpdatePersonAsync(PersonModel person);

        Task<IEnumerable<PersonModel>> GetPersonByFullName(string fullName);
    }
}
