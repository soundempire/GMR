using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.BLL
{
    public interface ILanguagesService
    {
        Task<IEnumerable<LanguageModel>> GetLanguages(params string[] idFilter);
    }
}
