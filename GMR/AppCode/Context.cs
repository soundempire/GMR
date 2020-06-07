using System.Windows.Forms;

namespace GMR
{
    internal static class Context
    {
        public static ApplicationContext MainContext { get; } = new ApplicationContext();

        public static void SetExecutableForm(Form form) => MainContext.MainForm = form;

        public static void ShowExecutableForm() => MainContext.MainForm.Show();
    }
}
