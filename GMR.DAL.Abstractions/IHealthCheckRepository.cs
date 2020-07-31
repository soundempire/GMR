using System.Threading.Tasks;

namespace GMR.DAL
{
    public interface IHealthCheckRepository
    {
        Task<bool> IsDatabaseAvailable();
    }
}
