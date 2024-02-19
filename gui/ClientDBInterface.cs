using Tritium.Entities;

namespace Tritium
{
    public partial class ClientDBInterface : Form
    {
        PatogenProgram? cpp = null;
        bool insert = false;
        readonly Klient client;
        public ClientDBInterface(Klient client)
        {
            InitializeComponent();
            ClearForm();
            UpdateList();
            this.client = client;

        }

        private void ListBox1_MouseDoubleClick(object sender, EventArgs e)
        {
            ;
        }

        private void loadPP(PatogenProgram cpp)
        {
            this.cpp = cpp;
            name.Text = cpp.Name;
            dlazdice.Text = cpp.Type;
            poznamky.Text = cpp.Poznamky;

            name.Enabled = true;
            dlazdice.Enabled = true;
            poznamky.Enabled = true;
            commit.Enabled = true;
            cancel.Enabled = true;
        }

        private static string ParseTime(long time)
        {
            TimeSpan t = TimeSpan.FromSeconds(time);

            return string.Format("{0:D2}:{1:D2}:{2:D2}",
                            t.Hours,
                            t.Minutes,
                            t.Seconds);
        }


        private long UnparseTime(string text)
        {
            TimeSpan t = TimeSpan.Parse(text);
            return (long)Math.Round(t.TotalSeconds);
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
                cpp.Poznamky = poznamky.Text;
                if (insert) Program.db.InsertPatogenProgram(cpp);
                else Program.db.UpdatePatogenProgram(cpp);
                cpp = null;
                ClearForm();
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

        private void ClearForm()
        {

            name.Text = "";
            dlazdice.Text = "";
            poznamky.Text = "";

            name.Enabled = false;
            dlazdice.Enabled = false;
            poznamky.Enabled = false;
            commit.Enabled = false;
            cancel.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClearForm();
            insert = true;
            listBox1.ClearSelected();
            loadPP(new PatogenProgram()
            {
                MORTFRQs = "",
                Name = "",
                Okruhy = "",
                Onkovir = false,
                Par = false,
                Poznamky = "",
                Samostatne = false,
                StabKompAPasm = "",
                Time = 0,
                Type = ""
            });
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            cpp = null;
            ClearForm();
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
                ClearForm();
                listBox1.ClearSelected();
                UpdateList();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
