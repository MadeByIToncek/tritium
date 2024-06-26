﻿using System.Text.RegularExpressions;
using Tritium.Entities;
using Tritium.utils;

namespace Tritium
{
    public partial class MicrobeDBInterface : Form
    {
        PatogenProgram? cpp = null;
        bool insert = false;

        private readonly Regex pattern = MatchMicrobeId();

        public MicrobeDBInterface()
        {
            InitializeComponent();
            ClearForm();
            UpdateList();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                foreach (var item in Program.db.ListPatogenPrograms())
                {
                    if (item.Name.Contains(pattern.Replace(listBox1.SelectedItem.ToString(), ""), StringComparison.InvariantCultureIgnoreCase))
                    {
                        LoadPP(item);
                        break;
                    }
                }

            }
        }

        private void LoadPP(PatogenProgram cpp)
        {
            this.cpp = cpp;
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
            description.Text = cpp.Popis;

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
            description.Enabled = true;
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


        private static long UnparseTime(string text)
        {
            TimeSpan t = TimeSpan.Parse(text);
            return (long)Math.Round(t.TotalSeconds);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private async void Commit_Click(object sender, EventArgs e)
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
                cpp.Popis = description.Text;
                if (insert) await Program.db.InsertPatogenProgram(cpp);
                else await Program.db.UpdatePatogenProgram(cpp);
                cpp = null;
                ClearForm();
                UpdateList();
            }
        }

        private void UpdateList()
        {
            DrawingControl.SuspendDrawing(this);
            listBox1.Items.Clear();
            listBox1.ClearSelected();
            foreach (PatogenProgram item in Program.db.ListPatogenPrograms())
            {
                if (textBox2.Text.Length > 0)
                {
                    if (item.Name.Contains(textBox2.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        listBox1.Items.Add(item.Type + " - " + item.Name);
                    }
                }
                else
                {
                    listBox1.Items.Add(item.Type + " - " + item.Name);
                }

            }
            DrawingControl.ResumeDrawing(this);
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
            description.Text = "";

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
            description.Enabled = false;
            commit.Enabled = false;
            cancel.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClearForm();
            insert = true;
            listBox1.ClearSelected();
            LoadPP(new PatogenProgram()
            {
                MORTFRQs = "",
                Name = "",
                Okruhy = "",
                Onkovir = false,
                Par = false,
                Poznamky = "",
                Popis = "",
                Samostatne = false,
                StabKompAPasm = "",
                Time = 0,
                Type = ""
            });
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            cpp = null;
            ClearForm();
            listBox1.ClearSelected();
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                foreach (var item in Program.db.ListPatogenPrograms())
                {
                    if (item.Name.Contains(pattern.Replace(listBox1.SelectedItem.ToString(), ""), StringComparison.InvariantCultureIgnoreCase))
                    {
                        await Program.db.DeletePatogenProgram(item);
                        break;
                    }
                }
                ClearForm();
                listBox1.ClearSelected();
                UpdateList();
            }
        }

        [GeneratedRegex("[1-9A-Za-z]* - ", RegexOptions.CultureInvariant, "en-GB")]
        private static partial Regex MatchMicrobeId();
    }
}
