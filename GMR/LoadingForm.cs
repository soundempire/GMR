using GMR.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Context = GMR.ApplicationContext;

namespace GMR
{
    public partial class LoadingForm : Form
    {
        private readonly IHealthCheckService _healthCheckService;

        public LoadingForm(IHealthCheckService healthCheckService)
        {
            InitializeComponent();

            _healthCheckService = healthCheckService;
        }

        private async void LoadingForm_Load(object sender, EventArgs e)
        {
            /*
             Used Task.Run(..) here because here is the first call to DB with context (create connection, etg.)
             and it will take much time and will lock main UI thread, even though the call is asynchronous
             */
            var result = await Task.Run(async () => await _healthCheckService.IsApplicationAvailable());

            if (!result)
                throw new Exception("Ошибка инициализации базы данных");

            Context.SetExecutableForm(DIContainer.Resolve<LoginForm>());
            Context.ShowExecutableForm();

            Close();
        }

        private void LoadingForm_FormClosing(object sender, FormClosingEventArgs e) => (_healthCheckService as IDisposable)?.Dispose();
    }
}
