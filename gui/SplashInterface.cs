﻿using static System.Net.Mime.MediaTypeNames;

namespace Tritium
{
    public partial class SplashInterface : Form
    {
        public SplashInterface()
        {
            InitializeComponent();
            SetCurrentProgressMessage("SYSTEM", "Initialization beginning");

            ver.Text = string.Concat("Version: ", Environment.GetEnvironmentVariable("ClickOnce_CurrentVersion") ?? "0.0.0.0");
        }

        public void SetCurrentProgressMessage(string prefix, string msg)
        {
            if (logDisplay.InvokeRequired)
            {
                // Call this same method but append THREAD2 to the text
                void safeWrite() { SetCurrentProgressMessage(prefix, msg); }
                logDisplay.Invoke(safeWrite);
            }
            else
                logDisplay.Text = prefix + " " + msg;
        }
    }
}
