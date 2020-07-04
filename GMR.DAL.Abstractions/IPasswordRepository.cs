using System.Threading.Tasks;

namespace GMR.DAL
{
    public interface IPasswordRepository : IRepository<Password>
    {
        Task<bool> IsLoginExists(string potentialLogin);
    }
}
