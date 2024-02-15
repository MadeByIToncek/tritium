﻿using Tritium.Entities;

namespace Tritium
{
    public partial class MicrobeDBManager : Form
    {
        readonly List<PatogenProgram> programList = [];
        PatogenProgram? cpp = null;
        public MicrobeDBManager()
        {
            InitializeComponent();
            foreach (PatogenProgram ppgrm in Program.db.ListPatogenPrograms())
            {
                programList.Add(ppgrm);
            };
            ClearForm();
            UpdateList();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                foreach (var item in programList)
                {
                    if (item.Name.Contains(listBox1.SelectedItem.ToString(), StringComparison.InvariantCultureIgnoreCase))
                    {
                        cpp = item;
                        name.Text = cpp.Name;
                        dlazdice.Text = cpp.Type;
                        cas.Text = ParseTime(cpp.Time);
                        samostatne.Checked = cpp.Samostatne;
                        onkovir.Checked = cpp.Onkovir;
                        parovy.Checked = cpp.Par;
                        morty.Text = cpp.MORTFRQs;
                        skPasma.Text = cpp.StabKompAPasm;
                        okruhy.Text = cpp.Okruhy;
                        poznamky.Text = cpp.Poznamky;

                        name.Enabled = true;
                        dlazdice.Enabled = true;
                        cas.Enabled = true;
                        samostatne.Enabled = true;
                        onkovir.Enabled = true;
                        parovy.Enabled = true;
                        morty.Enabled = true;
                        skPasma.Enabled = true;
                        okruhy.Enabled = true;
                        poznamky.Enabled = true;
                        commit.Enabled = true;
                        cancel.Enabled = true;
                        break;
                    }
                }

            }
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
            return (long) Math.Round(t.TotalSeconds);
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
                cpp.Time = UnparseTime(cas.Text);
                cpp.Samostatne = samostatne.Checked;
                cpp.Onkovir = onkovir.Checked;
                cpp.Par = parovy.Checked;
                cpp.MORTFRQs = morty.Text;
                cpp.StabKompAPasm = skPasma.Text;
                cpp.Okruhy = okruhy.Text;
                cpp.Poznamky = poznamky.Text;
                Program.db.UpdatePatogenProgram(cpp);
                cpp = null;
                ClearForm();
                UpdateList();
            }
        }

        private void UpdateList()
        {
            listBox1.Items.Clear();
            listBox1.ClearSelected();
            foreach (PatogenProgram item in programList)
            {
                if (textBox2.Text.Length > 0)
                {
                    if (item.Name.Contains(textBox2.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        listBox1.Items.Add(item.Name);
                    }
                }
                else
                {
                    listBox1.Items.Add(item.Name);
                }

            }
        }

        private void ClearForm()
        {
            name.Text = "";
            dlazdice.Text = "";
            cas.Text = "";
            samostatne.Checked = false;
            onkovir.Checked = false;
            parovy.Checked = false;
            morty.Text = "";
            skPasma.Text = "";
            okruhy.Text = "";
            poznamky.Text = "";

            name.Enabled = false;
            dlazdice.Enabled = false;
            cas.Enabled = false;
            samostatne.Enabled = false;
            onkovir.Enabled = false;
            parovy.Enabled = false;
            morty.Enabled = false;
            skPasma.Enabled = false;
            okruhy.Enabled = false;
            poznamky.Enabled = false;
            commit.Enabled = false;
            cancel.Enabled = false;
        }
    }
}
