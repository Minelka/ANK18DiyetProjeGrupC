using DP_DAL.Data;
using DP_DAL.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace DP_UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            DPDbContext context = new DPDbContext();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form5(context));

        }
     
    }
}