using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.ComponentModel;

namespace Tritium
{
    partial class MicrobeDBInterface
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MicrobeDBInterface));
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            groupBox9 = new GroupBox();
            poznamky = new TextBox();
            groupBox8 = new GroupBox();
            okruhy = new TextBox();
            groupBox7 = new GroupBox();
            skPasma = new TextBox();
            groupBox6 = new GroupBox();
            morty = new TextBox();
            groupBox5 = new GroupBox();
            parovy = new CheckBox();
            onkovir = new CheckBox();
            samostatne = new CheckBox();
            groupBox4 = new GroupBox();
            cas = new TextBox();
            groupBox3 = new GroupBox();
            dlazdice = new TextBox();
            groupBox2 = new GroupBox();
            name = new TextBox();
            cancel = new Button();
            commit = new Button();
            real_name = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(763, 660);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox9);
            groupBox1.Controls.Add(groupBox8);
            groupBox1.Controls.Add(groupBox7);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cancel);
            groupBox1.Controls.Add(commit);
            groupBox1.Controls.Add(real_name);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(383, 2);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(377, 655);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Upravit program/mikrob";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(poznamky);
            groupBox9.Location = new Point(10, 465);
            groupBox9.Margin = new Padding(2);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(2);
            groupBox9.Size = new Size(353, 134);
            groupBox9.TabIndex = 11;
            groupBox9.TabStop = false;
            groupBox9.Text = "Poznámky";
            // 
            // poznamky
            // 
            poznamky.Location = new Point(5, 30);
            poznamky.Margin = new Padding(2);
            poznamky.Multiline = true;
            poznamky.Name = "poznamky";
            poznamky.ScrollBars = ScrollBars.Vertical;
            poznamky.Size = new Size(344, 97);
            poznamky.TabIndex = 13;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(okruhy);
            groupBox8.Location = new Point(189, 326);
            groupBox8.Margin = new Padding(2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(2);
            groupBox8.Size = new Size(174, 134);
            groupBox8.TabIndex = 10;
            groupBox8.TabStop = false;
            groupBox8.Text = "Okruh";
            // 
            // okruhy
            // 
            okruhy.Location = new Point(5, 30);
            okruhy.Margin = new Padding(2);
            okruhy.Multiline = true;
            okruhy.Name = "okruhy";
            okruhy.ScrollBars = ScrollBars.Vertical;
            okruhy.Size = new Size(166, 97);
            okruhy.TabIndex = 12;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(skPasma);
            groupBox7.Location = new Point(10, 326);
            groupBox7.Margin = new Padding(2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(2);
            groupBox7.Size = new Size(174, 134);
            groupBox7.TabIndex = 9;
            groupBox7.TabStop = false;
            groupBox7.Text = "SK a pásma";
            // 
            // skPasma
            // 
            skPasma.Location = new Point(5, 30);
            skPasma.Margin = new Padding(2);
            skPasma.Multiline = true;
            skPasma.Name = "skPasma";
            skPasma.ScrollBars = ScrollBars.Vertical;
            skPasma.Size = new Size(166, 97);
            skPasma.TabIndex = 11;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(morty);
            groupBox6.Location = new Point(188, 186);
            groupBox6.Margin = new Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(2);
            groupBox6.Size = new Size(174, 134);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "MORT FRQs";
            // 
            // morty
            // 
            morty.Location = new Point(5, 30);
            morty.Margin = new Padding(2);
            morty.Multiline = true;
            morty.Name = "morty";
            morty.ScrollBars = ScrollBars.Vertical;
            morty.Size = new Size(166, 97);
            morty.TabIndex = 10;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(parovy);
            groupBox5.Controls.Add(onkovir);
            groupBox5.Controls.Add(samostatne);
            groupBox5.Location = new Point(10, 186);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(174, 134);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Parametry";
            // 
            // parovy
            // 
            parovy.AutoSize = true;
            parovy.Location = new Point(5, 98);
            parovy.Margin = new Padding(2);
            parovy.Name = "parovy";
            parovy.Size = new Size(102, 32);
            parovy.TabIndex = 9;
            parovy.Text = "Párový?";
            parovy.UseVisualStyleBackColor = true;
            // 
            // onkovir
            // 
            onkovir.AutoSize = true;
            onkovir.Location = new Point(5, 64);
            onkovir.Margin = new Padding(2);
            onkovir.Name = "onkovir";
            onkovir.Size = new Size(113, 32);
            onkovir.TabIndex = 8;
            onkovir.Text = "Onkovir?";
            onkovir.UseVisualStyleBackColor = true;
            // 
            // samostatne
            // 
            samostatne.AutoSize = true;
            samostatne.Location = new Point(5, 30);
            samostatne.Margin = new Padding(2);
            samostatne.Name = "samostatne";
            samostatne.Size = new Size(146, 32);
            samostatne.TabIndex = 7;
            samostatne.Text = "Samostatně?";
            samostatne.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cas);
            groupBox4.Location = new Point(188, 114);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(174, 68);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Čas";
            // 
            // cas
            // 
            cas.Location = new Point(5, 30);
            cas.Margin = new Padding(2);
            cas.Name = "cas";
            cas.Size = new Size(166, 34);
            cas.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dlazdice);
            groupBox3.Location = new Point(10, 114);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(174, 68);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dlaždice";
            // 
            // dlazdice
            // 
            dlazdice.Location = new Point(5, 30);
            dlazdice.Margin = new Padding(2);
            dlazdice.Name = "dlazdice";
            dlazdice.Size = new Size(165, 34);
            dlazdice.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(name);
            groupBox2.Location = new Point(10, 30);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(353, 78);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Jméno";
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(5, 30);
            name.Margin = new Padding(2);
            name.Name = "name";
            name.Size = new Size(344, 43);
            name.TabIndex = 4;
            // 
            // cancel
            // 
            cancel.Location = new Point(158, 614);
            cancel.Margin = new Padding(2);
            cancel.Name = "cancel";
            cancel.Size = new Size(105, 37);
            cancel.TabIndex = 14;
            cancel.Text = "❌Zrušit";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += Cancel_Click;
            // 
            // commit
            // 
            commit.Location = new Point(267, 614);
            commit.Margin = new Padding(2);
            commit.Name = "commit";
            commit.Size = new Size(105, 37);
            commit.TabIndex = 15;
            commit.Text = "✔OK";
            commit.UseVisualStyleBackColor = true;
            commit.Click += Commit_Click;
            // 
            // real_name
            // 
            real_name.AutoSize = true;
            real_name.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            real_name.Location = new Point(5, 22);
            real_name.Margin = new Padding(2, 0, 2, 0);
            real_name.Name = "real_name";
            real_name.Size = new Size(0, 50);
            real_name.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 655);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.Location = new Point(280, 607);
            button2.Name = "button2";
            button2.Size = new Size(44, 44);
            button2.TabIndex = 2;
            button2.Text = "➖";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(330, 607);
            button1.Name = "button1";
            button1.Size = new Size(44, 44);
            button1.TabIndex = 3;
            button1.Text = "➕";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(2, 38);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(374, 564);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(2, 2);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(373, 34);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += TextBox2_TextChanged;
            // 
            // MicrobeDBManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 679);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MicrobeDBManager";
            Text = "Mikroby - Tritium";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        bool closed = false;
        protected override void OnClosing(CancelEventArgs e)
        {
            if (!closed)
            {
                closed = true;
                ManagerWindow.SwitchToWindow(new LoginInterface(), this);
                base.OnClosing(e);
            }
        }

        private TableLayoutPanel tableLayoutPanel1;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private Label real_name;
        private Button commit;
        private Button cancel;
        private TextBox name;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox dlazdice;
        private Panel panel1;
        private TextBox textBox2;
        private GroupBox groupBox4;
        private TextBox cas;
        private GroupBox groupBox5;
        private CheckBox parovy;
        private CheckBox onkovir;
        private CheckBox samostatne;
        private GroupBox groupBox6;
        private TextBox morty;
        private GroupBox groupBox8;
        private TextBox okruhy;
        private GroupBox groupBox7;
        private TextBox skPasma;
        private GroupBox groupBox9;
        private TextBox poznamky;
        private Button button1;
        private Button button2;
    }
}