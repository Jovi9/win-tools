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
    public partial class FrmExportDriver : Form
    {
        private Process process;

        public FrmExportDriver()
        {
            InitializeComponent();
        }

        private void FrmExportDriver_Load(object sender, EventArgs e)
        {
            TxtExportResult.Select();
            TxtExportResult.Clear();
            TxtDestination.Clear();
        }

        private void BtnBrowseFolder_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                TxtDestination.Text = FolderBrowser.SelectedPath;
            }
        }

        private void BtnExportDriver_Click(object sender, EventArgs e)
        {
            if (TxtDestination.Text.Trim() == "")
            {
                MessageBox.Show("Please choose destination folder.", "Export Driver", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ExportDriver();
            }
        }

        private void ExportDriver()
        {
            TxtExportResult.Clear();
            ProcessStartInfo processStartInfo = new ProcessStartInfo("dism.exe")
            {
                Verb = "runas",
                Arguments = "/online /export-driver /destination:" + "\"" + TxtDestination.Text + "\"",
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
                    TxtExportResult.Invoke((MethodInvoker)(() => TxtExportResult.AppendText(e.Data + Environment.NewLine)));
                }
            };
            process.OutputDataReceived += (o, e) =>
            {
                if (IsHandleCreated)
                {
                    TxtExportResult.Invoke((MethodInvoker)(() => TxtExportResult.AppendText(e.Data + Environment.NewLine)));
                }
            };

            process.Start();

            process.BeginErrorReadLine();
            process.BeginOutputReadLine();

        }

        private void FrmExportDriver_FormClosing(object sender, FormClosingEventArgs e)
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
