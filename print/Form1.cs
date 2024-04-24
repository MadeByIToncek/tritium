using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tritium.print
{
    public partial class Form1 : Form
    {
        // Declare a string to hold the entire document contents.
        private string documentContents = "";

        // Declare a variable to hold the portion of the document that
        // is not printed.
        private string stringToPrint = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            printDocument1.DocumentName = "test.txt";
            stringToPrint = "Testovací soubor tisku pomocí C#";

            printDialog1.Document = printDocument1;

            DialogResult result = printDialog1.ShowDialog();

            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        // The PrintDialog will print the document
        // by handling the document's PrintPage event.
        private void document_PrintPage(object sender,
            PrintPageEventArgs e)
        {
            Graphics? g = e.Graphics;
            if(g != null)
            {
                g.DrawLine(new Pen(Color.Black), new Point(10, 10), new Point(10, Height(g) - 10));
                g.DrawLine(new Pen(Color.Black), new Point(Width(g) - 10, 10), new Point(Width(g) - 10, Height(g) - 10));
            }
        }

        private static int Width(Graphics g)
        {
            return (int)MathF.Round(g.VisibleClipBounds.Width);
        }
        private static int Height(Graphics g)
        {
            return (int)Math.Round(g.VisibleClipBounds.Height);
        }
    }
}
