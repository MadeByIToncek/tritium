using Tritium.Entities;

namespace Tritium
{
    public partial class MicrobeDBManager : Form { 
        public MicrobeDBManager()
        {
            InitializeComponent();
            foreach (PatogenProgram ppgrm in Program.db.ListPatogenPrograms())
            {
                listBox1.Items.Add(ppgrm.Name);
            };
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
