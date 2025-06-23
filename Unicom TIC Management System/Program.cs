using Unicom_TIC_Management_System.Views;

namespace Unicom_TIC_Management_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InitialSetup.CreateDefaultAdmin();
            

            // Step 2: App execution continues
            Console.WriteLine("Welcome to Unicom TIC System");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MarkForm()); // First show login



        }
    }
}