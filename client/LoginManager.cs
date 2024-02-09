namespace Tritium
{
    public partial class LoginManager : Form
    {
        bool isNatural = false;
        public LoginManager()
        {
            InitializeComponent();
        }

        private void ManageDatabase_Click(object sender, EventArgs e)
        {
            isNatural = true;
            ManagerWindow.SwitchToWindow(new DatabaseManager(), this);
        }

        private void NaturalClosed()
        {
            if (!isNatural) ManagerWindow.instance.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManageMicrobeDB_Click(object sender, EventArgs e)
        {
            isNatural = true;
            ManagerWindow.SwitchToWindow(new MicrobeDBManager(), this);
        }
    }
}
