using UEH_EVENT.GUI;

namespace UEH_EVENT
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyFakeData.Init();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
           //Application.Run(new formManageAccount());
        }
    }
}