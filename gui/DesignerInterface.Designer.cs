namespace Tritium.gui
{
    partial class DesignerInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            skeny = new DataGridView();
            panel1 = new Panel();
            masterGrid = new TableLayoutPanel();
            subLayout = new TableLayoutPanel();
            subLayoutAController = new TableLayoutPanel();
            done = new CheckBox();
            recycle = new Button();
            note = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            poradi = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            plus = new Button();
            minus = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)skeny).BeginInit();
            panel1.SuspendLayout();
            masterGrid.SuspendLayout();
            subLayout.SuspendLayout();
            subLayoutAController.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(2200, 1156);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(tableLayoutPanel4);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Margin = new Padding(10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 1136);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(skeny, 0, 1);
            tableLayoutPanel4.Location = new Point(13, 38);
            tableLayoutPanel4.Margin = new Padding(10);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(619, 1085);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // skeny
            // 
            skeny.AllowUserToAddRows = false;
            skeny.AllowUserToDeleteRows = false;
            skeny.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            skeny.Dock = DockStyle.Fill;
            skeny.Location = new Point(3, 545);
            skeny.Name = "skeny";
            skeny.ReadOnly = true;
            skeny.RowHeadersWidth = 62;
            skeny.Size = new Size(613, 537);
            skeny.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(masterGrid);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(663, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1534, 1150);
            panel1.TabIndex = 1;
            // 
            // masterGrid
            // 
            masterGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            masterGrid.AutoSize = true;
            masterGrid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            masterGrid.ColumnCount = 1;
            masterGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            masterGrid.Controls.Add(subLayout, 0, 0);
            masterGrid.Location = new Point(3, 3);
            masterGrid.Name = "masterGrid";
            masterGrid.RowCount = 2;
            masterGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 500F));
            masterGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            masterGrid.Size = new Size(1528, 1142);
            masterGrid.TabIndex = 0;
            // 
            // subLayout
            // 
            subLayout.ColumnCount = 2;
            subLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            subLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            subLayout.Controls.Add(subLayoutAController, 0, 0);
            subLayout.Dock = DockStyle.Fill;
            subLayout.Location = new Point(4, 4);
            subLayout.Name = "subLayout";
            subLayout.RowCount = 1;
            subLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            subLayout.Size = new Size(1520, 494);
            subLayout.TabIndex = 0;
            // 
            // subLayoutAController
            // 
            subLayoutAController.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            subLayoutAController.ColumnCount = 1;
            subLayoutAController.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            subLayoutAController.Controls.Add(done, 0, 2);
            subLayoutAController.Controls.Add(recycle, 0, 3);
            subLayoutAController.Controls.Add(note, 0, 1);
            subLayoutAController.Controls.Add(tableLayoutPanel2, 0, 0);
            subLayoutAController.Dock = DockStyle.Fill;
            subLayoutAController.Location = new Point(3, 3);
            subLayoutAController.Name = "subLayoutAController";
            subLayoutAController.RowCount = 4;
            subLayoutAController.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            subLayoutAController.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            subLayoutAController.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            subLayoutAController.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            subLayoutAController.Size = new Size(146, 488);
            subLayoutAController.TabIndex = 0;
            // 
            // done
            // 
            done.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            done.CheckAlign = ContentAlignment.TopCenter;
            done.Location = new Point(4, 278);
            done.Margin = new Padding(3, 35, 3, 35);
            done.Name = "done";
            done.Size = new Size(138, 50);
            done.TabIndex = 3;
            done.Text = "Hotovo";
            done.TextAlign = ContentAlignment.MiddleCenter;
            done.UseVisualStyleBackColor = true;
            done.CheckedChanged += SaveAndRefreshLayout;
            // 
            // recycle
            // 
            recycle.Dock = DockStyle.Fill;
            recycle.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recycle.ForeColor = Color.ForestGreen;
            recycle.Location = new Point(4, 367);
            recycle.Name = "recycle";
            recycle.Size = new Size(138, 117);
            recycle.TabIndex = 1;
            recycle.Text = "♻";
            recycle.UseVisualStyleBackColor = true;
            // 
            // note
            // 
            note.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            note.CheckAlign = ContentAlignment.TopCenter;
            note.Location = new Point(4, 157);
            note.Margin = new Padding(3, 35, 3, 35);
            note.Name = "note";
            note.Size = new Size(138, 50);
            note.TabIndex = 2;
            note.Text = "Poznámka";
            note.TextAlign = ContentAlignment.MiddleCenter;
            note.UseVisualStyleBackColor = true;
            note.CheckedChanged += SaveAndRefreshLayout;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(poradi, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Location = new Point(4, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(138, 114);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // poradi
            // 
            poradi.Dock = DockStyle.Fill;
            poradi.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poradi.Location = new Point(3, 0);
            poradi.Name = "poradi";
            poradi.Size = new Size(132, 57);
            poradi.TabIndex = 0;
            poradi.Text = "#10";
            poradi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(plus, 1, 0);
            tableLayoutPanel3.Controls.Add(minus, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 60);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(132, 51);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // plus
            // 
            plus.Dock = DockStyle.Fill;
            plus.Location = new Point(69, 3);
            plus.Name = "plus";
            plus.Size = new Size(60, 45);
            plus.TabIndex = 1;
            plus.Text = "➕";
            plus.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            minus.Dock = DockStyle.Fill;
            minus.Location = new Point(3, 3);
            minus.Name = "minus";
            minus.Size = new Size(60, 45);
            minus.TabIndex = 0;
            minus.Text = "➖";
            minus.UseVisualStyleBackColor = true;
            // 
            // DesignerInterface
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2230, 1180);
            Controls.Add(tableLayoutPanel1);
            Name = "DesignerInterface";
            Text = "DesignerInterface";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)skeny).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            masterGrid.ResumeLayout(false);
            subLayout.ResumeLayout(false);
            subLayoutAController.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView skeny;
        private Panel panel1;
        private TableLayoutPanel masterGrid;
        private TableLayoutPanel subLayout;
        private TableLayoutPanel subLayoutAController;
        private Label poradi;
        private Button recycle;
        private CheckBox note;
        private CheckBox done;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button plus;
        private Button minus;
    }
}