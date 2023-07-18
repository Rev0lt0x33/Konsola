using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
     internal class Settings
    {
        private Configuration configurationFile = null;
        private KeyValueConfigurationCollection configurationSettings = null;

        public Settings()
        {
             configurationFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
             configurationSettings = configurationFile.AppSettings.Settings;
        }

        public void saveToFile(Dictionary<string,string> tempSettings)
        {
            try
            {
                foreach (var key in tempSettings.Keys)
                {
                    if (configurationSettings[key] == null) configurationSettings.Add(key, tempSettings[key]);
                    configurationSettings[key].Value = tempSettings[key];
                }
                configurationFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configurationFile.AppSettings.SectionInformation.Name);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        public Dictionary<string,string> loadFromFile()
        {
            try
            {
                Dictionary<string,string> result = new Dictionary<string,string>();
                
                    foreach(var key in configurationSettings.AllKeys)
                    {
                        result.Add(key, configurationSettings[key].Value);
                    }
                
                return result;

            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public bool checkAutoRun()
        {
            return configurationSettings["autorun"].Value == "true";
        }

    }
}
