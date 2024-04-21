using System.ComponentModel;
using System.Windows.Forms;

namespace Tritium.gui
{
    partial class MeetingInterface
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
            dateTimePicker1 = new DateTimePicker();
            aktualniPotize = new TextBox();
            groupBox1 = new GroupBox();
            skeny = new DataGridView();
            ScanMinus = new Button();
            ScanPlus = new Button();
            okruh1 = new ComboBox();
            okruh2 = new ComboBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            nejviceObtezuje = new TextBox();
            groupBox5 = new GroupBox();
            coVyresit = new TextBox();
            groupBox6 = new GroupBox();
            DesignerButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel3 = new Panel();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)skeny).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(6, 38);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(343, 50);
            dateTimePicker1.TabIndex = 0;
            // 
            // aktualniPotize
            // 
            aktualniPotize.Dock = DockStyle.Fill;
            aktualniPotize.Location = new Point(3, 35);
            aktualniPotize.Multiline = true;
            aktualniPotize.Name = "aktualniPotize";
            aktualniPotize.ScrollBars = ScrollBars.Vertical;
            aktualniPotize.Size = new Size(678, 225);
            aktualniPotize.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1032, 984);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Skeny";
            // 
            // skeny
            // 
            skeny.AllowUserToAddRows = false;
            skeny.AllowUserToDeleteRows = false;
            skeny.BackgroundColor = SystemColors.Control;
            skeny.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            skeny.Dock = DockStyle.Fill;
            skeny.GridColor = SystemColors.Control;
            skeny.Location = new Point(3, 3);
            skeny.Name = "skeny";
            skeny.ReadOnly = true;
            skeny.RowHeadersWidth = 62;
            skeny.Size = new Size(1020, 868);
            skeny.TabIndex = 9;
            skeny.CellDoubleClick += Skeny_CellDoubleClick;
            // 
            // ScanMinus
            // 
            ScanMinus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ScanMinus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScanMinus.Location = new Point(891, 3);
            ScanMinus.Name = "ScanMinus";
            ScanMinus.Size = new Size(60, 60);
            ScanMinus.TabIndex = 7;
            ScanMinus.Text = "➖";
            ScanMinus.UseVisualStyleBackColor = true;
            ScanMinus.Click += ScanMinus_Click;
            // 
            // ScanPlus
            // 
            ScanPlus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ScanPlus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScanPlus.Location = new Point(957, 3);
            ScanPlus.Name = "ScanPlus";
            ScanPlus.Size = new Size(60, 60);
            ScanPlus.TabIndex = 8;
            ScanPlus.Text = "➕";
            ScanPlus.UseVisualStyleBackColor = true;
            ScanPlus.Click += ScanPlus_Click;
            // 
            // okruh1
            // 
            okruh1.FormattingEnabled = true;
            okruh1.Location = new Point(6, 38);
            okruh1.Name = "okruh1";
            okruh1.Size = new Size(213, 40);
            okruh1.TabIndex = 4;
            // 
            // okruh2
            // 
            okruh2.FormattingEnabled = true;
            okruh2.Location = new Point(6, 84);
            okruh2.Name = "okruh2";
            okruh2.Size = new Size(213, 40);
            okruh2.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(358, 105);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datum";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(aktualniPotize);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(3, 255);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(684, 263);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Aktuální potíže";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(nejviceObtezuje);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(3, 524);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(684, 263);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Co nejvíce obtěžuje";
            // 
            // nejviceObtezuje
            // 
            nejviceObtezuje.Dock = DockStyle.Fill;
            nejviceObtezuje.Location = new Point(3, 35);
            nejviceObtezuje.Multiline = true;
            nejviceObtezuje.Name = "nejviceObtezuje";
            nejviceObtezuje.ScrollBars = ScrollBars.Vertical;
            nejviceObtezuje.Size = new Size(678, 225);
            nejviceObtezuje.TabIndex = 2;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(coVyresit);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(3, 793);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(684, 264);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Co chci vyřešit";
            // 
            // coVyresit
            // 
            coVyresit.Dock = DockStyle.Fill;
            coVyresit.Location = new Point(3, 35);
            coVyresit.Multiline = true;
            coVyresit.Name = "coVyresit";
            coVyresit.ScrollBars = ScrollBars.Vertical;
            coVyresit.Size = new Size(678, 226);
            coVyresit.TabIndex = 3;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(okruh1);
            groupBox6.Controls.Add(okruh2);
            groupBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox6.Location = new Point(3, 114);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(229, 135);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "Okruhy";
            // 
            // DesignerButton
            // 
            DesignerButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DesignerButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DesignerButton.Location = new Point(785, 3);
            DesignerButton.Name = "DesignerButton";
            DesignerButton.Size = new Size(250, 64);
            DesignerButton.TabIndex = 9;
            DesignerButton.Text = "Designer 📝";
            DesignerButton.UseVisualStyleBackColor = true;
            DesignerButton.Click += DesignerButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1740, 1066);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(699, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 1060);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(DesignerButton, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1038, 1060);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 1060);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox5, 0, 4);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox6, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox4, 0, 3);
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3355522F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.332222F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.332222F));
            tableLayoutPanel2.Size = new Size(690, 1060);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(skeny, 0, 0);
            tableLayoutPanel4.Controls.Add(panel3, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 35);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel4.Size = new Size(1026, 946);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(ScanMinus);
            panel3.Controls.Add(ScanPlus);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 877);
            panel3.Name = "panel3";
            panel3.Size = new Size(1020, 66);
            panel3.TabIndex = 10;
            // 
            // MeetingInterface
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1740, 1066);
            Controls.Add(tableLayoutPanel1);
            Name = "MeetingInterface";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MeetingInterface";
            groupBox1.ResumeLayout(false);
            ((ISupportInitialize)skeny).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private TextBox aktualniPotize;
        private GroupBox groupBox1;
        private ComboBox okruh1;
        private ComboBox okruh2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox nejviceObtezuje;
        private GroupBox groupBox5;
        private TextBox coVyresit;
        private GroupBox groupBox6;
        private Button ScanPlus;
        private Button ScanMinus;
        private Button DesignerButton;
        private DataGridView skeny;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel3;
    }
}