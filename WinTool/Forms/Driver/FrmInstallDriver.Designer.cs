
namespace WinTool.Forms.Driver
{
    partial class FrmInstallDriver
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
            this.PanelInstall = new System.Windows.Forms.Panel();
            this.BtnBrowseFolder = new System.Windows.Forms.Button();
            this.BtnInstallDriver = new System.Windows.Forms.Button();
            this.TxtDestination = new System.Windows.Forms.TextBox();
            this.LblnstallDriver = new System.Windows.Forms.Label();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PanelRight = new System.Windows.Forms.Panel();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.PanelResult = new System.Windows.Forms.Panel();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.PanelInstall.SuspendLayout();
            this.PanelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelInstall
            // 
            this.PanelInstall.BackColor = System.Drawing.Color.DarkGray;
            this.PanelInstall.Controls.Add(this.BtnBrowseFolder);
            this.PanelInstall.Controls.Add(this.BtnInstallDriver);
            this.PanelInstall.Controls.Add(this.TxtDestination);
            this.PanelInstall.Controls.Add(this.LblnstallDriver);
            this.PanelInstall.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelInstall.Location = new System.Drawing.Point(10, 10);
            this.PanelInstall.Name = "PanelInstall";
            this.PanelInstall.Size = new System.Drawing.Size(853, 90);
            this.PanelInstall.TabIndex = 10;
            // 
            // BtnBrowseFolder
            // 
            this.BtnBrowseFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.BtnBrowseFolder.FlatAppearance.BorderSize = 0;
            this.BtnBrowseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowseFolder.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnBrowseFolder.Location = new System.Drawing.Point(463, 12);
            this.BtnBrowseFolder.Name = "BtnBrowseFolder";
            this.BtnBrowseFolder.Size = new System.Drawing.Size(189, 35);
            this.BtnBrowseFolder.TabIndex = 3;
            this.BtnBrowseFolder.TabStop = false;
            this.BtnBrowseFolder.Text = "Browse Folder";
            this.BtnBrowseFolder.UseVisualStyleBackColor = false;
            this.BtnBrowseFolder.Click += new System.EventHandler(this.BtnBrowseFolder_Click);
            // 
            // BtnInstallDriver
            // 
            this.BtnInstallDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.BtnInstallDriver.FlatAppearance.BorderSize = 0;
            this.BtnInstallDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInstallDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInstallDriver.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnInstallDriver.Location = new System.Drawing.Point(658, 12);
            this.BtnInstallDriver.Name = "BtnInstallDriver";
            this.BtnInstallDriver.Size = new System.Drawing.Size(189, 35);
            this.BtnInstallDriver.TabIndex = 2;
            this.BtnInstallDriver.TabStop = false;
            this.BtnInstallDriver.Text = "Install Driver";
            this.BtnInstallDriver.UseVisualStyleBackColor = false;
            this.BtnInstallDriver.Click += new System.EventHandler(this.BtnInstallDriver_Click);
            // 
            // TxtDestination
            // 
            this.TxtDestination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDestination.Location = new System.Drawing.Point(0, 58);
            this.TxtDestination.Name = "TxtDestination";
            this.TxtDestination.ReadOnly = true;
            this.TxtDestination.Size = new System.Drawing.Size(853, 32);
            this.TxtDestination.TabIndex = 1;
            this.TxtDestination.TabStop = false;
            // 
            // LblnstallDriver
            // 
            this.LblnstallDriver.AutoSize = true;
            this.LblnstallDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblnstallDriver.Location = new System.Drawing.Point(6, 12);
            this.LblnstallDriver.Name = "LblnstallDriver";
            this.LblnstallDriver.Size = new System.Drawing.Size(313, 29);
            this.LblnstallDriver.TabIndex = 0;
            this.LblnstallDriver.Text = "Choose Drivers Location";
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(10, 477);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(853, 10);
            this.PanelBottom.TabIndex = 9;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(10, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(853, 10);
            this.PanelTop.TabIndex = 8;
            // 
            // PanelRight
            // 
            this.PanelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.PanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelRight.Location = new System.Drawing.Point(863, 0);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(10, 487);
            this.PanelRight.TabIndex = 7;
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(10, 487);
            this.PanelLeft.TabIndex = 6;
            // 
            // PanelResult
            // 
            this.PanelResult.BackColor = System.Drawing.Color.Silver;
            this.PanelResult.Controls.Add(this.TxtResult);
            this.PanelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelResult.Location = new System.Drawing.Point(10, 100);
            this.PanelResult.Name = "PanelResult";
            this.PanelResult.Padding = new System.Windows.Forms.Padding(10);
            this.PanelResult.Size = new System.Drawing.Size(853, 377);
            this.PanelResult.TabIndex = 11;
            // 
            // TxtResult
            // 
            this.TxtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtResult.Location = new System.Drawing.Point(10, 10);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ReadOnly = true;
            this.TxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResult.Size = new System.Drawing.Size(833, 357);
            this.TxtResult.TabIndex = 0;
            this.TxtResult.TabStop = false;
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // FrmInstallDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 487);
            this.Controls.Add(this.PanelResult);
            this.Controls.Add(this.PanelInstall);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelRight);
            this.Controls.Add(this.PanelLeft);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(891, 534);
            this.MinimumSize = new System.Drawing.Size(891, 534);
            this.Name = "FrmInstallDriver";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install Driver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInstallDriver_FormClosing);
            this.Load += new System.EventHandler(this.FrmInstallDriver_Load);
            this.PanelInstall.ResumeLayout(false);
            this.PanelInstall.PerformLayout();
            this.PanelResult.ResumeLayout(false);
            this.PanelResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelInstall;
        private System.Windows.Forms.Button BtnBrowseFolder;
        private System.Windows.Forms.Button BtnInstallDriver;
        private System.Windows.Forms.TextBox TxtDestination;
        private System.Windows.Forms.Label LblnstallDriver;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelRight;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelResult;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
    }
}