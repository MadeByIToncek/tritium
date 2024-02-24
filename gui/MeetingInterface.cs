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
            LoadOkruhy();
            this.meeting = Program.db.GetMeetingsById(meetingId);
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

        private void loadSkeny()
        {
            listView1.SuspendLayout();
            listView1.Items.Clear();

            foreach(Sken item in Program.db.GetScansForMeeting(meeting.Id))
            {
                //ListViewItem vitem = new ListViewItem(item.)
                //listView1.Items.Add();
            }

            listView1.ResumeLayout();
        }
    }
}
