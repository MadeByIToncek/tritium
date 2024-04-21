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
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace Tritium.gui
{
    public partial class MeetingInterface : Form
    {
        readonly Navsteva meeting;
        public MeetingInterface(int meetingId)
        {
            InitializeComponent();
            meeting = Program.db.GetMeetingById(meetingId);
            LoadTexts();
            LoadOkruhy();
            LoadSkeny();
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
            skeny.DataSource = DesignerInterface.GenerateTScanList(Program.db.GetScansForMeeting(meeting.Id));

            foreach (DataGridViewColumn col in skeny.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            skeny.ResumeLayout(true);
        }

        //private string GenerateNoteFromNormalPlan(Plan item)
        //{
        //    if (item.Note && item.NoteContents != null)
        //    {
        //        return item.NoteContents + " (" + item.NoteDuration / 8400 + " d)";
        //    }
        //    else if (item.Programy != null && !item.Note)
        //    {
        //        StringBuilder sb = new();
        //        foreach (var prg in item.Programy)
        //        {
        //            sb.Append(prg.Name);
        //        }
        //        return sb.ToString();
        //    }
        //    else return "";
        //}

        private async void ScanPlus_Click(object sender, EventArgs e)
        {
            await Program.db.InsertSken(meeting);
            LoadSkeny();
        }

        private async void ScanMinus_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Opravdu chcete smazat scan " + GetCurrentSelection().Id + "?", "Opravdu?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                await Program.db.DeleteSken(GetCurrentSelection().Id);
                LoadSkeny();
            }
        }

        private TemporaryScan GetCurrentSelection()
        {
            IEnumerable<DataGridViewRow> selectedRows = skeny.SelectedCells.Cast<DataGridViewCell>()
                                           .Select(cell => cell.OwningRow)
                                           .Distinct();
            return (TemporaryScan)selectedRows.First().DataBoundItem;
        }

        //private async void ListView1_DoubleClick(object sender, EventArgs e)
        //{
        //}

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
                await SaveAll();
                SaveAndClose(new ClientDBInterface(meeting.Client.Id));
            }
        }

        private async void SaveAndClose(Form target)
        {
            closed = true;
            await SaveAll();
            ManagerWindow.SwitchToWindow(target, this);
        }

        private async void DesignerButton_Click(object sender, EventArgs e)
        {
            await SaveAll();
            SaveAndClose(new DesignerInterface(meeting.Id));
        }

        private async void Skeny_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                await SaveAll();
                SaveAndClose(new ScanEditInterface(GetCurrentSelection().Id));
            }
        }
    }
}
