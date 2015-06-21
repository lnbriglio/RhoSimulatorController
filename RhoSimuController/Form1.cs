using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhoSimuController
{
    public partial class Form1 : Form
    {
        private string folderName = null;
        private string configFileName = "config.txt";

        public Form1()
        {
            InitializeComponent();
            try
            {
                using (var reader = File.OpenText(configFileName))
                {
                    folderName = reader.ReadToEnd();
                };
            }
            catch (System.IO.FileNotFoundException)
            {

            }

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(folderName))
            {
                MessageBox.Show("Directorio no seleccionado", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string cmd = "rake run:android:rhosimulator";

                ProcessStartInfo pStartInfo = new ProcessStartInfo();
                pStartInfo.WorkingDirectory = folderName;
                pStartInfo.FileName = "CMD";
                //pStartInfo.Arguments = args;
                pStartInfo.WindowStyle = ProcessWindowStyle.Normal;
                pStartInfo.RedirectStandardInput = true;
                pStartInfo.UseShellExecute = false;
                var process = Process.Start(pStartInfo);
                process.StandardInput.WriteLine(cmd);
            }
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            string appName = "RhoSimulator";
            foreach (var process in Process.GetProcessesByName(appName))
            {
                process.Kill();
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                using (StreamWriter outfile = new StreamWriter(configFileName))
                {
                    outfile.Write(folderName);
                }
            }
        }
    }
}
