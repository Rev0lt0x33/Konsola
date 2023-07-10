using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Controlls
{
    public partial class LogWindow : UserControl
    {
        private String path;
        private Process exeProcess;        
        private StringBuilder output = new StringBuilder();
        private bool outputChanged = false;
        private object outputLock = new object();

        public LogWindow()
        {
            InitializeComponent();
        }

        private void fileBox_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
            openFile.FilterIndex = 1;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.path = openFile.FileName;
                fileBox.Text = path;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            if (path == null)
            {
                fileBox_Click(sender, e);
                return;
            }

            lock(outputLock) if (exeProcess != null) return;

            startButton.Enabled = false;
            stopButton.Enabled = true;

            exeProcess = new Process();
            exeProcess.StartInfo.FileName = path;
            exeProcess.StartInfo.RedirectStandardError = true;
            exeProcess.StartInfo.RedirectStandardOutput = true;
            exeProcess.StartInfo.UseShellExecute = false;
            exeProcess.StartInfo.CreateNoWindow = true;
            exeProcess.EnableRaisingEvents = true;
            exeProcess.OutputDataReceived += new DataReceivedEventHandler(outputHandler); 
            exeProcess.ErrorDataReceived += new DataReceivedEventHandler(errorHandler);
            exeProcess.Exited += new EventHandler(onExit);
            exeProcess.Start();
            exeProcess.BeginOutputReadLine();
            
            

        }

        private void outputHandler(object sender, DataReceivedEventArgs e)
        {

            lock (outputLock)
            {
                if (sender != exeProcess) return;
                output.AppendLine("[" + DateTime.Now.ToString("HH:mm:ss") +"] " +  e.Data);
                if (outputChanged) return;
                outputChanged = true;
                BeginInvoke(new Action(onOutputChanged));
            }                       
        }

        private void onOutputChanged()
        {
            lock (outputLock)
            {

                logBox.Text = output.ToString();
                logBox.SelectionLength = output.Length;
                logBox.ScrollToCaret();
                outputChanged = false;
            }            
        }

       
        public void onExit(object sender, EventArgs e)
        {
            lock (outputLock)
            {
                output.AppendLine("---------------------------------------------------------");
                BeginInvoke(new Action(onOutputChanged));
                if (exeProcess == null) return;
                if (!exeProcess.HasExited) exeProcess.Kill();
                exeProcess.Dispose();
                exeProcess = null;

            }                    
        }
     

        private void errorHandler(object sender, DataReceivedEventArgs e)
        {
            lock (outputLock)
            {
                output.Append(e.Data);
                BeginInvoke(new Action(onOutputChanged));
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            lock (outputLock)
            {
                output.Clear();
                outputChanged = true;
                BeginInvoke(new Action(onOutputChanged));
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
            onExit(sender, e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            lock(outputLock)
            {
                if (!Directory.Exists("logs/")) Directory.CreateDirectory("logs");
                StringBuilder path = new StringBuilder();
                path.Append("logs/" + DateTime.Now.ToString("dd-MM-HH-mm-ss") + ".txt");
                using (StreamWriter writer = new StreamWriter(path.ToString())) 
                {
                    writer.Write(output.ToString());
                }
                output.AppendLine("Zapisano do pliku: " + path.ToString());
                outputChanged = true;
                BeginInvoke(new Action(onOutputChanged));
            }

        }
    }
}
