using GMR.DAL;
using System;
using System.Threading.Tasks;

namespace GMR.BLL.Services
{
    public class HealthCheckService : IHealthCheckService, IDisposable
    {
        private readonly IHealthCheckRepository _healthCheckRepository;

        public HealthCheckService(IHealthCheckRepository healthCheckRepository) => _healthCheckRepository = healthCheckRepository;

        public async Task<bool> IsApplicationAvailable() => await _healthCheckRepository.IsDatabaseAvailable();

        public void Dispose() => (_healthCheckRepository as IDisposable)?.Dispose();
    }
}
