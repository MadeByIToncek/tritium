using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tritium.databases;

namespace Tritium
{
    public partial class MicrobeDBManager : Form
    {
        private List<Microbe> microbes = new List<Microbe>();
        public MicrobeDBManager()
        {
            InitializeComponent();
            using (var ctx = new MyContext())
            {
                var microbe = new Microbe
                {
                    MicrobeID = 0,
                    Readable_name = "Cryptosporidium parvum",
                    Type = "1PP",
                    Lenght = 54 * 60,
                    S = true,
                    O = false,
                    Par = false,
                    mortFRQ = new List<int> { 220, 482 },
                    SCP = new List<string> { "PL2", "PP2" },
                    Okruh = new List<string> { },
                    Note = ""
                };
                ctx.Microbes.Add(microbe);
                ctx.SaveChanges();
            }

            using (var ctx = new MyContext())
            {
                foreach (var item in ctx.Microbes)
                {
                    microbes.Add(item);
                }
            }
            listBox1.BeginUpdate();
            foreach (var item in microbes)
            {
                listBox1.Items.Add(item.Readable_name);
            }
            listBox1.SetSelected(1, true);
            listBox1.EndUpdate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            string curItem = listBox1.SelectedItem?.ToString();
            Microbe microbe = null;
            foreach (var mic in microbes)
            {
                if(mic.Readable_name == curItem)
                {
                    microbe = mic; break;
                }
            }
            if(microbe != null)
            {

            }
        }
    }
}
