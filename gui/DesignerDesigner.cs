using Mysqlx.Session;
using System.Security.Policy;
using System.Windows.Forms;
using Tritium.Entities;

namespace Tritium.gui
{
    internal class DesignerDesigner
    {

        public TableLayoutPanel subLayout;
        public readonly Plan plan;
        public Button? recycle;
        public CheckBox? note;
        public CheckBox? done;

        private readonly Dictionary<int, RowDesigner> rows = [];
        private readonly Action<object?, EventArgs> saveAndRefreshLayout;
        private readonly Action<Form> SaveAndClose;

        public DesignerDesigner(Plan plan, Action<object?, EventArgs> saveAndRefreshLayout, List<Control> planningLayout, Action<Form> rootWindow)
        {
            this.plan = plan;
            this.saveAndRefreshLayout = saveAndRefreshLayout;
            this.SaveAndClose = rootWindow; 
            subLayout = GenerateSubLayout();

            recycle.Click += async (o, e) =>
            {
                await Program.db.DeletePlan(plan);
                saveAndRefreshLayout(o,e);
            };
            note.Click += async (o, e) =>
            {
                plan.Note = note.Checked;
                await Program.db.UpdatePlan(plan);
                saveAndRefreshLayout(o, e);
            };
            done.Click += async (o, e) =>
            {
                plan.Done = done.Checked;
                await Program.db.UpdatePlan(plan);
                saveAndRefreshLayout(o, e);
            };
        }

        public TableLayoutPanel GenerateSubLayout()
        {   
            TableLayoutPanel subLayout = new();
            // 
            // subLayout
            // 
            subLayout.ColumnCount = 2;
            subLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11F));
            subLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89F));
            subLayout.Controls.Add(GenerateAPanel(), 0, 0);
            subLayout.Controls.Add(GenerateBPanel(), 1, 0);
            subLayout.Dock = DockStyle.Fill;
            subLayout.Location = new Point(4, 4);
            subLayout.Name = "subLayout";
            subLayout.RowCount = 1;
            subLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            subLayout.Size = new Size(1334, 594);
            subLayout.TabIndex = 0;

            return subLayout;
        }

        private TableLayoutPanel GenerateBPanel()
        {

            // 
            // subLayoutBController
            // 
            TableLayoutPanel subLayoutBController = new();
            subLayoutBController.ColumnCount = 1;
            subLayoutBController.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            subLayoutBController.Dock = DockStyle.Fill;
            subLayoutBController.Location = new Point(149, 3);
            subLayoutBController.Name = "subLayoutBController";
            subLayoutBController.RowCount = 10;
            subLayoutBController.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            subLayoutBController.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            subLayoutBController.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            subLayoutBController.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            subLayoutBController.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            subLayoutBController.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            subLayoutBController.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            subLayoutBController.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            subLayoutBController.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            subLayoutBController.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            subLayoutBController.Size = new Size(1180, 588);
            subLayoutBController.TabIndex = 1;

            for (int i = 0; i < 10; i++)
            {
                subLayoutBController.Controls.Add(GenerateRow(i), 0, i);
            }

            return subLayoutBController;
        }

        private TableLayoutPanel GenerateRow(int i)
        {
            RowDesigner designer = new(FindPlanEntry(i, plan.Programy),plan,i, SaveAndClose);
            rows.Add(i,designer);
            return designer.GenerateLayout();
        }

        private static PlanEntry? FindPlanEntry(int i, IList<PlanEntry>? programy)
        {
            if (programy != null)
            {
                foreach (var item in programy)
                {
                    if (item.Poradi == i)
                    {
                        return item;
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }

        private TableLayoutPanel GenerateAPanel()
        {
            TableLayoutPanel subLayoutAController = new();
            // 
            // subLayoutAController
            // 
            subLayoutAController.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            subLayoutAController.ColumnCount = 1;
            subLayoutAController.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            subLayoutAController.Controls.Add(GenerateRecycleButton(), 0, 2);
            subLayoutAController.Controls.Add(GenerateIndex(), 0, 0);
            subLayoutAController.Controls.Add(GenerateSwitchPanel(), 0, 1);
            subLayoutAController.Dock = DockStyle.Fill;
            subLayoutAController.Location = new Point(3, 3);
            subLayoutAController.Name = "subLayoutAController";
            subLayoutAController.RowCount = 3;
            subLayoutAController.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            subLayoutAController.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            subLayoutAController.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            subLayoutAController.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            subLayoutAController.Size = new Size(140, 588);
            subLayoutAController.TabIndex = 0;

            return subLayoutAController;
        }

        private TableLayoutPanel GenerateSwitchPanel()
        {
            TableLayoutPanel SwitchPanel = new();
            note = new();
            done = new();

            // 
            // SwitchPanel
            // 
            SwitchPanel.ColumnCount = 1;
            SwitchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            SwitchPanel.Controls.Add(note, 0, 0);
            SwitchPanel.Controls.Add(done, 0, 1);
            SwitchPanel.Dock = DockStyle.Fill;
            SwitchPanel.Location = new Point(4, 199);
            SwitchPanel.Name = "SwitchPanel";
            SwitchPanel.RowCount = 2;
            SwitchPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SwitchPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SwitchPanel.Size = new Size(132, 188);
            SwitchPanel.TabIndex = 5;
            // 
            // note
            // 
            note.Dock = DockStyle.Fill;
            note.Location = new Point(3, 3);
            note.Name = "note";
            note.Size = new Size(126, 88);
            note.TabIndex = 2;
            note.Text = "Poznámka";
            note.TextAlign = ContentAlignment.MiddleRight;
            note.UseVisualStyleBackColor = true;
            note.Checked = plan.Note;
            // 
            // done
            // 
            done.Dock = DockStyle.Fill;
            done.Location = new Point(3, 97);
            done.Name = "done";
            done.Size = new Size(126, 88);
            done.TabIndex = 3;
            done.Text = "Hotovo";
            done.TextAlign = ContentAlignment.MiddleRight;
            done.UseVisualStyleBackColor = true;
            done.Checked = plan.Done;

            return SwitchPanel;
        }

        private Label GenerateIndex()
        {
            Label index = new();
            index.Dock = DockStyle.Fill;
            index.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            index.Location = new Point(3, 0);
            index.Name = "poradi";
            index.Size = new Size(126, 94);
            index.TabIndex = 0;
            index.Text = "#" + plan.Poradi;
            index.TextAlign = ContentAlignment.MiddleCenter;
            return index;
        }

        private Button GenerateRecycleButton()
        {
            Button recycle = new();
            recycle.Dock = DockStyle.Fill;
            recycle.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recycle.ForeColor = Color.ForestGreen;
            recycle.Location = new Point(4, 394);
            recycle.Name = "recycle";
            recycle.Size = new Size(132, 190);
            recycle.TabIndex = 1;
            recycle.Text = "♻";
            recycle.UseVisualStyleBackColor = true;
            this.recycle = recycle;
            return recycle;
        }

    }
}