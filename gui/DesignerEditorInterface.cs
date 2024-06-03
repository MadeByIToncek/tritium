using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tritium.Entities;
using Tritium.utils;

namespace Tritium.gui
{
    public partial class DesignerEditorInterface : Form
    {
        bool closed = false;
        private readonly int MeetingId;
        private readonly PlanEntry PlanEntry;
        private readonly Regex pattern = MatchMicrobeId();

        public DesignerEditorInterface(int MeetingId, int PlanEntryID)
        {
            InitializeComponent();
            this.MeetingId = MeetingId;
            PlanEntry = Program.db.GetPlanEntry(PlanEntryID);
            UpdateList();
            listBox1.SelectedItem = PlanEntry.Program.Type + " - " + PlanEntry.Program.Name;
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

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateList();
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

        private void LoadPP(PatogenProgram cpp)
        {
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
        }

        private void SaveAll()
        {
            //TODO: Fill in all the saving parameters
            Program.db.UpdatePlanEntry(PlanEntry);
        }

        protected override async void OnClosing(CancelEventArgs e)
        {
            if (!closed)
            {
                SaveAll();
                SaveAndClose(new DesignerInterface(MeetingId));
            }
        }

        private async void SaveAndClose(Form target)
        {
            closed = true;
            SaveAll();
            ManagerWindow.SwitchToWindow(target, this);
        }

        private static string ParseTime(long time)
        {
            TimeSpan t = TimeSpan.FromSeconds(time);

            return string.Format("{0:D2}:{1:D2}:{2:D2}",
                            t.Hours,
                            t.Minutes,
                            t.Seconds);
        }


        [GeneratedRegex("[1-9A-Za-z]* - ", RegexOptions.CultureInvariant, "en-GB")]
        private static partial Regex MatchMicrobeId();
    }
}
