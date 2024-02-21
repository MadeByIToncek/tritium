using System.Text.RegularExpressions;
using Tritium.Entities;
using Tritium.gui;

namespace Tritium
{
    public partial class ClientDBInterface : Form
    {
        PatogenProgram? cpp = null;
        bool insert = false;
        readonly Klient client;
        private readonly Regex regex = new("&[0-9]+", RegexOptions.IgnoreCase);
        public ClientDBInterface(int clientId)
        {
            client = Program.db.GetClientById(clientId);
            InitializeComponent();
            UpdateList();
            LoadClient(client);
        }

        private void ListBox1_MouseDoubleClick(object sender, EventArgs e)
        {
            int id = int.Parse(regex.Match(listBox1.SelectedItem.ToString()).Value[1..]);
            closed = true;
            ManagerWindow.SwitchToWindow(new MeetingInterface(id), this);
        }

        private void LoadClient(Klient cpp)
        {
            ChangeState(false);
            name.Text = cpp.Jmeno;
            birthdate.Value = cpp.DatumNarozeni;
            phone.Text = cpp.Telefon;
            email.Text = cpp.Email;
            address.Text = cpp.Adresa;
            notes.Text = cpp.Poznamka;
            kardiostimulator.Checked = cpp.Kardiostimulator;
            aktualniTehotenstvi.Checked = cpp.AktualniTehotenstvi;
            epilepsie.Checked = cpp.Epilepsie;
            AIOnemocneni.Text = cpp.AutoimunitniOnemocneni;
            krevniTlak.Text = cpp.KrevniTlak;
            dlouhodobePotize.Text = cpp.DlouhodobePotize;
            predchazejiciNemoci.Text = cpp.PredchazejiciNemoci;
            rodinnaAnamneza.Text = cpp.RodinnaAnamneza;
            strava.Text = cpp.Strava;
            homeopatika.Text = cpp.Homeo;
            onko.Text = cpp.OnkologickeOnemocneni;
            leky.Text = cpp.Leky;
            traveni.Text = cpp.Traveni;
            sitPrace.Text = cpp.SituacePrace;
            sitRodina.Text = cpp.SituaceRodina;
            sitOstatni.Text = cpp.SituaceOstatni;
            rozpolozeni.Text = cpp.Rozpolozeni;
        }

        private void ChangeState(bool state)
        {
            name.Enabled = state;
            birthdate.Enabled = state;
            phone.Enabled = state;
            email.Enabled = state;
            address.Enabled = state;
            notes.Enabled = state;
            kardiostimulator.Enabled = state;
            aktualniTehotenstvi.Enabled = state;
            epilepsie.Enabled = state;
            AIOnemocneni.Enabled = state;
            krevniTlak.Enabled = state;
            dlouhodobePotize.Enabled = state;
            predchazejiciNemoci.Enabled = state;
            rodinnaAnamneza.Enabled = state;
            strava.Enabled = state;
            homeopatika.Enabled = state;
            onko.Enabled = state;
            leky.Enabled = state;
            traveni.Enabled = state;
            sitPrace.Enabled = state;
            sitRodina.Enabled = state;
            sitOstatni  .Enabled = state;
            rozpolozeni.Enabled = state;
            commit.Enabled = state;
            cancel.Enabled = state;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void Commit_Click(object sender, EventArgs e)
        {
            if (cpp != null)
            {
                cpp.Name = name.Text;
                cpp.Type = dlazdice.Text;
                cpp.Poznamky = notes.Text;
                if (insert) Program.db.InsertPatogenProgram(cpp);
                else Program.db.UpdatePatogenProgram(cpp);
                cpp = null;
                UpdateList();
            }
        }

        private void UpdateList()
        {
            listBox1.Items.Clear();
            listBox1.ClearSelected();
            foreach (Navsteva item in client.Navstevy)
            {
                listBox1.Items.Add(item.Date + " - &" + item.Id);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Program.db.CreateEmptyMeetingWithClient(client);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            cpp = null;
            listBox1.ClearSelected();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                foreach (var item in Program.db.ListPatogenPrograms())
                {
                    if (item.Name.Contains(listBox1.SelectedItem.ToString(), StringComparison.InvariantCultureIgnoreCase))
                    {
                        Program.db.DeletePatogenProgram(item);
                        break;
                    }
                }
                listBox1.ClearSelected();
                UpdateList();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
