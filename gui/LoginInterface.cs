using System.Linq;
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

        private void UpdateList()
        {
            listBox1.Items.Clear();
            Klient[] klients = Program.db.ListClients().ToArray();
            Array.Sort(klients, (x1, x2) => x1.Jmeno.CompareTo(x2.Jmeno));
            foreach (var item in klients)
            {
                listBox1.Items.Add("#" + item.Id + " - " + item.Jmeno);
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
            foreach (Klient item in Program.db.ListClients())
            {
                if (listBox1.SelectedItem != null && ((string)listBox1.SelectedItem).StartsWith("#" + item.Id))
                {
                    isNatural = true;
                    ManagerWindow.SwitchToWindow(new ClientDBInterface(item.Id), this);
                    break;
                }
            }
        }

        private async void plus_click(object sender, EventArgs e)
        {
            await Program.db.CreateEmptyClient();
            UpdateList();
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Select_Click(sender, e);
        }

        private void minus_click(object sender, EventArgs e)
        {
            foreach (Klient item in Program.db.ListClients())
            {
                if (listBox1.SelectedItem != null && ((string)listBox1.SelectedItem).StartsWith("#" + item.Id))
                {
                    isNatural = true;
                    ManagerWindow.SwitchToWindow(new DeleteProtection(item.Id), this);
                    break;
                }
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            isNatural = true;
            ManagerWindow.SwitchToWindow(new AboutBox1(), this);
        }
    }
}
