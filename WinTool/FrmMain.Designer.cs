
namespace WinTool
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuDriver = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExportDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnInstallDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDriver});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(975, 36);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuDriver
            // 
            this.MenuDriver.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnExportDrivers,
            this.BtnInstallDrivers});
            this.MenuDriver.Name = "MenuDriver";
            this.MenuDriver.Size = new System.Drawing.Size(87, 32);
            this.MenuDriver.Text = "Drivers";
            // 
            // BtnExportDrivers
            // 
            this.BtnExportDrivers.Name = "BtnExportDrivers";
            this.BtnExportDrivers.Size = new System.Drawing.Size(224, 32);
            this.BtnExportDrivers.Text = "Export Drivers";
            this.BtnExportDrivers.Click += new System.EventHandler(this.BtnExportDrivers_Click);
            // 
            // BtnInstallDrivers
            // 
            this.BtnInstallDrivers.Name = "BtnInstallDrivers";
            this.BtnInstallDrivers.Size = new System.Drawing.Size(224, 32);
            this.BtnInstallDrivers.Text = "Install Drivers";
            this.BtnInstallDrivers.Click += new System.EventHandler(this.BtnInstallDrivers_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(975, 610);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Tool";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuDriver;
        private System.Windows.Forms.ToolStripMenuItem BtnExportDrivers;
        private System.Windows.Forms.ToolStripMenuItem BtnInstallDrivers;
    }
}

