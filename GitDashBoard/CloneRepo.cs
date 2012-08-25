using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace GitDashBoard
{
    public partial class CloneRepo : Form
    {
        AutoResetEvent signal;
        private delegate void DelegateSetText(string data);
        public CloneRepo()
        {
            InitializeComponent();
        }

        private void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            signal = new AutoResetEvent(false); 
            Process p = new Process();
            p.StartInfo.FileName = @"C:\Git\bin\git.exe";
            p.StartInfo.Arguments = "clone git@github.com:sreeharip/GitSharp.git c:/testingrepo8637";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true; 
            p.StartInfo.CreateNoWindow = false;
            p.EnableRaisingEvents = true;
            p.OutputDataReceived += this.p_OutputDataReceived;
            p.ErrorDataReceived += this.p_ErrorDataReceived;
            
            
            
            p.Start();
            p.BeginOutputReadLine();
            while (true)
            {
                signal.WaitOne(); 
                
            }
            p.WaitForExit();
            //p.Close(); 
        }
        void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            string status = e.Data;
            SetText(status);
            signal.Set();
        }
        void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            string status = e.Data;
            SetText(status);
        }
        private void SetText(string text)
        {
            if (txtConsole.InvokeRequired)
            {
                DelegateSetText  method = new DelegateSetText(SetText); 
                this.Invoke(method, text);
            }
            else
            {
                txtConsole.Text += text+Environment.NewLine;
            }
        }
        private void bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Repo Cloning Complete !!");
            btnClone.Enabled = true;
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            bg.RunWorkerAsync();
            btnClone.Enabled = false; 
        }
    }
}
