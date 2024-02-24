namespace Tritium
{
    partial class SplashInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashInterface));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ver = new Label();
            logDisplay = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stolzl Bold", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 35);
            label1.Name = "label1";
            label1.Size = new Size(301, 86);
            label1.TabIndex = 0;
            label1.Text = "Tritium";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(369, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 266);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ver
            // 
            ver.AutoSize = true;
            ver.Font = new Font("Stolzl", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ver.Location = new Point(35, 110);
            ver.Name = "ver";
            ver.Size = new Size(120, 22);
            ver.TabIndex = 2;
            ver.Text = "Version: null";
            // 
            // logDisplay
            // 
            logDisplay.AutoSize = true;
            logDisplay.Location = new Point(35, 210);
            logDisplay.Name = "logDisplay";
            logDisplay.Size = new Size(206, 25);
            logDisplay.TabIndex = 3;
            logDisplay.Text = "[SYSTEM] Splash created";
            // 
            // SplashInterface
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 290);
            Controls.Add(logDisplay);
            Controls.Add(ver);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashInterface";
            ShowInTaskbar = false;
            Text = "Splash";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label ver;
        private Label logDisplay;
    }
}