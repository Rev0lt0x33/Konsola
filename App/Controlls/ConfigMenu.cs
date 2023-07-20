using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
using System.IO;

namespace App.Controlls
{
    public partial class ConfigMenu : UserControl
    {
        private Dictionary<string, string> settingsDict = new Dictionary<string, string>();
        private Settings settings = new Settings();
        
        public ConfigMenu()
        {
           
            settingsDict = settings.loadFromFile();
            InitializeComponent();
           
                if (settingsDict["autorun"].Equals("True")) autorunConfigurationBox.Checked = true;
                if (settingsDict["automin"].Equals("True")) autominConfigurationBox.Checked = true;
                if (settingsDict["path"] != null) fileConfigurationBox.Text = settingsDict["path"];
           
        }


        private void configSaveButton_Click(object sender, EventArgs e)
        {
            settings.saveToFile(settingsDict);
        }

        private void autominConfigurationBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autominConfigurationBox.Checked)
            {
                settingsDict["automin"] = "True";
            }
            else
            {
                settingsDict["automin"] = "False";
            }
        }
        private void autorunConfigurationBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autorunConfigurationBox.Checked)
            {
                settingsDict["autorun"] = "True";
            }
            else
            {
                settingsDict["autorun"] = "False";
            }
        }

        private void fileConfigurationBox_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Exe Files (.exe)|*.exe";
            openFile.FilterIndex = 1;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                settingsDict["path"] = openFile.FileName;
                fileConfigurationBox.Text = openFile.FileName;
            }
        }
    }
}
