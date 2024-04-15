using NHibernate.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tritium.Entities;

namespace Tritium.gui
{
    public partial class MeetingInterface : Form
    {
        readonly Navsteva meeting;
        public MeetingInterface(int meetingId)
        {
            InitializeComponent();
            meeting = Program.db.GetMeetingsById(meetingId);
            LoadTexts();
            LoadOkruhy();
            LoadSkeny();
            //LoadPlany();
        }

        private void LoadTexts()
        {
            aktualniPotize.Text = meeting.AktualniPotize;
            nejviceObtezuje.Text = meeting.CoNejviceObtezuje;
            coVyresit.Text = meeting.CoChceVyresit;
        }

        private void LoadOkruhy()
        {
            okruh1.Items.Clear();
            okruh2.Items.Clear();

            foreach (Okruh item in Program.db.ListOkruhy())
            {
                okruh1.Items.Add(item.Name);
                okruh2.Items.Add(item.Name);
            };

            okruh1.SelectedItem = meeting.SkenOkr1.Name;
            okruh2.SelectedItem = meeting.SkenOkr2.Name;
        }

        private void LoadSkeny()
        {
            skeny.SuspendLayout();
            skeny.Items.Clear();

            foreach (Sken item in Program.db.GetScansForMeeting(meeting.Id))
            {
                ListViewItem vitem = new("$"+item.Id);
                vitem.SubItems.Add(new ListViewItem.ListViewSubItem(vitem, item.Okruh.Name));
                vitem.SubItems.Add(new ListViewItem.ListViewSubItem(vitem, item.Patogen.Name));
                vitem.SubItems.Add(new ListViewItem.ListViewSubItem(vitem, item.FRQ + ""));
                vitem.SubItems.Add(new ListViewItem.ListViewSubItem(vitem, item.HRV + ""));
                skeny.Items.Add(vitem);
            }

            skeny.ResumeLayout();
        }

        private void LoadPlany()
        {
            plany.SuspendLayout();
            plany.Items.Clear();

            foreach (Plan item in Program.db.GetPlansForMeeting(meeting.Id))
            {
                ListViewItem vitem = new("€" + item.Id);
                vitem.SubItems.Add(new ListViewItem.ListViewSubItem(vitem, item.Poradi + ""));
                vitem.SubItems.Add(new ListViewItem.ListViewSubItem(vitem, item.Note?"N":"P"));
                vitem.SubItems.Add(new ListViewItem.ListViewSubItem(vitem, GenerateNoteFromNormalPlan(item)));

                ListViewItem.ListViewSubItem done = new ListViewItem.ListViewSubItem(vitem, item.Done ? "✅" : "❌");
                done.ForeColor = item.Done ? Color.Lime : Color.Red;
                vitem.SubItems.Add(done);

                plany.Items.Add(vitem);
            }

            plany.ResumeLayout();
            plany.PerformLayout();
        }

        private string GenerateNoteFromNormalPlan(Plan item)
        {
            if (item.Note && item.NoteContents != null)
            {
                return item.NoteContents;
            }
            else if (item.Programy != null && !item.Note)
            {
                StringBuilder sb = new();
                foreach (var prg in item.Programy)
                {
                    sb.Append(prg.Name);
                }
                return sb.ToString();
            }
            else return "";
        }

        private async void ScanPlus_Click(object sender, EventArgs e)
        {
            await Program.db.InsertSken(meeting);
            LoadSkeny();
        }

        private async void ScanMinus_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Opravdu chcete smazat scan " + skeny.SelectedItems[0].Text + "?", "Opravdu?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                await Program.db.DeleteSken(int.Parse(skeny.SelectedItems[0].Text[1..]));
                LoadSkeny();
            }
        }

        private async void ListView1_DoubleClick(object sender, EventArgs e)
        {
            await SaveAll();

            if (meeting.SkenOkr1 == null || meeting.SkenOkr2 == null)
            {
                MessageBox.Show("Vyplňte prosím okruhy měřené na této návštěvě.");
                return;
            }
            else
            {
                closed = true;
                ManagerWindow.SwitchToWindow(new ScanEditInterface(int.Parse(skeny.SelectedItems[0].Text[1..])), this);
            }
        }

        private async Task SaveAll()
        {
            meeting.Date = dateTimePicker1.Value;
            meeting.AktualniPotize = aktualniPotize.Text;
            meeting.CoNejviceObtezuje = nejviceObtezuje.Text;
            meeting.CoChceVyresit = coVyresit.Text;
            meeting.SkenOkr1 = Program.db.GetOkruhByName((string)okruh1.SelectedItem);
            meeting.SkenOkr2 = Program.db.GetOkruhByName((string)okruh2.SelectedItem);

            await Program.db.UpdateMeeting(meeting);
        }

        bool closed = false;
        protected override async void OnClosing(CancelEventArgs e)
        {
            if (!closed)
            {
                closed = true;

                await SaveAll();

                ManagerWindow.SwitchToWindow(new ClientDBInterface(meeting.Client.Id), this);
                base.OnClosing(e);
            }
        }

    }
}
