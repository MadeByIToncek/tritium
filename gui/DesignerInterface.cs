using System.ComponentModel;
using Tritium.Entities;
using Tritium.utils;

namespace Tritium.gui
{
    public partial class DesignerInterface : Form
    {
        Navsteva meeting;
        private readonly List<DesignerDesigner> activeRows = [];
        private readonly List<Control> planningLayout = [];
        public DesignerInterface(int meetingId)
        {
            meeting = Program.db.GetMeetingById(meetingId);
            InitializeComponent();
            LoadInfo();
            LoadSkeny();
            GenerateMasterTablePanels();
        }

        private void LoadInfo()
        {
            username.Text = meeting.Client.Jmeno;
            Date.Text = meeting.Client.DatumNarozeni.ToString("dd. mm. yyyy");
            MeetingNumberAndDate.Text = meeting.Id + " (" + meeting.Date.ToString("dd. mm. yyyy") + ")";
        }

        private void LoadSkeny()
        {
            skeny.SuspendLayout();
            skeny.DataSource = GenerateTScanList(Program.db.GetScansForMeeting(meeting.Id));

            foreach (DataGridViewColumn col in skeny.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            skeny.ResumeLayout(true);
        }

        private async void GenerateMasterTablePanels()
        {
            DrawingControl.SuspendDrawing(this);
            int entries = meeting.Plany.Count;
            if (entries > 0)
            {
                masterGrid.RowCount = entries;
                masterGrid.RowStyles.Clear();
                for (int i = 0; i < entries; i++)
                {
                    DesignerDesigner designer = new(meeting.Plany[i], SaveAndRefreshLayout, planningLayout, SaveAndClose);
                    //TableLayoutPanel subLayout = DesignerDesigner.GenerateSubLayout();
                    masterGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 500F));
                    masterGrid.Controls.Add(designer.subLayout);
                    activeRows.Add(designer);
                }
                masterGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            }
            else
            {
                CreateNewPlan_Click(null,null);
            }
            DrawingControl.ResumeDrawing(this);
        }

        public static List<TemporaryScan> GenerateTScanList(IList<Sken> skeny)
        {
            List<TemporaryScan> list = [];
            foreach (var item in skeny.OrderBy(x => x.FRQ)
                .ThenBy(x => x.HRV)
                .ThenBy(x => x.Patogen.Name))
            {
                TemporaryScan scan = new()
                {
                    Id = item.Id,
                    Okruh = item.Okruh.Name,
                    PatogenType = item.Patogen.Type,
                    PatogenName = item.Patogen.Name,
                    SOP = Booleanify(item.Patogen.Samostatne) + Booleanify(item.Patogen.Onkovir) + Booleanify(item.Patogen.Onkovir),
                    FRQ = item.FRQ,
                    HRV = item.HRV,
                };
                list.Add(scan);
            };

            return list;
        }

        private static string Booleanify(bool boolean)
        {
            return boolean ? "✅" : "❌";
        }

        private void SaveAll()
        {
            //TODO: Fill in all the saving parameters

            Program.db.UpdateMeeting(meeting);
        }

        bool closed = false;
        protected override async void OnClosing(CancelEventArgs e)
        {
            if (!closed)
            {
                SaveAll();
                SaveAndClose(new MeetingInterface(meeting.Id));
            }
        }

        private async void SaveAndClose(Form target)
        {
            closed = true;
            SaveAll();
            ManagerWindow.SwitchToWindow(target, this);
        }

        private void SaveAndRefreshLayout(object? sender, EventArgs? e)
        {
            activeRows.ForEach(row => {
                masterGrid.Controls.Remove(row.subLayout);
            });

            meeting = Program.db.GetMeetingById(meeting.Id);

            GenerateMasterTablePanels();
        }

        private async void CreateNewPlan_Click(object? sender, EventArgs? e)
        {
            meeting.PridatPlan(new Plan()
            {
                Navsteva = meeting,
                Poradi = Program.db.GetNextOrderForPlan(meeting),
                Done = false,
                Note = false,
                NoteContents = null,
                NoteDuration = 0,
            });
            Program.db.UpdateMeeting(meeting);

            SaveAndRefreshLayout(sender,e);
        }
    }

    public class TemporaryScan
    {
        public int Id { get; set; }
        public string Okruh { get; set; }
        public string PatogenType { get; set; }
        public string PatogenName { get; set; }
        public string SOP { get; set; }
        public float FRQ { get; set; }
        public float HRV { get; set; }
    }
}
