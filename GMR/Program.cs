﻿using System;
using System.Windows.Forms;
using GMR;
using Context = GMR.ApplicationContext;

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

                Context.SetExecutableForm(DIContainer.Resolve<LoginForm>());
                Application.Run(Context.MainContext);
            }
        }
    }
}
