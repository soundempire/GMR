using GMR.BLL;
using GMR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMR
{
    public partial class CreateUserAccountForm : Form
    {
        private readonly IPersonService _personService;

        private readonly IPotentialLoginService _potentialLoginService;

        private readonly ILanguagesService _languagesService;

        public CreateUserAccountForm(IPersonService personService, IPotentialLoginService potentialLoginService, ILanguagesService languagesService)
        {
            InitializeComponent();

            _personService = personService;
            _potentialLoginService = potentialLoginService;
            _languagesService = languagesService;
        }

        private async void CreateUserAccountForm_Load(object sender, EventArgs e)
        {
            languagesCBox.DisplayMember = nameof(LanguageViewModel.Name);
            languagesCBox.DataSource = Mapper.Map<IEnumerable<LanguageModel>, IEnumerable<LanguageViewModel>>(await _languagesService.GetLanguages()).ToArray();
        }

        private void CreateUserAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            (_personService as IDisposable).Dispose();
            (_potentialLoginService as IDisposable).Dispose();
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        
    }
}
