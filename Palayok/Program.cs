namespace Palayok
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

            // Load embedded fonts
            UI.FontManager.LoadEmbeddedFonts();

            Application.Run(new MainForm());
        }
    }
}