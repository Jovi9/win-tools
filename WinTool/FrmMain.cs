using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinTool.Forms.Driver;

namespace WinTool
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnExportDrivers_Click(object sender, EventArgs e)
        {
            FrmExportDriver frmExportDriver = new FrmExportDriver();
            frmExportDriver.ShowDialog();
        }

        private void BtnInstallDrivers_Click(object sender, EventArgs e)
        {
            FrmInstallDriver frmInstallDriver = new FrmInstallDriver();
            frmInstallDriver.ShowDialog();
        }
    }
}
