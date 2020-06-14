using System.Threading.Tasks;

namespace GMR.BLL
{
    public interface IPotentialLoginService
    {
        Task<bool> IsLoginExists(string potentialLogin);
    }
}
