using System;
using System.Windows.Forms;
using GMR.LayoutRoot;

namespace GMR
{
    static class Program
    {
         [STAThread]
        static void Main()
        {
            using (DIContainer.Scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(DIContainer.Resolve<LoginForm>());
            }
        }
    }
}
