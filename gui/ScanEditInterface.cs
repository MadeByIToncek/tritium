using System.ComponentModel;
using Tritium.Entities;

namespace Tritium.gui
{
    public partial class ScanEditInterface : Form
    {

        readonly Sken scan;
        public ScanEditInterface(int scanId)
        {
            InitializeComponent();
            SuspendLayout();

            scan = Program.db.GetScanById(scanId);
            LoadData();

            ResumeLayout();
            PerformLayout();

            PatogenList.MouseDoubleClick += (n,nn) => SubmitAndClose();
            HRV.KeyPress += CheckEnterKeyPress;
            FRQ.KeyPress += CheckEnterKeyPress;
        }

        private void CheckEnterKeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SubmitAndClose();
            }
        }

        private void SubmitAndClose()
        {
            OnClosing(null);
		}

        public void LoadData()
        {
            Okruh.Items.Clear();

            foreach (var item in GetListOfOkruhyFromNavsteva())
            {
                if(item == null) continue;
                Okruh.Items.Add(item.Name);
            };

            Okruh.SelectedItem = scan.Okruh.Name;

            FRQ.Text = scan.FRQ.ToString();
            HRV.Text = scan.HRV.ToString();

            SearchBox_TextChanged(null, null);

            PatogenList.SelectedItem = scan.Patogen.Type + " - " + scan.Patogen.Name + " - " + "~" + scan.Patogen.Id;
        }

        private List<Okruh> GetListOfOkruhyFromNavsteva()
        {
            return
            [
                scan.Navsteva.SkenOkr1,
                scan.Navsteva.SkenOkr2
            ];
        }

        private void SearchBox_TextChanged(object? sender, EventArgs? e)
        {
            PatogenList.SuspendLayout();
            PatogenList.Items.Clear();
            PatogenList.ClearSelected();
            foreach (PatogenProgram item in Program.db.ListPatogenPrograms())
            {
                if (SearchBox.Text.Length > 0)
                {
                    if (item.Name.Contains(SearchBox.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        PatogenList.Items.Add(item.Type + " - " + item.Name + " - " + "~" + item.Id);
                    }
                }
                else
                {
                    PatogenList.Items.Add(item.Type + " - " + item.Name + " - " + "~" + item.Id);
                }

            }
            PatogenList.ResumeLayout();
        }

        bool closed = false;
        protected async override void OnClosing(CancelEventArgs e)
        {
            if (!closed)
            {
                closed = true;

                scan.Okruh = Program.db.GetOkruhByName((string)Okruh.SelectedItem);
                scan.FRQ = float.Parse(FRQ.Text);
                scan.HRV = float.Parse(HRV.Text);
                scan.Patogen = ParsePatogen(((string)PatogenList.SelectedItem));
                await Program.db.UpdateSken(scan);

                ManagerWindow.SwitchToWindow(new MeetingInterface(scan.Navsteva.Id), this);
            }
        }

        private static PatogenProgram ParsePatogen(string selectedItem)
        {
            PatogenProgram patogenProgram = Program.db.GetPatogenById(selectedItem.Split(" - ")[2][1..]);
            return patogenProgram;
        }
    }
}
