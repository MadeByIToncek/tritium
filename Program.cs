using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json.Linq;
using System.Text;

namespace Tritium
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static DatabaseController db;
        static Form SplashScreen;
        static Form MainForm;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var splashThread = new Thread(new ThreadStart(
                () =>
                {
                    SplashScreen = new SplashInterface();

                    Application.Run(SplashScreen);
                }));
            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();

            db = LoadDatabaseConfig();
            //db = new DatabaseController("localhost", 3306, "tritium", "root", "123456789");
            MainForm = new ManagerWindow();
            MainForm.Load += MainForm_LoadCompleted;
            Application.Run(MainForm);
        }

        private static DatabaseController LoadDatabaseConfig()
        {
            try
            {
                JObject filecontent;
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tritium"));
                using (var sr = new StreamReader(Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tritium"), "config.json")))
                {
                    filecontent = JObject.Parse(sr.ReadToEnd());
                }

                bool isLocal = filecontent["isLocal"].Value<bool>();
                if (isLocal)
                {
                    return new DatabaseController(filecontent["path"].Value<string>());
                }
                else
                {
                    JObject mysql = filecontent["mysql"].Value<JObject>();
                    string address = mysql["address"].Value<string>();
                    int port = mysql["port"].Value<int>();
                    string database = mysql["database"].Value<string>();
                    string user = mysql["user"].Value<string>();
                    string password = mysql["password"].Value<string>();
                    return new DatabaseController(address,port,database,user,password);
                }
            }
            catch (FileNotFoundException)
            {
                JObject content = new JObject(
                    new JProperty("isLocal", true),
                    new JProperty("path", Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tritium"), "database.db")),
                    new JProperty("mysql",  new JObject(
                        new JProperty("address", "localhost"),
                        new JProperty("port", 3306),
                        new JProperty("database", "tritium"),
                        new JProperty("user", "root"),
                        new JProperty("password", "123456789")
                    )));
                try
                {
                    File.WriteAllText(Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tritium"), "config.json"), content.ToString());
                } catch (Exception e) { 
                    MessageBox.Show(e.Message);
                }
                return LoadDatabaseConfig();
            }
        }

        private static void MainForm_LoadCompleted(object sender, EventArgs e)
        {
            if (SplashScreen != null && !SplashScreen.Disposing && !SplashScreen.IsDisposed)
                SplashScreen.Invoke(new Action(() => SplashScreen.Close()));
            MainForm.TopMost = true;
            MainForm.Activate();
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

            var Login = new LoginInterface();
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