using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.BLL
{
    public interface IPersonService
    {
        Task<PersonModel> GetPersonAsync(long id);

        Task<IEnumerable<PersonModel>> GetPersonsAsync(bool includePasswords);

        Task<PersonModel> UpdatePersonAsync(PersonModel person);

        Task<PersonModel> AddPersonAsync(PersonModel person);

        Task RemovePersonAsync(long id);
    }
}
