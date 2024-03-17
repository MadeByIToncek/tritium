using System.Text.RegularExpressions;
using System.Windows.Forms;
using Tritium.Entities;
using Tritium.gui;

namespace Tritium
{
    public partial class ClientDBInterface : Form
    {
        PatogenProgram? cpp = null;
        bool isLoaded = false;
        readonly Klient client;
        private readonly Regex regex = MatchMeetingId();
        static readonly System.Windows.Forms.Timer saveTimer = new();
        static readonly System.Windows.Forms.Timer IOIndicator = new();
        public ClientDBInterface(int clientId)
        {
            client = Program.db.GetClientById(clientId);
            InitializeComponent();
            ChangeState(false);
            UpdateList();
            LoadClient(client);
            ChangeState(true);

            saveTimer.Tick += async (o, ea) =>
            {
                await SaveClient();
                saveTimer.Stop();
            };
            saveTimer.Interval = 2000; // 2 seconds

            IOIndicator.Tick += (o, ea) =>
            {
                ioIdent.Text = "";
                ioIdent.ForeColor = Color.Black;
                IOIndicator.Stop();
            };
            IOIndicator.Interval = 2000; // 2 seconds
        }

        private async void ListBox1_MouseDoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                ChangeState(false);
                if(isLoaded) { await SaveClient(); }
                int id = int.Parse(regex.Match(listBox1.SelectedItem.ToString()).Value[1..]);
                closed = true;
                ManagerWindow.SwitchToWindow(new MeetingInterface(id), this);
            }
        }

        private void LoadClient(Klient cpp)
        {
            ChangeState(false);
            ioIdent.Text = "🔄";
            ioIdent.ForeColor = Color.Blue;
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
            ioIdent.Text = "✅";
            ioIdent.ForeColor = Color.Green;
            IOIndicator.Start();
            isLoaded = true;
            ChangeState(true);
        }

        private async Task SaveClient()
        {
            if (isLoaded)
            {
                ioIdent.Text = "🔄";
                ioIdent.ForeColor = Color.Blue;

                client.Jmeno = name.Text;
                client.DatumNarozeni = birthdate.Value;
                client.Telefon = phone.Text;
                client.Email = email.Text;
                client.Adresa = address.Text;
                client.Poznamka = notes.Text;
                client.Kardiostimulator = kardiostimulator.Checked;
                client.AktualniTehotenstvi = aktualniTehotenstvi.Checked;
                client.Epilepsie = epilepsie.Checked;
                client.AutoimunitniOnemocneni = AIOnemocneni.Text;
                client.KrevniTlak = krevniTlak.Text;
                client.DlouhodobePotize = dlouhodobePotize.Text;
                client.PredchazejiciNemoci = predchazejiciNemoci.Text;
                client.RodinnaAnamneza = rodinnaAnamneza.Text;
                client.Strava = strava.Text;
                client.Homeo = homeopatika.Text;
                client.OnkologickeOnemocneni = onko.Text;
                client.Leky = leky.Text;
                client.Traveni = traveni.Text;
                client.SituacePrace = sitPrace.Text;
                client.SituaceRodina = sitRodina.Text;
                client.SituaceOstatni = sitOstatni.Text;
                client.Rozpolozeni = rozpolozeni.Text;

                await Program.db.UpdateClient(client);

                ioIdent.Text = "✅";
                ioIdent.ForeColor = Color.Green;
                IOIndicator.Start();
            }
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
            sitOstatni.Enabled = state;
            rozpolozeni.Enabled = state;
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

        private async void Button1_Click(object sender, EventArgs e)
        {
            await Program.db.CreateEmptyMeetingWithClient(client);
            UpdateList();
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                foreach (var item in Program.db.ListPatogenPrograms())
                {
                    if (item.Name.Contains(listBox1.SelectedItem.ToString(), StringComparison.InvariantCultureIgnoreCase))
                    {
                        await Program.db.DeletePatogenProgram(item);
                        break;
                    }
                }
                listBox1.ClearSelected();
                UpdateList();
            }
        }

        private void DatabaseUpdate(object sender, EventArgs e)
        {
            saveTimer.Stop();
            saveTimer.Start();
        }

        [GeneratedRegex("&[0-9]+", RegexOptions.IgnoreCase, "en-GB")]
        private static partial Regex MatchMeetingId();
    }
}
