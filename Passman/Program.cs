using Passman.Properties;

namespace Passman
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (Settings.Default.Username.Length == 0 || Settings.Default.Password.Length == 0)
            {
                RegisterForm frm = new RegisterForm();
                if (frm.ShowDialog() != DialogResult.OK)
                    Application.Exit();
            }
            else
            {
                LoginForm frm = new LoginForm();
                if (frm.ShowDialog() != DialogResult.OK)
                    Application.Exit();
            }
        }
    }
}