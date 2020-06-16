using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using GMR;
using GMR.Logging;
using Context = GMR.ApplicationContext;

namespace GMR
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
            Application.SetCompatibleTextRenderingDefault(false);

            using (DIContainer.Scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                var logger = DIContainer.Resolve<ILogger>();
                try
                {
                    Context.SetExecutableForm(DIContainer.Resolve<LoginForm>());
                    Application.Run(Context.MainContext);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"В приложении произошла ошибка.\nПожалуйста предоставьте файл логгирования ({Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs")}) разработчикам.", "Ошибка выполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.LogError(ex);
                }
            }
        }
    }
}
