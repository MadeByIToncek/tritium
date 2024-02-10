namespace Tritium
{
    public partial class LoginManager : Form
    {
        bool isNatural = false;
        public LoginManager()
        {
            InitializeComponent();
            foreach (var item in Program.lite.ListClients())
            {
                listBox1.Items.Add(item.Jmeno);
            };
        }

        private void ManageDatabase_Click(object sender, EventArgs e)
        {
            isNatural = true;
            //ManagerWindow.SwitchToWindow(new DatabaseManager(), this);
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
