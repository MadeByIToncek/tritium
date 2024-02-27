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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        }

        public void LoadData()
        {
            Okruh.Items.Clear();
            foreach (var item in GetListOfOkruhyFromNavsteva())
            {
                Okruh.Items.Add(item.Name);
            };

            FRQ.Text = scan.FRQ.ToString();
            HRV.Text = scan.HRV.ToString();

            SearchBox_TextChanged(null, null);
        }

        private List<Okruh> GetListOfOkruhyFromNavsteva()
        {

            return
            [
                scan.Navsteva.SkenOkr1,
                scan.Navsteva.SkenOkr2
            ];
        }

        private async void SearchBox_TextChanged(object? sender, EventArgs? e)
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
                        PatogenList.Items.Add(item.Type + " - " + item.Name);
                    }
                }
                else
                {
                    PatogenList.Items.Add(item.Type + " - " + item.Name);
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

                scan.Okruh = (string) Okruh.SelectedItem;
                scan.FRQ = float.Parse(FRQ.Text);
                scan.HRV = float.Parse(HRV.Text);
                scan.Patogen = ParsePatogen((string) PatogenList.SelectedItem);

                await Program.db.UpdateSken(scan);
                ManagerWindow.SwitchToWindow(new MeetingInterface(scan.Navsteva.Id), this);
                base.OnClosing(e);
            }
        }

        private static PatogenProgram ParsePatogen(string selectedItems)
        {
            foreach (var item in Program.db.ListPatogenPrograms())
            {
                if (item.Name == selectedItems)
                {
                    return item;
                }
            }
            return Program.db.GetEmptyPatogen();
        }
    }
}
