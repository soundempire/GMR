using System.Threading.Tasks;

namespace GMR.BLL
{
    public interface IAuthorizationService
    {
        Task<PersonModel> AuthorizeAsync(string login, string password);
    }
}
