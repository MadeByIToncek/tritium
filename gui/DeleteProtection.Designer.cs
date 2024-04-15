namespace Tritium.gui
{
    partial class DeleteProtection
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
            label1 = new Label();
            fullname = new Label();
            dob = new Label();
            codeinput = new TextBox();
            label4 = new Label();
            code = new Label();
            commit = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(615, 134);
            label1.TabIndex = 0;
            label1.Text = "Opravdu chcete SMAZAT\r\nnásledujícího klienta?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fullname
            // 
            fullname.AutoSize = true;
            fullname.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            fullname.ForeColor = Color.Red;
            fullname.Location = new Point(12, 156);
            fullname.Name = "fullname";
            fullname.Size = new Size(236, 41);
            fullname.TabIndex = 1;
            fullname.Text = "Jméno Příjmení";
            // 
            // dob
            // 
            dob.AutoSize = true;
            dob.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            dob.ForeColor = Color.Red;
            dob.Location = new Point(12, 197);
            dob.Name = "dob";
            dob.Size = new Size(170, 41);
            dob.TabIndex = 2;
            dob.Text = "23.04.2006";
            // 
            // codeinput
            // 
            codeinput.Font = new Font("Segoe UI", 15F);
            codeinput.Location = new Point(12, 277);
            codeinput.Name = "codeinput";
            codeinput.Size = new Size(444, 47);
            codeinput.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.Location = new Point(12, 238);
            label4.Name = "label4";
            label4.Size = new Size(444, 36);
            label4.TabIndex = 4;
            label4.Text = "Opište následující text do pole níže:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // code
            // 
            code.AutoSize = true;
            code.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            code.Location = new Point(461, 224);
            code.Name = "code";
            code.Size = new Size(166, 54);
            code.TabIndex = 5;
            code.Text = "treAt31";
            code.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // commit
            // 
            commit.Font = new Font("Segoe UI", 15F);
            commit.ForeColor = Color.ForestGreen;
            commit.Location = new Point(569, 277);
            commit.Name = "commit";
            commit.Size = new Size(58, 47);
            commit.TabIndex = 6;
            commit.Text = "♻";
            commit.UseVisualStyleBackColor = true;
            commit.Click += Commit_Click;
            // 
            // cancel
            // 
            cancel.Font = new Font("Segoe UI", 15F);
            cancel.ForeColor = Color.Red;
            cancel.Location = new Point(462, 277);
            cancel.Name = "cancel";
            cancel.Size = new Size(101, 47);
            cancel.TabIndex = 7;
            cancel.Text = "❌";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += Cancel_Click;
            // 
            // DeleteProtection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 338);
            Controls.Add(cancel);
            Controls.Add(commit);
            Controls.Add(code);
            Controls.Add(label4);
            Controls.Add(codeinput);
            Controls.Add(dob);
            Controls.Add(fullname);
            Controls.Add(label1);
            Name = "DeleteProtection";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DeleteProtection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label fullname;
        private Label dob;
        private TextBox codeinput;
        private Label label4;
        private Label code;
        private Button commit;
        private Button cancel;
    }
}