using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMR.BLL.Services
{
    public class LanguagesService : ILanguagesService
    {
        private readonly IEnumerable<LanguageModel> _languages = new LanguageModel[] {
            new LanguageModel(){ Id ="ru", Name = "Русский" },
            new LanguageModel(){ Id ="en", Name = "English" }
        };

        public Task<IEnumerable<LanguageModel>> GetLanguages(params string[] idFilter)
        {
            if (idFilter.Length > 0)
                return Task.FromResult(_languages.Where(x => idFilter.Contains(x.Id)));

            return Task.FromResult(_languages);
        }
    }
}
