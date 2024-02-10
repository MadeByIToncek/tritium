namespace Tritium
{
    public partial class MicrobeDBManager : Form { 
        public MicrobeDBManager()
        {
            InitializeComponent();
            for (int i = 0; i < 99; i++)
            {
                listBox1.Items.Add("Mikrob " + (i+1));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
