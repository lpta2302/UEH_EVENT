using UEH_EVENT.GUI.Mario;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            MyFakeData.Init();
            ApplicationConfiguration.Initialize();
            Application.Run(new frmPlayMario());
        }
    }
}