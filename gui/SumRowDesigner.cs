using Tritium.Entities;

namespace Tritium.gui {
	internal class SumRowDesigner {
		private readonly Plan plan;
		private readonly Action<Form> SaveAndClose;
		private Button? reset;
		private Button? edit;

		public SumRowDesigner(Plan plan, Action<Form> SaveAndClose) {
			this.plan = plan;
			this.SaveAndClose = SaveAndClose;
		}

		public TableLayoutPanel GenerateLayout() {
			TableLayoutPanel row = new();
			Label time = new();
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
			row.Controls.Add(time, 2, 0);
			row.Dock = DockStyle.Fill;
			row.Location = new Point(3, 3);
			row.Name = "row";
			row.RowCount = 1;
			row.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			row.Size = new Size(1174, 52);
			row.TabIndex = 0;
			// 
			// time
			// 
			time.AutoSize = true;
			time.Dock = DockStyle.Fill;
			time.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
			time.Location = new Point(656, 1);
			time.Name = "time";
			time.Size = new Size(394, 50);
			time.TabIndex = 2;
			time.Text = "";
			time.TextAlign = ContentAlignment.MiddleLeft;

			time.Text = SumTime();

			return row;
		}

		private string SumTime() {
			long sum = 0;
            foreach (var item in plan.Programy)
            {
				sum += item.Program.Time;
            }
			return ParseTime(sum);
        }

		private static string ParseTime(long time) {
			TimeSpan t = TimeSpan.FromSeconds(time);

			return string.Format("{0:D2}:{1:D2}:{2:D2}",
							t.Hours,
							t.Minutes,
							t.Seconds);
		}

	}
}