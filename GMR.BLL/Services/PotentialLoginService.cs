using GMR.DAL;
using System;
using System.Threading.Tasks;

namespace GMR.BLL.Services
{
    public class PotentialLoginService : IPotentialLoginService, IDisposable
    {
        private readonly IPasswordRepository _passwordRepository;

        public PotentialLoginService(IPasswordRepository passwordRepository) => _passwordRepository = passwordRepository;

        public async Task<bool> IsLoginExists(string potentialLogin) 
            => await _passwordRepository.IsLoginExists(potentialLogin);

        public void Dispose() => _passwordRepository?.Dispose();
    }
}
