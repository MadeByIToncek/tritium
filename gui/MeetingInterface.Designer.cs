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
            ScanMinus = new Button();
            listView1 = new ListView();
            id = new ColumnHeader();
            Okruh = new ColumnHeader();
            Patogen = new ColumnHeader();
            FRQ = new ColumnHeader();
            HRV = new ColumnHeader();
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
            groupBox7 = new GroupBox();
            button1 = new Button();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
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
            aktualniPotize.Location = new Point(6, 38);
            aktualniPotize.Multiline = true;
            aktualniPotize.Name = "aktualniPotize";
            aktualniPotize.ScrollBars = ScrollBars.Vertical;
            aktualniPotize.Size = new Size(492, 215);
            aktualniPotize.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ScanMinus);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(ScanPlus);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(527, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1011, 778);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Skeny";
            // 
            // ScanMinus
            // 
            ScanMinus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScanMinus.Location = new Point(879, 711);
            ScanMinus.Name = "ScanMinus";
            ScanMinus.Size = new Size(60, 60);
            ScanMinus.TabIndex = 7;
            ScanMinus.Text = "➖";
            ScanMinus.UseVisualStyleBackColor = true;
            ScanMinus.Click += ScanMinus_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id, Okruh, Patogen, FRQ, HRV });
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.ImeMode = ImeMode.Disable;
            listView1.Location = new Point(6, 38);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(999, 669);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += ListView1_DoubleClick;
            // 
            // id
            // 
            id.Text = "ID";
            id.Width = 50;
            // 
            // Okruh
            // 
            Okruh.Text = "Okruh";
            Okruh.Width = 200;
            // 
            // Patogen
            // 
            Patogen.Text = "Patogen";
            Patogen.Width = 280;
            // 
            // FRQ
            // 
            FRQ.Text = "FRQ";
            FRQ.Width = 150;
            // 
            // HRV
            // 
            HRV.Text = "HRV";
            HRV.Width = 150;
            // 
            // ScanPlus
            // 
            ScanPlus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScanPlus.Location = new Point(945, 712);
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
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(358, 105);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datum";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(aktualniPotize);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 123);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(509, 265);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Aktuální potíže";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(nejviceObtezuje);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(12, 394);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(509, 265);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Co nejvíce obtěžuje";
            // 
            // nejviceObtezuje
            // 
            nejviceObtezuje.Location = new Point(6, 38);
            nejviceObtezuje.Multiline = true;
            nejviceObtezuje.Name = "nejviceObtezuje";
            nejviceObtezuje.ScrollBars = ScrollBars.Vertical;
            nejviceObtezuje.Size = new Size(492, 215);
            nejviceObtezuje.TabIndex = 2;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(coVyresit);
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(12, 665);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(509, 265);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Co chci vyřešit";
            // 
            // coVyresit
            // 
            coVyresit.Location = new Point(6, 38);
            coVyresit.Multiline = true;
            coVyresit.Name = "coVyresit";
            coVyresit.ScrollBars = ScrollBars.Vertical;
            coVyresit.Size = new Size(492, 215);
            coVyresit.TabIndex = 3;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(okruh1);
            groupBox6.Controls.Add(okruh2);
            groupBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox6.Location = new Point(527, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(229, 135);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "Okruhy";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(button1);
            groupBox7.Controls.Add(listView2);
            groupBox7.Controls.Add(button2);
            groupBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox7.Location = new Point(1544, 12);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(631, 919);
            groupBox7.TabIndex = 9;
            groupBox7.TabStop = false;
            groupBox7.Text = "Plány";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(499, 852);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 7;
            button1.Text = "➖";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView2.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView2.ImeMode = ImeMode.Disable;
            listView2.Location = new Point(6, 38);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(619, 810);
            listView2.TabIndex = 6;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "#";
            columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Typ";
            columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Note";
            columnHeader4.Width = 350;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Hotovo";
            columnHeader5.Width = 100;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(565, 853);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 8;
            button2.Text = "➕";
            button2.UseVisualStyleBackColor = true;
            // 
            // MeetingInterface
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2187, 939);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MeetingInterface";
            Text = "MeetingInterface";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
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
        private ListView listView1;
        private ColumnHeader Okruh;
        private ColumnHeader Patogen;
        private ColumnHeader FRQ;
        private ColumnHeader HRV;
        private Button ScanMinus;
        private ColumnHeader id;
        private GroupBox groupBox7;
        private Button button1;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button2;
    }
}