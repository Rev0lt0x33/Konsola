using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(CheckRunning() != null) 
            {
                MessageBox.Show("Aplikacja już działa");
                return;
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }




        private static Process CheckRunning()
        {
            Process current = Process.GetCurrentProcess();
            Process[] running = Process.GetProcessesByName(current.ProcessName);
            foreach (Process process in running)
            {
                if((process.Id != current.Id)  && (process.MainModule.FileName == current.MainModule.FileName ))
                {
                    return process;
                }
            }
            return null;
        }






    }
}
