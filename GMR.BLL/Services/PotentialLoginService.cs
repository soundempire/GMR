using GMR.DAL;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace GMR.BLL.Services
{
    public class PotentialLoginService : IPotentialLoginService, IDisposable
    {
        private readonly IRepository<Password> _passwordRepository;

        public PotentialLoginService(IRepository<Password> passwordRepository) => _passwordRepository = passwordRepository;

        public async Task<bool> IsLoginExists(string potentialLogin) 
            => await _passwordRepository.GetAll().AnyAsync(_ => _.Login.Equals(potentialLogin));

        public void Dispose() => _passwordRepository?.Dispose();
    }
}
