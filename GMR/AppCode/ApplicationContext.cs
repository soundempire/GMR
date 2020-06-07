using System.Windows.Forms;

namespace GMR
{
    internal static class ApplicationContext
    {
        public static System.Windows.Forms.ApplicationContext MainContext { get; } = new System.Windows.Forms.ApplicationContext();

        public static void SetExecutableForm(Form form) => MainContext.MainForm = form;

        public static void ShowExecutableForm() => MainContext.MainForm.Show();
    }
}
