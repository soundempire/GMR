using GMR.BLL.Abstractions.Models;
using System.Threading.Tasks;

namespace GMR.BLL.Abstractions.Services
{
    public interface IAuthorizationService
    {
        Task<PersonModel> AuthorizeAsync(string login, string password);
    }
}
