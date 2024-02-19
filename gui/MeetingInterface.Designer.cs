using System.ComponentModel;

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

        bool closed = false;
        protected override void OnClosing(CancelEventArgs e)
        {
            if (!closed)
            {
                closed = true;
                ManagerWindow.SwitchToWindow(new ClientDBInterface(meeting.Client), this);
                base.OnClosing(e);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            okruh1 = new ComboBox();
            okruh2 = new ComboBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            textBox2 = new TextBox();
            groupBox5 = new GroupBox();
            textBox3 = new TextBox();
            groupBox6 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(6, 44);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(343, 50);
            dateTimePicker1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(492, 215);
            textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(527, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 1199);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // okruh1
            // 
            okruh1.FormattingEnabled = true;
            okruh1.Location = new Point(6, 38);
            okruh1.Name = "okruh1";
            okruh1.Size = new Size(213, 40);
            okruh1.TabIndex = 6;
            // 
            // okruh2
            // 
            okruh2.FormattingEnabled = true;
            okruh2.Location = new Point(6, 84);
            okruh2.Name = "okruh2";
            okruh2.Size = new Size(213, 40);
            okruh2.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(358, 105);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datum";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 123);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(509, 265);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Aktuální potíže";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox2);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(12, 394);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(509, 265);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Co nejvíce obtěžuje";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 38);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(492, 215);
            textBox2.TabIndex = 2;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox3);
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(12, 665);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(509, 265);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Co chci vyřešit";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 38);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(492, 215);
            textBox3.TabIndex = 2;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(okruh1);
            groupBox6.Controls.Add(okruh2);
            groupBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox6.Location = new Point(12, 936);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(229, 135);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "Okruhy";
            // 
            // MeetingInterface
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 1226);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MeetingInterface";
            Text = "MeetingInterface";
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private ComboBox okruh1;
        private ComboBox okruh2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox textBox2;
        private GroupBox groupBox5;
        private TextBox textBox3;
        private GroupBox groupBox6;
    }
}