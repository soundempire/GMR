using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.BLL
{
    public interface IPersonService
    {
        Task<PersonModel> GetPersonAsync(long id);

        Task<IEnumerable<PersonModel>> GetPersonsAsync(params string[] includes);

        Task<PersonModel> UpdatePersonAsync(PersonModel person);

        Task<PersonModel> AddPersonAsync(PersonModel person);

        Task RemovePersonAsync(long id);
    }
}
