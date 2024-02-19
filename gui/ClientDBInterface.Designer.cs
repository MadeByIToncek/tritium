using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.ComponentModel;

namespace Tritium
{
    partial class ClientDBInterface
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ClientDBInterface));
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            groupBox7 = new GroupBox();
            groupBox21 = new GroupBox();
            textBox17 = new TextBox();
            groupBox20 = new GroupBox();
            textBox16 = new TextBox();
            groupBox19 = new GroupBox();
            textBox15 = new TextBox();
            groupBox18 = new GroupBox();
            textBox14 = new TextBox();
            groupBox17 = new GroupBox();
            textBox13 = new TextBox();
            groupBox16 = new GroupBox();
            textBox12 = new TextBox();
            groupBox14 = new GroupBox();
            textBox10 = new TextBox();
            cancel = new Button();
            groupBox12 = new GroupBox();
            textBox8 = new TextBox();
            commit = new Button();
            groupBox11 = new GroupBox();
            textBox7 = new TextBox();
            groupBox22 = new GroupBox();
            textBox18 = new TextBox();
            groupBox15 = new GroupBox();
            textBox11 = new TextBox();
            groupBox13 = new GroupBox();
            textBox9 = new TextBox();
            groupBox10 = new GroupBox();
            textBox6 = new TextBox();
            groupBox8 = new GroupBox();
            textBox5 = new TextBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox6 = new GroupBox();
            textBox4 = new TextBox();
            groupBox5 = new GroupBox();
            textBox3 = new TextBox();
            groupBox4 = new GroupBox();
            textBox1 = new TextBox();
            groupBox9 = new GroupBox();
            poznamky = new TextBox();
            groupBox3 = new GroupBox();
            dlazdice = new TextBox();
            groupBox2 = new GroupBox();
            name = new TextBox();
            real_name = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox21.SuspendLayout();
            groupBox20.SuspendLayout();
            groupBox19.SuspendLayout();
            groupBox18.SuspendLayout();
            groupBox17.SuspendLayout();
            groupBox16.SuspendLayout();
            groupBox14.SuspendLayout();
            groupBox12.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox22.SuspendLayout();
            groupBox15.SuspendLayout();
            groupBox13.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(2085, 1192);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox7);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox9);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(real_name);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(523, 2);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1560, 1188);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Upravit klienta";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(groupBox21);
            groupBox7.Controls.Add(groupBox20);
            groupBox7.Controls.Add(groupBox19);
            groupBox7.Controls.Add(groupBox18);
            groupBox7.Controls.Add(groupBox17);
            groupBox7.Controls.Add(groupBox16);
            groupBox7.Controls.Add(groupBox14);
            groupBox7.Controls.Add(cancel);
            groupBox7.Controls.Add(groupBox12);
            groupBox7.Controls.Add(commit);
            groupBox7.Controls.Add(groupBox11);
            groupBox7.Controls.Add(groupBox22);
            groupBox7.Controls.Add(groupBox15);
            groupBox7.Controls.Add(groupBox13);
            groupBox7.Controls.Add(groupBox10);
            groupBox7.Controls.Add(groupBox8);
            groupBox7.Controls.Add(checkBox3);
            groupBox7.Controls.Add(checkBox2);
            groupBox7.Controls.Add(checkBox1);
            groupBox7.Location = new Point(535, 38);
            groupBox7.Margin = new Padding(4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(4);
            groupBox7.Size = new Size(1019, 1147);
            groupBox7.TabIndex = 19;
            groupBox7.TabStop = false;
            groupBox7.Text = "Informace";
            // 
            // groupBox21
            // 
            groupBox21.Controls.Add(textBox17);
            groupBox21.Location = new Point(506, 795);
            groupBox21.Margin = new Padding(2);
            groupBox21.Name = "groupBox21";
            groupBox21.Padding = new Padding(2);
            groupBox21.Size = new Size(507, 141);
            groupBox21.TabIndex = 34;
            groupBox21.TabStop = false;
            groupBox21.Text = "Situace - Ostatní";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(6, 38);
            textBox17.Margin = new Padding(2);
            textBox17.Multiline = true;
            textBox17.Name = "textBox17";
            textBox17.ScrollBars = ScrollBars.Vertical;
            textBox17.Size = new Size(497, 99);
            textBox17.TabIndex = 5;
            // 
            // groupBox20
            // 
            groupBox20.Controls.Add(textBox16);
            groupBox20.Location = new Point(506, 650);
            groupBox20.Margin = new Padding(2);
            groupBox20.Name = "groupBox20";
            groupBox20.Padding = new Padding(2);
            groupBox20.Size = new Size(507, 141);
            groupBox20.TabIndex = 34;
            groupBox20.TabStop = false;
            groupBox20.Text = "Situace - Rodina";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(6, 38);
            textBox16.Margin = new Padding(2);
            textBox16.Multiline = true;
            textBox16.Name = "textBox16";
            textBox16.ScrollBars = ScrollBars.Vertical;
            textBox16.Size = new Size(497, 99);
            textBox16.TabIndex = 5;
            // 
            // groupBox19
            // 
            groupBox19.Controls.Add(textBox15);
            groupBox19.Location = new Point(506, 505);
            groupBox19.Margin = new Padding(2);
            groupBox19.Name = "groupBox19";
            groupBox19.Padding = new Padding(2);
            groupBox19.Size = new Size(507, 141);
            groupBox19.TabIndex = 33;
            groupBox19.TabStop = false;
            groupBox19.Text = "Situace - Práce";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(6, 38);
            textBox15.Margin = new Padding(2);
            textBox15.Multiline = true;
            textBox15.Name = "textBox15";
            textBox15.ScrollBars = ScrollBars.Vertical;
            textBox15.Size = new Size(497, 99);
            textBox15.TabIndex = 5;
            // 
            // groupBox18
            // 
            groupBox18.Controls.Add(textBox14);
            groupBox18.Location = new Point(506, 360);
            groupBox18.Margin = new Padding(2);
            groupBox18.Name = "groupBox18";
            groupBox18.Padding = new Padding(2);
            groupBox18.Size = new Size(507, 141);
            groupBox18.TabIndex = 28;
            groupBox18.TabStop = false;
            groupBox18.Text = "Trávení";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(6, 38);
            textBox14.Margin = new Padding(2);
            textBox14.Multiline = true;
            textBox14.Name = "textBox14";
            textBox14.ScrollBars = ScrollBars.Vertical;
            textBox14.Size = new Size(497, 99);
            textBox14.TabIndex = 5;
            // 
            // groupBox17
            // 
            groupBox17.Controls.Add(textBox13);
            groupBox17.Location = new Point(6, 781);
            groupBox17.Margin = new Padding(2);
            groupBox17.Name = "groupBox17";
            groupBox17.Padding = new Padding(2);
            groupBox17.Size = new Size(476, 141);
            groupBox17.TabIndex = 32;
            groupBox17.TabStop = false;
            groupBox17.Text = "Strava";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(6, 38);
            textBox13.Margin = new Padding(2);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.ScrollBars = ScrollBars.Vertical;
            textBox13.Size = new Size(470, 99);
            textBox13.TabIndex = 5;
            // 
            // groupBox16
            // 
            groupBox16.Controls.Add(textBox12);
            groupBox16.Location = new Point(6, 636);
            groupBox16.Margin = new Padding(2);
            groupBox16.Name = "groupBox16";
            groupBox16.Padding = new Padding(2);
            groupBox16.Size = new Size(476, 141);
            groupBox16.TabIndex = 31;
            groupBox16.TabStop = false;
            groupBox16.Text = "Rodinná anamnéza";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(6, 38);
            textBox12.Margin = new Padding(2);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.ScrollBars = ScrollBars.Vertical;
            textBox12.Size = new Size(470, 99);
            textBox12.TabIndex = 5;
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(textBox10);
            groupBox14.Location = new Point(6, 491);
            groupBox14.Margin = new Padding(2);
            groupBox14.Name = "groupBox14";
            groupBox14.Padding = new Padding(2);
            groupBox14.Size = new Size(476, 141);
            groupBox14.TabIndex = 30;
            groupBox14.TabStop = false;
            groupBox14.Text = "Předcházející nemoci";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(6, 38);
            textBox10.Margin = new Padding(2);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.ScrollBars = ScrollBars.Vertical;
            textBox10.Size = new Size(470, 99);
            textBox10.TabIndex = 5;
            // 
            // cancel
            // 
            cancel.Location = new Point(746, 1085);
            cancel.Margin = new Padding(2);
            cancel.Name = "cancel";
            cancel.Size = new Size(131, 55);
            cancel.TabIndex = 14;
            cancel.Text = "❌Zrušit";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(textBox8);
            groupBox12.Location = new Point(6, 346);
            groupBox12.Margin = new Padding(2);
            groupBox12.Name = "groupBox12";
            groupBox12.Padding = new Padding(2);
            groupBox12.Size = new Size(476, 141);
            groupBox12.TabIndex = 29;
            groupBox12.TabStop = false;
            groupBox12.Text = "Dlouhodobé potíže";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(6, 38);
            textBox8.Margin = new Padding(2);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.ScrollBars = ScrollBars.Vertical;
            textBox8.Size = new Size(470, 99);
            textBox8.TabIndex = 5;
            // 
            // commit
            // 
            commit.Location = new Point(882, 1085);
            commit.Margin = new Padding(2);
            commit.Name = "commit";
            commit.Size = new Size(131, 55);
            commit.TabIndex = 15;
            commit.Text = "✔OK";
            commit.UseVisualStyleBackColor = true;
            commit.Click += Commit_Click;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(textBox7);
            groupBox11.Location = new Point(506, 215);
            groupBox11.Margin = new Padding(2);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new Padding(2);
            groupBox11.Size = new Size(507, 141);
            groupBox11.TabIndex = 28;
            groupBox11.TabStop = false;
            groupBox11.Text = "Léky";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(6, 38);
            textBox7.Margin = new Padding(2);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ScrollBars = ScrollBars.Vertical;
            textBox7.Size = new Size(497, 99);
            textBox7.TabIndex = 5;
            // 
            // groupBox22
            // 
            groupBox22.Controls.Add(textBox18);
            groupBox22.Location = new Point(506, 940);
            groupBox22.Margin = new Padding(2);
            groupBox22.Name = "groupBox22";
            groupBox22.Padding = new Padding(2);
            groupBox22.Size = new Size(507, 141);
            groupBox22.TabIndex = 27;
            groupBox22.TabStop = false;
            groupBox22.Text = "Rozpoložení";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(6, 38);
            textBox18.Margin = new Padding(2);
            textBox18.Multiline = true;
            textBox18.Name = "textBox18";
            textBox18.ScrollBars = ScrollBars.Vertical;
            textBox18.Size = new Size(497, 99);
            textBox18.TabIndex = 5;
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(textBox11);
            groupBox15.Location = new Point(506, 33);
            groupBox15.Margin = new Padding(2);
            groupBox15.Name = "groupBox15";
            groupBox15.Padding = new Padding(2);
            groupBox15.Size = new Size(507, 85);
            groupBox15.TabIndex = 18;
            groupBox15.TabStop = false;
            groupBox15.Text = "Homeopatika";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(6, 38);
            textBox11.Margin = new Padding(2);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(497, 39);
            textBox11.TabIndex = 5;
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(textBox9);
            groupBox13.Location = new Point(6, 257);
            groupBox13.Margin = new Padding(2);
            groupBox13.Name = "groupBox13";
            groupBox13.Padding = new Padding(2);
            groupBox13.Size = new Size(476, 85);
            groupBox13.TabIndex = 21;
            groupBox13.TabStop = false;
            groupBox13.Text = "Krevní tlak";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(6, 38);
            textBox9.Margin = new Padding(2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(466, 39);
            textBox9.TabIndex = 5;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(textBox6);
            groupBox10.Location = new Point(6, 168);
            groupBox10.Margin = new Padding(2);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new Padding(2);
            groupBox10.Size = new Size(476, 85);
            groupBox10.TabIndex = 18;
            groupBox10.TabStop = false;
            groupBox10.Text = "Autoimunitní onemocnění";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(6, 38);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(466, 39);
            textBox6.TabIndex = 5;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(textBox5);
            groupBox8.Location = new Point(506, 126);
            groupBox8.Margin = new Padding(2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(2);
            groupBox8.Size = new Size(507, 85);
            groupBox8.TabIndex = 17;
            groupBox8.TabStop = false;
            groupBox8.Text = "Onkologické onemocnění";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 38);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(497, 39);
            textBox5.TabIndex = 5;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(8, 126);
            checkBox3.Margin = new Padding(4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(134, 36);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Epilepsie";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(8, 82);
            checkBox2.Margin = new Padding(4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(257, 36);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Aktualní Těhotenství";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(8, 38);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(215, 36);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Kardiostimulátor";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBox4);
            groupBox6.Location = new Point(12, 410);
            groupBox6.Margin = new Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(2);
            groupBox6.Size = new Size(516, 85);
            groupBox6.TabIndex = 18;
            groupBox6.TabStop = false;
            groupBox6.Text = "Adresa";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 38);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(504, 39);
            textBox4.TabIndex = 5;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox3);
            groupBox5.Location = new Point(12, 320);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(516, 85);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 38);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(504, 39);
            textBox3.TabIndex = 5;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox1);
            groupBox4.Location = new Point(12, 230);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(516, 85);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Telefon";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 38);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(504, 39);
            textBox1.TabIndex = 5;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(poznamky);
            groupBox9.Location = new Point(12, 500);
            groupBox9.Margin = new Padding(2);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(2);
            groupBox9.Size = new Size(516, 353);
            groupBox9.TabIndex = 11;
            groupBox9.TabStop = false;
            groupBox9.Text = "Poznámky";
            // 
            // poznamky
            // 
            poznamky.Location = new Point(6, 38);
            poznamky.Margin = new Padding(2);
            poznamky.Multiline = true;
            poznamky.Name = "poznamky";
            poznamky.ScrollBars = ScrollBars.Vertical;
            poznamky.Size = new Size(504, 311);
            poznamky.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dlazdice);
            groupBox3.Location = new Point(12, 140);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(516, 85);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datum narození (DD.MM.YYYY)";
            // 
            // dlazdice
            // 
            dlazdice.Location = new Point(6, 38);
            dlazdice.Margin = new Padding(2);
            dlazdice.Name = "dlazdice";
            dlazdice.Size = new Size(504, 39);
            dlazdice.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(name);
            groupBox2.Location = new Point(12, 38);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(516, 98);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Jméno a příjmení";
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(6, 38);
            name.Margin = new Padding(2);
            name.Name = "name";
            name.Size = new Size(504, 50);
            name.TabIndex = 4;
            // 
            // real_name
            // 
            real_name.AutoSize = true;
            real_name.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            real_name.Location = new Point(6, 28);
            real_name.Margin = new Padding(2, 0, 2, 0);
            real_name.Name = "real_name";
            real_name.Size = new Size(0, 60);
            real_name.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 1185);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.Location = new Point(390, 1123);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(55, 55);
            button2.TabIndex = 2;
            button2.Text = "➖";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(453, 1123);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(55, 55);
            button1.TabIndex = 3;
            button1.Text = "➕";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.IntegralHeight = false;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(2, 2);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(508, 1115);
            listBox1.TabIndex = 1;
            listBox1.MouseDoubleClick += ListBox1_MouseDoubleClick;
            // 
            // ClientDBInterface
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(2108, 1210);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ClientDBInterface";
            Text = "Mikroby - Tritium";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox21.ResumeLayout(false);
            groupBox21.PerformLayout();
            groupBox20.ResumeLayout(false);
            groupBox20.PerformLayout();
            groupBox19.ResumeLayout(false);
            groupBox19.PerformLayout();
            groupBox18.ResumeLayout(false);
            groupBox18.PerformLayout();
            groupBox17.ResumeLayout(false);
            groupBox17.PerformLayout();
            groupBox16.ResumeLayout(false);
            groupBox16.PerformLayout();
            groupBox14.ResumeLayout(false);
            groupBox14.PerformLayout();
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox22.ResumeLayout(false);
            groupBox22.PerformLayout();
            groupBox15.ResumeLayout(false);
            groupBox15.PerformLayout();
            groupBox13.ResumeLayout(false);
            groupBox13.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
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
        private GroupBox groupBox9;
        private TextBox poznamky;
        private Button button1;
        private Button button2;
        private GroupBox groupBox5;
        private TextBox textBox3;
        private GroupBox groupBox4;
        private TextBox textBox1;
        private GroupBox groupBox6;
        private TextBox textBox4;
        private GroupBox groupBox7;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private GroupBox groupBox8;
        private TextBox textBox5;
        private GroupBox groupBox13;
        private TextBox textBox9;
        private GroupBox groupBox10;
        private TextBox textBox6;
        private GroupBox groupBox22;
        private TextBox textBox18;
        private GroupBox groupBox15;
        private TextBox textBox11;
        private GroupBox groupBox11;
        private TextBox textBox7;
        private GroupBox groupBox12;
        private TextBox textBox8;
        private GroupBox groupBox14;
        private TextBox textBox10;
        private GroupBox groupBox19;
        private TextBox textBox15;
        private GroupBox groupBox18;
        private TextBox textBox14;
        private GroupBox groupBox17;
        private TextBox textBox13;
        private GroupBox groupBox16;
        private TextBox textBox12;
        private GroupBox groupBox20;
        private GroupBox groupBox21;
        private TextBox textBox17;
        private TextBox textBox16;
    }
}