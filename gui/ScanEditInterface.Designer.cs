using System.ComponentModel;

namespace Tritium.gui
{
    partial class ScanEditInterface
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
            groupBox1 = new GroupBox();
            Okruh = new ComboBox();
            PatogenList = new ListBox();
            SearchBox = new TextBox();
            groupBox2 = new GroupBox();
            FRQ = new TextBox();
            groupBox3 = new GroupBox();
            HRV = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Okruh);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 85);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Okruh";
            // 
            // Okruh
            // 
            Okruh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Okruh.FormattingEnabled = true;
            Okruh.Location = new Point(6, 38);
            Okruh.Name = "Okruh";
            Okruh.Size = new Size(338, 40);
            Okruh.TabIndex = 0;
            // 
            // PatogenList
            // 
            PatogenList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatogenList.FormattingEnabled = true;
            PatogenList.IntegralHeight = false;
            PatogenList.ItemHeight = 32;
            PatogenList.Location = new Point(368, 75);
            PatogenList.Name = "PatogenList";
            PatogenList.Size = new Size(420, 204);
            PatogenList.TabIndex = 1;
            // 
            // SearchBox
            // 
            SearchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBox.Location = new Point(368, 30);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(420, 39);
            SearchBox.TabIndex = 2;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(FRQ);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 85);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "FRQ";
            // 
            // FRQ
            // 
            FRQ.Location = new Point(6, 38);
            FRQ.Name = "FRQ";
            FRQ.Size = new Size(338, 39);
            FRQ.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(HRV);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 194);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(350, 85);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "HRV";
            // 
            // HRV
            // 
            HRV.Location = new Point(6, 38);
            HRV.Name = "HRV";
            HRV.Size = new Size(338, 39);
            HRV.TabIndex = 0;
            // 
            // ScanEditInterface
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 288);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(SearchBox);
            Controls.Add(PatogenList);
            Controls.Add(groupBox1);
            Name = "ScanEditInterface";
            Text = "ScanEditInterface";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox Okruh;
        private ListBox PatogenList;
        private TextBox SearchBox;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox FRQ;
        private TextBox HRV;
    }
}