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
using Tritium.Entities;

namespace Tritium.print
{
    public partial class Form1 : Form
    {
        Navsteva? navsteva;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            navsteva = Program.db.GetClientById(1).Navstevy.First();

            printDocument1.DocumentName = $"Report z navstevy &{navsteva.Id} ({navsteva.Date:dd. MM. yyyy}) uzivatele #{navsteva.Client.Id} ({navsteva.Client.Jmeno}).pdf";

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
        private void Document_PrintPage(object sender,
            PrintPageEventArgs e)
        {
            Graphics? g = e.Graphics;
            if(g != null && navsteva != null)
            {
                Font f = new("Arial", 16);
                int y = 10;
                foreach (var item in navsteva.Plany)
                {
                    if (item.Note)
                    {
                        g.DrawString("Note: " + item.NoteContents, f, new SolidBrush(Color.Black), 20,y);

                        y += (int)g.MeasureString("Program: ", f).Height + 10;
                    } else
                    {
                        foreach (var item1 in item.Programy)
                        {
                            g.DrawString("Program: " + item1.Program.Name, f, new SolidBrush(Color.Black), 20, y);

                            y += (int)g.MeasureString("Program: ", f).Height + 10;
                        }
                    }
                    g.DrawLine(new Pen(new SolidBrush(Color.Black), 4), 10, y - 5, Width(g) - 10, y - 5);

                }
            }
        }

        private void Document_EndPrint(object sender, PrintEventArgs e)
        {
            printDocument1.Dispose();
            printDocument1 = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            printDocument1 = new PrintDocument();
            printDocument1.PrintPage += Document_PrintPage;
            printDocument1.EndPrint += Document_EndPrint;
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
