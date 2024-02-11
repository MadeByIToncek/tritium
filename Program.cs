using Microsoft.VisualBasic.ApplicationServices;

namespace Tritium
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static DatabaseController lite;
        static Form SplashScreen;
        static Form MainForm;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashScreen = new LoadingSplash();
            var splashThread = new Thread(new ThreadStart(
                () => Application.Run(SplashScreen)));
            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();

            lite = new DatabaseController("localhost", 3306, "tritium", "root", "123456789");
            MainForm = new ManagerWindow();
            //lite = new DatabaseController(Path.Combine(Environment.CurrentDirectory, "Database.db"));
            //lite.LoadDemoSample();
            MainForm.Load += MainForm_LoadCompleted;
            Application.Run(MainForm);
        }

        private static void MainForm_LoadCompleted(object sender, EventArgs e)
        {
            if (SplashScreen != null && !SplashScreen.Disposing && !SplashScreen.IsDisposed)
                SplashScreen.Invoke(new Action(() => SplashScreen.Close()));
            MainForm.TopMost = true;
            MainForm.Activate();
            MainForm.TopMost = false;
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