using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tritium.Entities;

namespace Tritium.gui
{
    public partial class DeleteProtection : Form
    {
        readonly Klient client;
        public DeleteProtection(int id)
        {
            client = Program.db.GetClientById(id);
            InitializeComponent();
            fullname.Text = client.Jmeno;
            dob.Text = client.DatumNarozeni.Day + ". " + client.DatumNarozeni.Month + ". " + client.DatumNarozeni.Year;
            code.Text = GetRandomString();
        }

        private string GetRandomString()
        {
            var chars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz123456789";
            var stringChars = new char[6];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[new Random().Next(chars.Length)];
            }

            return new string(stringChars);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            closed = true;
            ManagerWindow.SwitchToWindow(new LoginInterface(), this);
            Close();
        }

        bool closed = false;
        protected override async void OnClosing(CancelEventArgs e)
        {
            if (!closed)
            {
                closed = true;
                ManagerWindow.SwitchToWindow(new LoginInterface(), this);
                base.OnClosing(e);
            }
        }

        private async void Commit_Click(object sender, EventArgs e)
        {
            if (code.Text.Equals(codeinput.Text))
            {
                await Program.db.DeleteClient(client.Id);
                closed = true;
                ManagerWindow.SwitchToWindow(new LoginInterface(), this);
                Close();
            }
        }
    }
}
