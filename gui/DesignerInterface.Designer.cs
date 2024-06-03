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
            panel2 = new Panel();
            MeetingNumberAndDate = new Label();
            Date = new Label();
            username = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            CreateNewPlan = new Button();
            PrintEveryting = new Button();
            panel1 = new Panel();
            masterGrid = new TableLayoutPanel();
            subLayout = new TableLayoutPanel();
            subLayoutAController = new TableLayoutPanel();
            recycle = new Button();
            indexController = new TableLayoutPanel();
            poradi = new Label();
            indexPlusMinus = new TableLayoutPanel();
            plus = new Button();
            minus = new Button();
            SwitchPanel = new TableLayoutPanel();
            note = new CheckBox();
            done = new CheckBox();
            subLayoutBController = new TableLayoutPanel();
            row = new TableLayoutPanel();
            reset = new Button();
            edit = new Button();
            time = new Label();
            typ = new Label();
            program = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            button1 = new Button();
            tableLayoutPanel10 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel11 = new TableLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            tableLayoutPanel12 = new TableLayoutPanel();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            tableLayoutPanel14 = new TableLayoutPanel();
            tableLayoutPanel13 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)skeny).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            subLayout.SuspendLayout();
            subLayoutAController.SuspendLayout();
            indexController.SuspendLayout();
            indexPlusMinus.SuspendLayout();
            SwitchPanel.SuspendLayout();
            subLayoutBController.SuspendLayout();
            row.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(1975, 1155);
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
            groupBox1.Size = new Size(572, 1135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(skeny, 0, 2);
            tableLayoutPanel4.Controls.Add(panel2, 0, 0);
            tableLayoutPanel4.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel4.Location = new Point(13, 38);
            tableLayoutPanel4.Margin = new Padding(10);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.603687F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 92.39632F));
            tableLayoutPanel4.Size = new Size(551, 1084);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // skeny
            // 
            skeny.AllowUserToAddRows = false;
            skeny.AllowUserToDeleteRows = false;
            skeny.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            skeny.Dock = DockStyle.Fill;
            skeny.Location = new Point(3, 224);
            skeny.Name = "skeny";
            skeny.ReadOnly = true;
            skeny.RowHeadersWidth = 62;
            skeny.Size = new Size(545, 857);
            skeny.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(MeetingNumberAndDate);
            panel2.Controls.Add(Date);
            panel2.Controls.Add(username);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(545, 144);
            panel2.TabIndex = 1;
            // 
            // MeetingNumberAndDate
            // 
            MeetingNumberAndDate.AutoSize = true;
            MeetingNumberAndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MeetingNumberAndDate.Location = new Point(17, 88);
            MeetingNumberAndDate.Name = "MeetingNumberAndDate";
            MeetingNumberAndDate.Size = new Size(223, 32);
            MeetingNumberAndDate.TabIndex = 2;
            MeetingNumberAndDate.Text = "Návštěva: Loading...";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Date.Location = new Point(17, 56);
            Date.Name = "Date";
            Date.Size = new Size(114, 32);
            Date.TabIndex = 1;
            Date.Text = "Loading...";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.Location = new Point(12, 12);
            username.Name = "username";
            username.Size = new Size(168, 45);
            username.TabIndex = 0;
            username.Text = "Loading...";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(CreateNewPlan);
            flowLayoutPanel1.Controls.Add(PrintEveryting);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 153);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(545, 65);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // CreateNewPlan
            // 
            CreateNewPlan.Location = new Point(482, 3);
            CreateNewPlan.Name = "CreateNewPlan";
            CreateNewPlan.Size = new Size(60, 52);
            CreateNewPlan.TabIndex = 0;
            CreateNewPlan.Text = "➕";
            CreateNewPlan.UseVisualStyleBackColor = true;
            CreateNewPlan.Click += CreateNewPlan_Click;
            // 
            // PrintEveryting
            // 
            PrintEveryting.Location = new Point(416, 3);
            PrintEveryting.Name = "PrintEveryting";
            PrintEveryting.Size = new Size(60, 52);
            PrintEveryting.TabIndex = 2;
            PrintEveryting.Text = "🖨";
            PrintEveryting.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(masterGrid);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(595, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1377, 1149);
            panel1.TabIndex = 1;
            // 
            // masterGrid
            // 
            masterGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            masterGrid.AutoSize = true;
            masterGrid.ColumnCount = 1;
            masterGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            masterGrid.Location = new Point(3, 3);
            masterGrid.Name = "masterGrid";
            masterGrid.RowCount = 2;
            masterGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 500F));
            masterGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            masterGrid.Size = new Size(1371, 1142);
            masterGrid.TabIndex = 0;
            // 
            // subLayout
            // 
            subLayout.ColumnCount = 2;
            subLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11F));
            subLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89F));
            subLayout.Controls.Add(subLayoutAController, 0, 0);
            subLayout.Controls.Add(subLayoutBController, 1, 0);
            subLayout.Dock = DockStyle.Fill;
            subLayout.Location = new Point(3, 3);
            subLayout.Name = "subLayout";
            subLayout.RowCount = 1;
            subLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            subLayout.Size = new Size(1366, 507);
            subLayout.TabIndex = 0;
            // 
            // subLayoutAController
            // 
            subLayoutAController.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            subLayoutAController.ColumnCount = 1;
            subLayoutAController.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            subLayoutAController.Controls.Add(recycle, 0, 2);
            subLayoutAController.Controls.Add(indexController, 0, 0);
            subLayoutAController.Controls.Add(SwitchPanel, 0, 1);
            subLayoutAController.Dock = DockStyle.Fill;
            subLayoutAController.Location = new Point(3, 3);
            subLayoutAController.Name = "subLayoutAController";
            subLayoutAController.RowCount = 3;
            subLayoutAController.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            subLayoutAController.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            subLayoutAController.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            subLayoutAController.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            subLayoutAController.Size = new Size(144, 501);
            subLayoutAController.TabIndex = 0;
            // 
            // recycle
            // 
            recycle.Dock = DockStyle.Fill;
            recycle.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recycle.ForeColor = Color.ForestGreen;
            recycle.Location = new Point(4, 336);
            recycle.Name = "recycle";
            recycle.Size = new Size(136, 161);
            recycle.TabIndex = 1;
            recycle.Text = "♻";
            recycle.UseVisualStyleBackColor = true;
            // 
            // indexController
            // 
            indexController.ColumnCount = 1;
            indexController.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            indexController.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            indexController.Controls.Add(poradi, 0, 0);
            indexController.Controls.Add(indexPlusMinus, 0, 1);
            indexController.Dock = DockStyle.Fill;
            indexController.Location = new Point(4, 4);
            indexController.Name = "indexController";
            indexController.RowCount = 2;
            indexController.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            indexController.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            indexController.Size = new Size(136, 159);
            indexController.TabIndex = 4;
            // 
            // poradi
            // 
            poradi.Dock = DockStyle.Fill;
            poradi.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poradi.Location = new Point(3, 0);
            poradi.Name = "poradi";
            poradi.Size = new Size(130, 79);
            poradi.TabIndex = 0;
            poradi.Text = "#10";
            poradi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // indexPlusMinus
            // 
            indexPlusMinus.ColumnCount = 2;
            indexPlusMinus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            indexPlusMinus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            indexPlusMinus.Controls.Add(plus, 1, 0);
            indexPlusMinus.Controls.Add(minus, 0, 0);
            indexPlusMinus.Dock = DockStyle.Fill;
            indexPlusMinus.Location = new Point(3, 82);
            indexPlusMinus.Name = "indexPlusMinus";
            indexPlusMinus.RowCount = 1;
            indexPlusMinus.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            indexPlusMinus.Size = new Size(130, 74);
            indexPlusMinus.TabIndex = 1;
            // 
            // plus
            // 
            plus.Dock = DockStyle.Fill;
            plus.Location = new Point(68, 3);
            plus.Name = "plus";
            plus.Size = new Size(59, 68);
            plus.TabIndex = 1;
            plus.Text = "➕";
            plus.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            minus.Dock = DockStyle.Fill;
            minus.Location = new Point(3, 3);
            minus.Name = "minus";
            minus.Size = new Size(59, 68);
            minus.TabIndex = 0;
            minus.Text = "➖";
            minus.UseVisualStyleBackColor = true;
            // 
            // SwitchPanel
            // 
            SwitchPanel.ColumnCount = 1;
            SwitchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            SwitchPanel.Controls.Add(note, 0, 0);
            SwitchPanel.Controls.Add(done, 0, 1);
            SwitchPanel.Dock = DockStyle.Fill;
            SwitchPanel.Location = new Point(4, 170);
            SwitchPanel.Name = "SwitchPanel";
            SwitchPanel.RowCount = 2;
            SwitchPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SwitchPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SwitchPanel.Size = new Size(136, 159);
            SwitchPanel.TabIndex = 5;
            // 
            // note
            // 
            note.Dock = DockStyle.Fill;
            note.Location = new Point(3, 3);
            note.Name = "note";
            note.Size = new Size(130, 73);
            note.TabIndex = 2;
            note.Text = "Poznámka";
            note.TextAlign = ContentAlignment.MiddleRight;
            note.UseVisualStyleBackColor = true;
            note.CheckedChanged += SaveAndRefreshLayout;
            // 
            // done
            // 
            done.Dock = DockStyle.Fill;
            done.Location = new Point(3, 82);
            done.Name = "done";
            done.Size = new Size(130, 74);
            done.TabIndex = 3;
            done.Text = "Hotovo";
            done.TextAlign = ContentAlignment.MiddleRight;
            done.UseVisualStyleBackColor = true;
            done.CheckedChanged += SaveAndRefreshLayout;
            // 
            // subLayoutBController
            // 
            subLayoutBController.ColumnCount = 1;
            subLayoutBController.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            subLayoutBController.Controls.Add(row, 0, 0);
            subLayoutBController.Dock = DockStyle.Fill;
            subLayoutBController.Location = new Point(153, 3);
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
            subLayoutBController.Size = new Size(1210, 501);
            subLayoutBController.TabIndex = 1;
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
            row.Controls.Add(typ, 1, 0);
            row.Controls.Add(program, 0, 0);
            row.Dock = DockStyle.Fill;
            row.Location = new Point(3, 3);
            row.Name = "row";
            row.RowCount = 1;
            row.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            row.Size = new Size(1204, 44);
            row.TabIndex = 0;
            // 
            // reset
            // 
            reset.Dock = DockStyle.Fill;
            reset.Font = new Font("Microsoft Sans Serif", 12F);
            reset.ForeColor = Color.Green;
            reset.Location = new Point(1118, 4);
            reset.Name = "reset";
            reset.Size = new Size(54, 36);
            reset.TabIndex = 6;
            reset.Text = "♻";
            reset.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            edit.Dock = DockStyle.Fill;
            edit.Font = new Font("Microsoft Sans Serif", 12F);
            edit.Location = new Point(1057, 4);
            edit.Name = "edit";
            edit.Size = new Size(54, 36);
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
            time.Size = new Size(394, 42);
            time.TabIndex = 2;
            time.Text = "Čas";
            time.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // typ
            // 
            typ.AutoSize = true;
            typ.Dock = DockStyle.Fill;
            typ.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typ.Location = new Point(505, 1);
            typ.Name = "typ";
            typ.Size = new Size(144, 42);
            typ.TabIndex = 1;
            typ.Text = "Typ";
            typ.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // program
            // 
            program.AutoSize = true;
            program.Dock = DockStyle.Fill;
            program.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            program.Location = new Point(4, 1);
            program.Name = "program";
            program.Size = new Size(494, 42);
            program.TabIndex = 0;
            program.Text = "Program";
            program.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel8.Controls.Add(tableLayoutPanel9, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.Size = new Size(200, 100);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(button1, 0, 3);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 0, 0);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel12, 0, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 4;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel9.Size = new Size(14, 588);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.ForestGreen;
            button1.Location = new Point(4, 442);
            button1.Name = "button1";
            button1.Size = new Size(6, 142);
            button1.TabIndex = 1;
            button1.Text = "♻";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Controls.Add(label1, 0, 0);
            tableLayoutPanel10.Controls.Add(tableLayoutPanel11, 0, 1);
            tableLayoutPanel10.Location = new Point(4, 4);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(6, 114);
            tableLayoutPanel10.TabIndex = 4;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1, 57);
            label1.TabIndex = 0;
            label1.Text = "#10";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(button2, 1, 0);
            tableLayoutPanel11.Controls.Add(button3, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 60);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(1, 51);
            tableLayoutPanel11.TabIndex = 1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(1, 45);
            button2.TabIndex = 1;
            button2.Text = "➕";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(1, 45);
            button3.TabIndex = 0;
            button3.Text = "➖";
            button3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Controls.Add(checkBox1, 0, 0);
            tableLayoutPanel12.Controls.Add(checkBox2, 0, 1);
            tableLayoutPanel12.Location = new Point(4, 150);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(6, 139);
            tableLayoutPanel12.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.Dock = DockStyle.Fill;
            checkBox1.Location = new Point(3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(1, 63);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Poznámka";
            checkBox1.TextAlign = ContentAlignment.MiddleRight;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.Dock = DockStyle.Fill;
            checkBox2.Location = new Point(3, 72);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(1, 64);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Hotovo";
            checkBox2.TextAlign = ContentAlignment.MiddleRight;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 5;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(3, 3);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Size = new Size(168, 52);
            tableLayoutPanel14.TabIndex = 0;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Controls.Add(tableLayoutPanel14, 0, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(23, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 10;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel13.Size = new Size(174, 588);
            tableLayoutPanel13.TabIndex = 1;
            // 
            // DesignerInterface
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2015, 1179);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1990, 1235);
            Name = "DesignerInterface";
            Text = "DesignerInterface";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)skeny).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            subLayout.ResumeLayout(false);
            subLayoutAController.ResumeLayout(false);
            indexController.ResumeLayout(false);
            indexPlusMinus.ResumeLayout(false);
            SwitchPanel.ResumeLayout(false);
            subLayoutBController.ResumeLayout(false);
            row.ResumeLayout(false);
            row.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
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
        private TableLayoutPanel indexController;
        private TableLayoutPanel indexPlusMinus;
        private Button plus;
        private Button minus;
        private TableLayoutPanel SwitchPanel;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel11;
        private Button button2;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel12;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TableLayoutPanel tableLayoutPanel14;
        private TableLayoutPanel tableLayoutPanel13;
        private TableLayoutPanel subLayoutBController;
        private TableLayoutPanel row;
        private Label typ;
        private Label program;
        private Label time;
        private Button reset;
        private Button edit;
        private Panel panel2;
        private Label username;
        private Label Date;
        private Label MeetingNumberAndDate;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button CreateNewPlan;
        private Button PrintEveryting;
    }
}