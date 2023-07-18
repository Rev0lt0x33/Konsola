using App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class MainWindow : Form
    {

        
       

        public MainWindow()
        {

            InitializeComponent();
            
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {         
            e.Cancel = true;
            hideWindow();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
            this.ShowInTaskbar = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.notifyIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.notifyIcon.ContextMenuStrip.Items.Add("Zakończ", null, this.NotifyMenuExit_Click);

            Settings settings = new Settings();
            Dictionary<string, string> settingsDict = settings.loadFromFile();
            if (settingsDict["automin"].Equals("True")) hideWindow();
        }

        private void NotifyMenuExit_Click(object sender, EventArgs e)
        {
            logWindow2.onExit(sender, e);
            Application.Exit();
        }

        private void hideWindow()
        {
            Hide();
            notifyIcon.Visible = true;
            this.ShowInTaskbar = false;
        }
    }
}
