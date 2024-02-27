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
            LoadOkruhy();
            LoadSkeny();
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

            okruh2.Items.Add("<empty>");
        }

        private void LoadSkeny()
        {
            listView1.SuspendLayout();
            listView1.Items.Clear();

            foreach (Sken item in Program.db.GetScansForMeeting(meeting.Id))
            {
                ListViewItem vitem = new(item.Okruh);
                listView1.Items.Add(vitem);
            }

            listView1.ResumeLayout();
        }

        private async void ScanPlus_Click(object sender, EventArgs e)
        {
            int id = await Program.db.InsertSken(meeting);
        }

        private void ScanMinus_Click(object sender, EventArgs e)
        {

        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        bool closed = false;
        protected override void OnClosing(CancelEventArgs e)
        {
            if (!closed)
            {
                closed = true;

                meeting.Date = dateTimePicker1.Value;
                meeting.AktualniPotize = aktualniPotize.Text;
                meeting.CoNejviceObtezuje = nejviceObtezuje.Text;
                meeting.CoChceVyresit = coVyresit.Text;
                meeting.SkenOkr1 = Program.db.GetOkruhByName((string)okruh1.SelectedItem);
                meeting.SkenOkr2 = Program.db.GetOkruhByName((string)okruh2.SelectedItem);

                Program.db.UpdateMeeting(meeting);
                ManagerWindow.SwitchToWindow(new ClientDBInterface(meeting.Client.Id), this);
                base.OnClosing(e);
            }
        }

    }
}
