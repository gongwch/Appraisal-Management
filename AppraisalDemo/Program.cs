using AppraisalDemo.Utilities;
using System.Configuration;

namespace AppraisalDemo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SqlHelper.ConStr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Frnmain());
        }
    }
}