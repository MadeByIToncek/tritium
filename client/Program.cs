using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System.Runtime.Serialization;
using Tritium.databases;

namespace Tritium
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManagerWindow());
        }
    }

    public partial class ManagerWindow : Form
    {
        public static ManagerWindow? instance;
        public static Form? runningWindow;
        public ManagerWindow()
        {
            instance = this;
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Visible = false;

            var Login = new LoginManager();
            runningWindow = Login;
            Login.Show();
        }

        public static void SwitchToWindow(Form target, Form source)
        {
            source.Hide();
            runningWindow = target;
            target.Show();
            source.Close();
        }
    }

    [Serializable]
    internal class NotConnectedException : Exception
    {
        public NotConnectedException()
        {
            throw new Exception("Database has not fully connected yet, please investigate!");
        }
    }
}