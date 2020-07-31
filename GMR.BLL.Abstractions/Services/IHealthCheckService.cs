using System.Threading.Tasks;

namespace GMR.BLL
{
    public interface IHealthCheckService
    {
        Task<bool> IsApplicationAvailable();
    }
}
