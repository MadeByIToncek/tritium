using Tritium.Entities;
using Tritium.gui;

namespace Tritium
{
    public partial class LoginInterface : Form
    {
        bool isNatural = false;
        public LoginInterface()
        {
            InitializeComponent();
            UpdateList();
        }

        private async void UpdateList()
        {
            listBox1.Items.Clear();
            foreach (var item in Program.db.ListClients())
            {
                listBox1.Items.Add("#" + item.Id);
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

        private async void Select_Click(object sender, EventArgs e)
        {
            foreach (Klient item in Program.db.ListClients())
            {
                if (listBox1.SelectedItem != null && "#" + item.Id == (string)listBox1.SelectedItem)
                {
                    isNatural = true;
                    ManagerWindow.SwitchToWindow(new ClientDBInterface(item.Id), this);
                    break;
                }
            }
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            await Program.db.CreateEmptyClient();
            UpdateList();
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Select_Click(sender, e);
        }
    }
}
