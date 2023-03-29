using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTool.Forms.Driver
{
    public partial class FrmInstallDriver : Form
    {
        private Process process;

        public FrmInstallDriver()
        {
            InitializeComponent();
        }

        private void FrmInstallDriver_Load(object sender, EventArgs e)
        {
            TxtResult.Select();
            TxtResult.Clear();
            TxtDestination.Clear();
        }

        private void BtnBrowseFolder_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                TxtDestination.Text = FolderBrowser.SelectedPath;
            }
        }

        private void BtnInstallDriver_Click(object sender, EventArgs e)
        {
            if (TxtDestination.Text.Trim() == "")
            {
                MessageBox.Show("Please choose destination folder.", "Install Driver", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InstallDriver();
            }
        }

        private void InstallDriver()
        {
            TxtResult.Clear();
            ProcessStartInfo processStartInfo = new ProcessStartInfo("pnputil.exe")
            {
                Verb = "runas",
                Arguments = "/add-driver " + "\"" + TxtDestination.Text + "\"" + "\\*.inf /subdirs /install",
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            process = new Process()
            {
                StartInfo = processStartInfo,
                EnableRaisingEvents = true,
            };

            process.ErrorDataReceived += (o, e) =>
            {
                if (IsHandleCreated)
                {
                    TxtResult.Invoke((MethodInvoker)(() => TxtResult.AppendText(e.Data + Environment.NewLine)));
                }
            };
            process.OutputDataReceived += (o, e) =>
            {
                if (IsHandleCreated)
                {
                    TxtResult.Invoke((MethodInvoker)(() => TxtResult.AppendText(e.Data + Environment.NewLine)));
                }
            };

            process.Start();

            process.BeginErrorReadLine();
            process.BeginOutputReadLine();

        }

        private void FrmInstallDriver_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (process != null)
            {
                if (!(process.HasExited))
                {
                    process.Kill();
                }
            }
        }
    }
}
