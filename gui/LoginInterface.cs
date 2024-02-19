using Tritium.gui;

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
                    listBox1.Items.Add("#"+item.Id);
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

        private void Select_Click(object sender, EventArgs e)
        {
            foreach (var item in Program.db.ListClients())
            {
                if (listBox1.SelectedItem != null && "#" + item.Id == (string)listBox1.SelectedItem)
                {
                    isNatural = true;
                    ManagerWindow.SwitchToWindow(new ClientDBInterface(item), this);
                    break;
                }
            }
        }
    }
}
