namespace Tritium
{
    public partial class LoginInterface : Form
    {
        bool isNatural = false;
        public LoginInterface()
        {
            InitializeComponent();
            foreach (var item in Program.db.ListClients())
            {
                if (item.Jmeno != null)
                {
                    listBox1.Items.Add(item.Jmeno);
                }
            };
        }

        private void NaturalClosed()
        {
            if (!isNatural && ManagerWindow.instance != null) ManagerWindow.instance.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManageMicrobeDB_Click(object sender, EventArgs e)
        {
            isNatural = true;
            ManagerWindow.SwitchToWindow(new MicrobeDBInterface(), this);
        }

        private void ManageClients_Click(object sender, EventArgs e)
        {
            isNatural = true;
            ManagerWindow.SwitchToWindow(new ClientDBInterface(), this);
        }
    }
}
