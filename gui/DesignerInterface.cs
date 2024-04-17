using System.ComponentModel;
using Tritium.Entities;

namespace Tritium.gui
{
    public partial class DesignerInterface : Form
    {
        readonly Navsteva meeting;
        public DesignerInterface(int meetingId)
        {
            meeting = Program.db.GetMeetingsById(meetingId);
            InitializeComponent();
            LoadSkeny();
            LoadLayout();
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

        private void LoadLayout()
        {
            GenerateMasterTablePanels();
            GenerateProgramLists();
        }

        private void GenerateMasterTablePanels()
        {
            int entries = meeting.Plany.Count;
            if (entries > 0)
            {
                masterGrid.RowCount = entries;
                for (int i = 0; i < entries; i++)
                {
                    DesignerDesigner designer = new();
                    //TableLayoutPanel subLayout = DesignerDesigner.GenerateSubLayout();
                    masterGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 600F));
                    masterGrid.Controls.Add(designer.subLayout);
                }
            }
            else
            {
                meeting.PridatPlan(new Plan()
                {
                    Navsteva = meeting,
                    Poradi = 1,
                    Done = false,
                    Note = false,
                    NoteContents = null,
                    NoteDuration = 0,
                });
                GenerateMasterTablePanels();
            }
        }

        private void GenerateProgramLists()
        {
        }

        public static List<TemporaryScan> GenerateTScanList(IList<Sken> skeny)
        {
            List<TemporaryScan> list = [];
            foreach (var item in skeny)
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

        private async Task SaveAll()
        {
            //TODO: Fill in all the saving parameters

            await Program.db.UpdateMeeting(meeting);
        }

        bool closed = false;
        protected override async void OnClosing(CancelEventArgs e)
        {
            if (!closed)
            {
                await SaveAll();
                SaveAndClose(new MeetingInterface(meeting.Id));
            }
        }

        private async void SaveAndClose(Form target)
        {
            closed = true;
            await SaveAll();
            ManagerWindow.SwitchToWindow(target, this);
        }

        private void SaveAndRefreshLayout(object sender, EventArgs e)
        {

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
