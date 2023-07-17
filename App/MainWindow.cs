using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
            Hide();
            notifyIcon.Visible = true;
            this.ShowInTaskbar = false;
                      
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
            this.notifyIcon.ContextMenuStrip.Items.Add("Zakońćz", null, this.NotifyMenuExit_Click);
        }

        private void NotifyMenuExit_Click(object sender, EventArgs e)
        {
            logWindow1.onExit(sender, e);
            Application.Exit();
        }


    }
}
