using System.ComponentModel;

namespace Tritium
{
    partial class DatabaseManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseManager));
            indicator = new Label();
            newDBButton = new Button();
            openDBButton = new Button();
            disconnectDBButton = new Button();
            exportDBButton = new Button();
            returnButton = new Button();
            SuspendLayout();
            // 
            // indicator
            // 
            indicator.AutoSize = true;
            indicator.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            indicator.Location = new Point(12, 9);
            indicator.Name = "indicator";
            indicator.Size = new Size(61, 54);
            indicator.TabIndex = 0;
            indicator.Text = "❔";
            // 
            // newDBButton
            // 
            newDBButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            newDBButton.Location = new Point(79, 9);
            newDBButton.Name = "newDBButton";
            newDBButton.Size = new Size(63, 54);
            newDBButton.TabIndex = 1;
            newDBButton.Text = "➕";
            newDBButton.UseVisualStyleBackColor = true;
            // 
            // openDBButton
            // 
            openDBButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            openDBButton.Location = new Point(148, 9);
            openDBButton.Name = "openDBButton";
            openDBButton.Size = new Size(63, 54);
            openDBButton.TabIndex = 2;
            openDBButton.Text = "📂";
            openDBButton.UseVisualStyleBackColor = true;
            // 
            // disconnectDBButton
            // 
            disconnectDBButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            disconnectDBButton.Location = new Point(217, 9);
            disconnectDBButton.Name = "disconnectDBButton";
            disconnectDBButton.Size = new Size(63, 54);
            disconnectDBButton.TabIndex = 3;
            disconnectDBButton.Text = "\U0001f6d1";
            disconnectDBButton.UseVisualStyleBackColor = true;
            // 
            // exportDBButton
            // 
            exportDBButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            exportDBButton.Location = new Point(286, 9);
            exportDBButton.Name = "exportDBButton";
            exportDBButton.Size = new Size(63, 54);
            exportDBButton.TabIndex = 4;
            exportDBButton.Text = "☁";
            exportDBButton.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            returnButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            returnButton.Location = new Point(355, 9);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(63, 54);
            returnButton.TabIndex = 5;
            returnButton.Text = "🆗";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += ReturnButton_Click;
            // 
            // DatabaseManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 70);
            Controls.Add(returnButton);
            Controls.Add(exportDBButton);
            Controls.Add(disconnectDBButton);
            Controls.Add(openDBButton);
            Controls.Add(newDBButton);
            Controls.Add(indicator);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DatabaseManager";
            Text = "Database Manager - Tritium";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
        bool closed = false;
        protected override void OnClosing(CancelEventArgs e)
        {
            if (!closed)
            {
                closed = true;
                ManagerWindow.SwitchToWindow(new LoginManager(), this);
                base.OnClosing(e);
            }
        }

        private Label indicator;
        private Button newDBButton;
        private Button openDBButton;
        private Button disconnectDBButton;
        private Button exportDBButton;
        private Button returnButton;
    }
}