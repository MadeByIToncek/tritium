namespace Tritium
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static DatabaseController lite;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //lite = new DatabaseController(Path.Combine(Environment.CurrentDirectory, "Database.db"));
            lite = new DatabaseController("localhost",3306,"tritium","root","123456789");
            //lite.LoadDemoSample();
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