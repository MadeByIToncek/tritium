
namespace Tritium
{
    partial class LoginInterface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginInterface));
            select = new Button();
            manageClients = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            manageMicrobeDB = new Button();
            exit = new Button();
            listBox1 = new ListBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // select
            // 
            select.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            select.Location = new Point(3, 3);
            select.Name = "select";
            select.Size = new Size(46, 42);
            select.TabIndex = 1;
            select.Text = "➡";
            select.UseVisualStyleBackColor = true;
            // 
            // manageClients
            // 
            manageClients.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            manageClients.Location = new Point(3, 51);
            manageClients.Name = "manageClients";
            manageClients.Size = new Size(46, 42);
            manageClients.TabIndex = 2;
            manageClients.Text = "👥";
            manageClients.UseVisualStyleBackColor = true;
            manageClients.Click += ManageClients_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(select);
            flowLayoutPanel1.Controls.Add(manageClients);
            flowLayoutPanel1.Controls.Add(manageMicrobeDB);
            flowLayoutPanel1.Controls.Add(exit);
            flowLayoutPanel1.Location = new Point(517, 76);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(49, 190);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // manageMicrobeDB
            // 
            manageMicrobeDB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            manageMicrobeDB.Location = new Point(3, 99);
            manageMicrobeDB.Name = "manageMicrobeDB";
            manageMicrobeDB.Size = new Size(46, 42);
            manageMicrobeDB.TabIndex = 4;
            manageMicrobeDB.Text = "\U0001f9a0";
            manageMicrobeDB.UseVisualStyleBackColor = true;
            manageMicrobeDB.Click += ManageMicrobeDB_Click;
            // 
            // exit
            // 
            exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            exit.ForeColor = Color.Red;
            exit.Location = new Point(3, 147);
            exit.Name = "exit";
            exit.Size = new Size(46, 42);
            exit.TabIndex = 5;
            exit.Text = "\U0001f6d1";
            exit.UseVisualStyleBackColor = true;
            exit.Click += Exit_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(10, 10);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(502, 314);
            listBox1.TabIndex = 5;
            // 
            // LoginManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 347);
            Controls.Add(listBox1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximumSize = new Size(599, 398);
            MinimumSize = new Size(599, 398);
            Name = "LoginManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tritium";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected override void OnClosed(EventArgs e)
        {
            NaturalClosed();
            base.OnClosed(e);
        }
        private Button select;
        private Button manageClients;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button manageMicrobeDB;
        private Button exit;
        private ListBox listBox1;
    }
}
