using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tritium.Entities;

namespace Tritium.gui
{
    internal class RowDesigner
    {
        private PlanEntry? entry;
        private readonly Plan plan;
        private readonly int order;
        private readonly Form rootWindow;
        private Button? reset;
        private Button? edit;

        public RowDesigner(PlanEntry? entry, Plan plan, int order, Form rootWindow)
        {
            this.entry = entry;
            this.plan = plan;
            this.order = order;
            this.rootWindow = rootWindow;
        }

        public TableLayoutPanel GenerateLayout()
        {
            entry ??= Program.db.GetPlanEntry(Program.db.CreateNewEmptyPlanEntry(plan, order));

            TableLayoutPanel row = new();
            reset = new();
            edit = new();
            Label time = new();
            Label type = new();
            Label program = new();
            // 
            // row
            // 
            row.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            row.ColumnCount = 6;
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            row.Controls.Add(reset, 4, 0);
            row.Controls.Add(edit, 3, 0);
            row.Controls.Add(time, 2, 0);
            row.Controls.Add(type, 1, 0);
            row.Controls.Add(program, 0, 0);
            row.Dock = DockStyle.Fill;
            row.Location = new Point(3, 3);
            row.Name = "row";
            row.RowCount = 1;
            row.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            row.Size = new Size(1174, 52);
            row.TabIndex = 0;
            // 
            // reset
            // 
            reset.Dock = DockStyle.Fill;
            reset.Font = new Font("Microsoft Sans Serif", 12);
            reset.ForeColor = Color.Green;
            reset.Location = new Point(1118, 4);
            reset.Name = "reset";
            reset.Size = new Size(54, 44);
            reset.TabIndex = 6;
            reset.Text = "♻";
            reset.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            edit.Dock = DockStyle.Fill;
            edit.Font = new Font("Microsoft Sans Serif", 12);
            edit.Location = new Point(1057, 4);
            edit.Name = "edit";
            edit.Size = new Size(54, 44);
            edit.TabIndex = 5;
            edit.Text = "📝";
            edit.UseVisualStyleBackColor = true;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Dock = DockStyle.Fill;
            time.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            time.Location = new Point(656, 1);
            time.Name = "time";
            time.Size = new Size(394, 50);
            time.TabIndex = 2;
            time.Text = "";
            time.TextAlign = ContentAlignment.MiddleLeft;

            if(entry != null)
            {
                time.Text = ParseTime(entry.Program.Time);
            }

            // 
            // type
            // 
            type.AutoSize = true;
            type.Dock = DockStyle.Fill;
            type.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            type.Location = new Point(505, 1);
            type.Name = "typ";
            type.Size = new Size(144, 50);
            type.TabIndex = 1;
            type.Text = "";
            type.TextAlign = ContentAlignment.MiddleLeft;


            if (entry != null)
            {
                type.Text = entry.Program.Type;
            }

            // 
            // program
            // 
            program.AutoSize = true;
            program.Dock = DockStyle.Fill;
            program.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            program.Location = new Point(4, 1);
            program.Name = "program";
            program.Size = new Size(494, 50);
            program.TabIndex = 0;
            program.Text = "";
            program.TextAlign = ContentAlignment.MiddleLeft;

            if (entry != null)
            {
                program.Text = entry.Program.Name;
            }



            reset.Click += (sender, args) =>
            {
                Program.db.ClearPlanEntry(entry);
            };

            edit.Click += (sender, args) =>
            {
                ManagerWindow.SwitchToWindow(new DesignerEditorInterface(entry.Plan.Navsteva.Id, entry.Id), rootWindow);
            };

            return row;
        }
        private static string ParseTime(long time)
        {
            TimeSpan t = TimeSpan.FromSeconds(time);

            return string.Format("{0:D2}:{1:D2}:{2:D2}",
                            t.Hours,
                            t.Minutes,
                            t.Seconds);
        }
    }
}
