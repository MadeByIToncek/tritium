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
            panel1 = new Panel();
            button1 = new Button();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            ioIdent = new Label();
            groupBox7 = new GroupBox();
            groupBox21 = new GroupBox();
            sitOstatni = new TextBox();
            groupBox20 = new GroupBox();
            sitRodina = new TextBox();
            groupBox19 = new GroupBox();
            sitPrace = new TextBox();
            groupBox18 = new GroupBox();
            traveni = new TextBox();
            groupBox17 = new GroupBox();
            strava = new TextBox();
            groupBox16 = new GroupBox();
            rodinnaAnamneza = new TextBox();
            groupBox14 = new GroupBox();
            predchazejiciNemoci = new TextBox();
            groupBox12 = new GroupBox();
            dlouhodobePotize = new TextBox();
            groupBox11 = new GroupBox();
            leky = new TextBox();
            groupBox22 = new GroupBox();
            rozpolozeni = new TextBox();
            groupBox15 = new GroupBox();
            homeopatika = new TextBox();
            groupBox13 = new GroupBox();
            krevniTlak = new TextBox();
            groupBox10 = new GroupBox();
            AIOnemocneni = new TextBox();
            groupBox8 = new GroupBox();
            onko = new TextBox();
            epilepsie = new CheckBox();
            aktualniTehotenstvi = new CheckBox();
            kardiostimulator = new CheckBox();
            groupBox6 = new GroupBox();
            address = new TextBox();
            groupBox5 = new GroupBox();
            email = new TextBox();
            groupBox4 = new GroupBox();
            phone = new TextBox();
            groupBox9 = new GroupBox();
            notes = new TextBox();
            groupBox3 = new GroupBox();
            birthdate = new DateTimePicker();
            groupBox2 = new GroupBox();
            name = new TextBox();
            real_name = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
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
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(2085, 1136);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 1126);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(453, 1067);
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
            listBox1.Size = new Size(508, 1059);
            listBox1.TabIndex = 1;
            listBox1.MouseDoubleClick += ListBox1_MouseDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ioIdent);
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
            groupBox1.Size = new Size(1560, 1132);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Upravit klienta";
            // 
            // ioIdent
            // 
            ioIdent.AutoSize = true;
            ioIdent.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ioIdent.Location = new Point(12, 1050);
            ioIdent.Name = "loadIdent";
            ioIdent.Size = new Size(0, 65);
            ioIdent.TabIndex = 20;
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
            groupBox7.Controls.Add(groupBox12);
            groupBox7.Controls.Add(groupBox11);
            groupBox7.Controls.Add(groupBox22);
            groupBox7.Controls.Add(groupBox15);
            groupBox7.Controls.Add(groupBox13);
            groupBox7.Controls.Add(groupBox10);
            groupBox7.Controls.Add(groupBox8);
            groupBox7.Controls.Add(epilepsie);
            groupBox7.Controls.Add(aktualniTehotenstvi);
            groupBox7.Controls.Add(kardiostimulator);
            groupBox7.Location = new Point(535, 38);
            groupBox7.Margin = new Padding(4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(4);
            groupBox7.Size = new Size(1019, 1088);
            groupBox7.TabIndex = 19;
            groupBox7.TabStop = false;
            groupBox7.Text = "Informace";
            // 
            // groupBox21
            // 
            groupBox21.Controls.Add(sitOstatni);
            groupBox21.Location = new Point(506, 795);
            groupBox21.Margin = new Padding(2);
            groupBox21.Name = "groupBox21";
            groupBox21.Padding = new Padding(2);
            groupBox21.Size = new Size(507, 141);
            groupBox21.TabIndex = 34;
            groupBox21.TabStop = false;
            groupBox21.Text = "Situace - Ostatní";
            // 
            // sitOstatni
            // 
            sitOstatni.Location = new Point(6, 38);
            sitOstatni.Margin = new Padding(2);
            sitOstatni.Multiline = true;
            sitOstatni.Name = "sitOstatni";
            sitOstatni.ScrollBars = ScrollBars.Vertical;
            sitOstatni.Size = new Size(497, 99);
            sitOstatni.TabIndex = 5;
            sitOstatni.TextChanged += DatabaseUpdate;
            // 
            // groupBox20
            // 
            groupBox20.Controls.Add(sitRodina);
            groupBox20.Location = new Point(506, 650);
            groupBox20.Margin = new Padding(2);
            groupBox20.Name = "groupBox20";
            groupBox20.Padding = new Padding(2);
            groupBox20.Size = new Size(507, 141);
            groupBox20.TabIndex = 34;
            groupBox20.TabStop = false;
            groupBox20.Text = "Situace - Rodina";
            // 
            // sitRodina
            // 
            sitRodina.Location = new Point(6, 38);
            sitRodina.Margin = new Padding(2);
            sitRodina.Multiline = true;
            sitRodina.Name = "sitRodina";
            sitRodina.ScrollBars = ScrollBars.Vertical;
            sitRodina.Size = new Size(497, 99);
            sitRodina.TabIndex = 5;
            sitRodina.TextChanged += DatabaseUpdate;
            // 
            // groupBox19
            // 
            groupBox19.Controls.Add(sitPrace);
            groupBox19.Location = new Point(506, 505);
            groupBox19.Margin = new Padding(2);
            groupBox19.Name = "groupBox19";
            groupBox19.Padding = new Padding(2);
            groupBox19.Size = new Size(507, 141);
            groupBox19.TabIndex = 33;
            groupBox19.TabStop = false;
            groupBox19.Text = "Situace - Práce";
            // 
            // sitPrace
            // 
            sitPrace.Location = new Point(6, 38);
            sitPrace.Margin = new Padding(2);
            sitPrace.Multiline = true;
            sitPrace.Name = "sitPrace";
            sitPrace.ScrollBars = ScrollBars.Vertical;
            sitPrace.Size = new Size(497, 99);
            sitPrace.TabIndex = 5;
            sitPrace.TextChanged += DatabaseUpdate;
            // 
            // groupBox18
            // 
            groupBox18.Controls.Add(traveni);
            groupBox18.Location = new Point(506, 360);
            groupBox18.Margin = new Padding(2);
            groupBox18.Name = "groupBox18";
            groupBox18.Padding = new Padding(2);
            groupBox18.Size = new Size(507, 141);
            groupBox18.TabIndex = 28;
            groupBox18.TabStop = false;
            groupBox18.Text = "Trávení";
            // 
            // traveni
            // 
            traveni.Location = new Point(6, 38);
            traveni.Margin = new Padding(2);
            traveni.Multiline = true;
            traveni.Name = "traveni";
            traveni.ScrollBars = ScrollBars.Vertical;
            traveni.Size = new Size(497, 99);
            traveni.TabIndex = 5;
            traveni.TextChanged += DatabaseUpdate;
            // 
            // groupBox17
            // 
            groupBox17.Controls.Add(strava);
            groupBox17.Location = new Point(6, 781);
            groupBox17.Margin = new Padding(2);
            groupBox17.Name = "groupBox17";
            groupBox17.Padding = new Padding(2);
            groupBox17.Size = new Size(476, 141);
            groupBox17.TabIndex = 32;
            groupBox17.TabStop = false;
            groupBox17.Text = "Strava";
            // 
            // strava
            // 
            strava.Location = new Point(6, 38);
            strava.Margin = new Padding(2);
            strava.Multiline = true;
            strava.Name = "strava";
            strava.ScrollBars = ScrollBars.Vertical;
            strava.Size = new Size(470, 99);
            strava.TabIndex = 5;
            strava.TextChanged += DatabaseUpdate;
            // 
            // groupBox16
            // 
            groupBox16.Controls.Add(rodinnaAnamneza);
            groupBox16.Location = new Point(6, 636);
            groupBox16.Margin = new Padding(2);
            groupBox16.Name = "groupBox16";
            groupBox16.Padding = new Padding(2);
            groupBox16.Size = new Size(476, 141);
            groupBox16.TabIndex = 31;
            groupBox16.TabStop = false;
            groupBox16.Text = "Rodinná anamnéza";
            // 
            // rodinnaAnamneza
            // 
            rodinnaAnamneza.Location = new Point(6, 38);
            rodinnaAnamneza.Margin = new Padding(2);
            rodinnaAnamneza.Multiline = true;
            rodinnaAnamneza.Name = "rodinnaAnamneza";
            rodinnaAnamneza.ScrollBars = ScrollBars.Vertical;
            rodinnaAnamneza.Size = new Size(470, 99);
            rodinnaAnamneza.TabIndex = 5;
            rodinnaAnamneza.TextChanged += DatabaseUpdate;
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(predchazejiciNemoci);
            groupBox14.Location = new Point(6, 491);
            groupBox14.Margin = new Padding(2);
            groupBox14.Name = "groupBox14";
            groupBox14.Padding = new Padding(2);
            groupBox14.Size = new Size(476, 141);
            groupBox14.TabIndex = 30;
            groupBox14.TabStop = false;
            groupBox14.Text = "Předcházející nemoci";
            // 
            // predchazejiciNemoci
            // 
            predchazejiciNemoci.Location = new Point(6, 38);
            predchazejiciNemoci.Margin = new Padding(2);
            predchazejiciNemoci.Multiline = true;
            predchazejiciNemoci.Name = "predchazejiciNemoci";
            predchazejiciNemoci.ScrollBars = ScrollBars.Vertical;
            predchazejiciNemoci.Size = new Size(470, 99);
            predchazejiciNemoci.TabIndex = 5;
            predchazejiciNemoci.TextChanged += DatabaseUpdate;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(dlouhodobePotize);
            groupBox12.Location = new Point(6, 346);
            groupBox12.Margin = new Padding(2);
            groupBox12.Name = "groupBox12";
            groupBox12.Padding = new Padding(2);
            groupBox12.Size = new Size(476, 141);
            groupBox12.TabIndex = 29;
            groupBox12.TabStop = false;
            groupBox12.Text = "Dlouhodobé potíže";
            // 
            // dlouhodobePotize
            // 
            dlouhodobePotize.Location = new Point(6, 38);
            dlouhodobePotize.Margin = new Padding(2);
            dlouhodobePotize.Multiline = true;
            dlouhodobePotize.Name = "dlouhodobePotize";
            dlouhodobePotize.ScrollBars = ScrollBars.Vertical;
            dlouhodobePotize.Size = new Size(470, 99);
            dlouhodobePotize.TabIndex = 5;
            dlouhodobePotize.TextChanged += DatabaseUpdate;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(leky);
            groupBox11.Location = new Point(506, 215);
            groupBox11.Margin = new Padding(2);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new Padding(2);
            groupBox11.Size = new Size(507, 141);
            groupBox11.TabIndex = 28;
            groupBox11.TabStop = false;
            groupBox11.Text = "Léky";
            // 
            // leky
            // 
            leky.Location = new Point(6, 38);
            leky.Margin = new Padding(2);
            leky.Multiline = true;
            leky.Name = "leky";
            leky.ScrollBars = ScrollBars.Vertical;
            leky.Size = new Size(497, 99);
            leky.TabIndex = 5;
            leky.TextChanged += DatabaseUpdate;
            // 
            // groupBox22
            // 
            groupBox22.Controls.Add(rozpolozeni);
            groupBox22.Location = new Point(506, 940);
            groupBox22.Margin = new Padding(2);
            groupBox22.Name = "groupBox22";
            groupBox22.Padding = new Padding(2);
            groupBox22.Size = new Size(507, 141);
            groupBox22.TabIndex = 27;
            groupBox22.TabStop = false;
            groupBox22.Text = "Rozpoložení";
            // 
            // rozpolozeni
            // 
            rozpolozeni.Location = new Point(6, 38);
            rozpolozeni.Margin = new Padding(2);
            rozpolozeni.Multiline = true;
            rozpolozeni.Name = "rozpolozeni";
            rozpolozeni.ScrollBars = ScrollBars.Vertical;
            rozpolozeni.Size = new Size(497, 99);
            rozpolozeni.TabIndex = 5;
            rozpolozeni.TextChanged += DatabaseUpdate;
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(homeopatika);
            groupBox15.Location = new Point(506, 33);
            groupBox15.Margin = new Padding(2);
            groupBox15.Name = "groupBox15";
            groupBox15.Padding = new Padding(2);
            groupBox15.Size = new Size(507, 85);
            groupBox15.TabIndex = 18;
            groupBox15.TabStop = false;
            groupBox15.Text = "Homeopatika";
            // 
            // homeopatika
            // 
            homeopatika.Location = new Point(6, 38);
            homeopatika.Margin = new Padding(2);
            homeopatika.Name = "homeopatika";
            homeopatika.Size = new Size(497, 39);
            homeopatika.TabIndex = 5;
            homeopatika.TextChanged += DatabaseUpdate;
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(krevniTlak);
            groupBox13.Location = new Point(6, 257);
            groupBox13.Margin = new Padding(2);
            groupBox13.Name = "groupBox13";
            groupBox13.Padding = new Padding(2);
            groupBox13.Size = new Size(476, 85);
            groupBox13.TabIndex = 21;
            groupBox13.TabStop = false;
            groupBox13.Text = "Krevní tlak";
            // 
            // krevniTlak
            // 
            krevniTlak.Location = new Point(6, 38);
            krevniTlak.Margin = new Padding(2);
            krevniTlak.Name = "krevniTlak";
            krevniTlak.Size = new Size(466, 39);
            krevniTlak.TabIndex = 5;
            krevniTlak.TextChanged += DatabaseUpdate;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(AIOnemocneni);
            groupBox10.Location = new Point(6, 168);
            groupBox10.Margin = new Padding(2);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new Padding(2);
            groupBox10.Size = new Size(476, 85);
            groupBox10.TabIndex = 18;
            groupBox10.TabStop = false;
            groupBox10.Text = "Autoimunitní onemocnění";
            // 
            // AIOnemocneni
            // 
            AIOnemocneni.Location = new Point(6, 38);
            AIOnemocneni.Margin = new Padding(2);
            AIOnemocneni.Name = "AIOnemocneni";
            AIOnemocneni.Size = new Size(466, 39);
            AIOnemocneni.TabIndex = 5;
            AIOnemocneni.TextChanged += DatabaseUpdate;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(onko);
            groupBox8.Location = new Point(506, 126);
            groupBox8.Margin = new Padding(2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(2);
            groupBox8.Size = new Size(507, 85);
            groupBox8.TabIndex = 17;
            groupBox8.TabStop = false;
            groupBox8.Text = "Onkologické onemocnění";
            // 
            // onko
            // 
            onko.Location = new Point(6, 38);
            onko.Margin = new Padding(2);
            onko.Name = "onko";
            onko.Size = new Size(497, 39);
            onko.TabIndex = 5;
            onko.TextChanged += DatabaseUpdate;
            // 
            // epilepsie
            // 
            epilepsie.AutoSize = true;
            epilepsie.Location = new Point(8, 126);
            epilepsie.Margin = new Padding(4);
            epilepsie.Name = "epilepsie";
            epilepsie.Size = new Size(134, 36);
            epilepsie.TabIndex = 2;
            epilepsie.Text = "Epilepsie";
            epilepsie.UseVisualStyleBackColor = true;
            epilepsie.CheckedChanged += DatabaseUpdate;
            // 
            // aktualniTehotenstvi
            // 
            aktualniTehotenstvi.AutoSize = true;
            aktualniTehotenstvi.Location = new Point(8, 82);
            aktualniTehotenstvi.Margin = new Padding(4);
            aktualniTehotenstvi.Name = "aktualniTehotenstvi";
            aktualniTehotenstvi.Size = new Size(257, 36);
            aktualniTehotenstvi.TabIndex = 1;
            aktualniTehotenstvi.Text = "Aktualní Těhotenství";
            aktualniTehotenstvi.UseVisualStyleBackColor = true;
            aktualniTehotenstvi.CheckedChanged += DatabaseUpdate;
            // 
            // kardiostimulator
            // 
            kardiostimulator.AutoSize = true;
            kardiostimulator.Location = new Point(8, 38);
            kardiostimulator.Margin = new Padding(4);
            kardiostimulator.Name = "kardiostimulator";
            kardiostimulator.Size = new Size(215, 36);
            kardiostimulator.TabIndex = 0;
            kardiostimulator.Text = "Kardiostimulátor";
            kardiostimulator.UseVisualStyleBackColor = true;
            kardiostimulator.CheckedChanged += DatabaseUpdate;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(address);
            groupBox6.Location = new Point(12, 410);
            groupBox6.Margin = new Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(2);
            groupBox6.Size = new Size(516, 85);
            groupBox6.TabIndex = 18;
            groupBox6.TabStop = false;
            groupBox6.Text = "Adresa";
            // 
            // address
            // 
            address.Location = new Point(6, 38);
            address.Margin = new Padding(2);
            address.Name = "address";
            address.Size = new Size(504, 39);
            address.TabIndex = 5;
            address.TextChanged += DatabaseUpdate;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(email);
            groupBox5.Location = new Point(12, 320);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(516, 85);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Email";
            // 
            // email
            // 
            email.Location = new Point(6, 38);
            email.Margin = new Padding(2);
            email.Name = "email";
            email.Size = new Size(504, 39);
            email.TabIndex = 5;
            email.TextChanged += DatabaseUpdate;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(phone);
            groupBox4.Location = new Point(12, 230);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(516, 85);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Telefon";
            // 
            // phone
            // 
            phone.Location = new Point(6, 38);
            phone.Margin = new Padding(2);
            phone.Name = "phone";
            phone.Size = new Size(504, 39);
            phone.TabIndex = 5;
            phone.TextChanged += DatabaseUpdate;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(notes);
            groupBox9.Location = new Point(12, 500);
            groupBox9.Margin = new Padding(2);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(2);
            groupBox9.Size = new Size(516, 353);
            groupBox9.TabIndex = 11;
            groupBox9.TabStop = false;
            groupBox9.Text = "Poznámky";
            // 
            // notes
            // 
            notes.Location = new Point(6, 38);
            notes.Margin = new Padding(2);
            notes.Multiline = true;
            notes.Name = "notes";
            notes.ScrollBars = ScrollBars.Vertical;
            notes.Size = new Size(504, 311);
            notes.TabIndex = 13;
            notes.TextChanged += DatabaseUpdate;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(birthdate);
            groupBox3.Location = new Point(12, 140);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(516, 85);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datum narození (DD.MM.YYYY)";
            // 
            // birthdate
            // 
            birthdate.Location = new Point(6, 37);
            birthdate.Name = "birthdate";
            birthdate.Size = new Size(504, 39);
            birthdate.TabIndex = 0;
            birthdate.TextChanged += DatabaseUpdate;
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
            name.TextChanged += DatabaseUpdate;
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
            real_name.TextChanged += DatabaseUpdate;
            // 
            // ClientDBInterface
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(2108, 1162);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ClientDBInterface";
            Text = "Mikroby - Tritium";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private TextBox notes;
        private Button button1;
        private GroupBox groupBox5;
        private TextBox email;
        private GroupBox groupBox4;
        private TextBox phone;
        private GroupBox groupBox6;
        private TextBox address;
        private GroupBox groupBox7;
        private CheckBox kardiostimulator;
        private CheckBox epilepsie;
        private CheckBox aktualniTehotenstvi;
        private GroupBox groupBox8;
        private TextBox onko;
        private GroupBox groupBox13;
        private TextBox krevniTlak;
        private GroupBox groupBox10;
        private TextBox AIOnemocneni;
        private GroupBox groupBox22;
        private TextBox rozpolozeni;
        private GroupBox groupBox15;
        private TextBox homeopatika;
        private GroupBox groupBox11;
        private TextBox leky;
        private GroupBox groupBox12;
        private TextBox dlouhodobePotize;
        private GroupBox groupBox14;
        private TextBox predchazejiciNemoci;
        private GroupBox groupBox19;
        private TextBox sitPrace;
        private GroupBox groupBox18;
        private TextBox traveni;
        private GroupBox groupBox17;
        private TextBox strava;
        private GroupBox groupBox16;
        private TextBox rodinnaAnamneza;
        private GroupBox groupBox20;
        private GroupBox groupBox21;
        private TextBox sitOstatni;
        private TextBox sitRodina;
        private DateTimePicker birthdate;
        private Label ioIdent;
    }
}