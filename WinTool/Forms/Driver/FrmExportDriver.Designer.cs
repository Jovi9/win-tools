
namespace WinTool.Forms.Driver
{
    partial class FrmExportDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExportDriver));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.PanelRight = new System.Windows.Forms.Panel();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.PanelExport = new System.Windows.Forms.Panel();
            this.BtnBrowseFolder = new System.Windows.Forms.Button();
            this.BtnExportDriver = new System.Windows.Forms.Button();
            this.TxtDestination = new System.Windows.Forms.TextBox();
            this.LblExportTitle = new System.Windows.Forms.Label();
            this.PanelResult = new System.Windows.Forms.Panel();
            this.TxtExportResult = new System.Windows.Forms.TextBox();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.PanelExport.SuspendLayout();
            this.PanelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(10, 487);
            this.PanelLeft.TabIndex = 0;
            // 
            // PanelRight
            // 
            this.PanelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.PanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelRight.Location = new System.Drawing.Point(863, 0);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(10, 487);
            this.PanelRight.TabIndex = 1;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(10, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(853, 10);
            this.PanelTop.TabIndex = 2;
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(10, 477);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(853, 10);
            this.PanelBottom.TabIndex = 3;
            // 
            // PanelExport
            // 
            this.PanelExport.BackColor = System.Drawing.Color.DarkGray;
            this.PanelExport.Controls.Add(this.BtnBrowseFolder);
            this.PanelExport.Controls.Add(this.BtnExportDriver);
            this.PanelExport.Controls.Add(this.TxtDestination);
            this.PanelExport.Controls.Add(this.LblExportTitle);
            this.PanelExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelExport.Location = new System.Drawing.Point(10, 10);
            this.PanelExport.Name = "PanelExport";
            this.PanelExport.Size = new System.Drawing.Size(853, 90);
            this.PanelExport.TabIndex = 4;
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
            // BtnExportDriver
            // 
            this.BtnExportDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.BtnExportDriver.FlatAppearance.BorderSize = 0;
            this.BtnExportDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportDriver.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnExportDriver.Location = new System.Drawing.Point(658, 12);
            this.BtnExportDriver.Name = "BtnExportDriver";
            this.BtnExportDriver.Size = new System.Drawing.Size(189, 35);
            this.BtnExportDriver.TabIndex = 2;
            this.BtnExportDriver.TabStop = false;
            this.BtnExportDriver.Text = "Export Driver";
            this.BtnExportDriver.UseVisualStyleBackColor = false;
            this.BtnExportDriver.Click += new System.EventHandler(this.BtnExportDriver_Click);
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
            // LblExportTitle
            // 
            this.LblExportTitle.AutoSize = true;
            this.LblExportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExportTitle.Location = new System.Drawing.Point(6, 12);
            this.LblExportTitle.Name = "LblExportTitle";
            this.LblExportTitle.Size = new System.Drawing.Size(338, 29);
            this.LblExportTitle.TabIndex = 0;
            this.LblExportTitle.Text = "Choose Export Destination";
            // 
            // PanelResult
            // 
            this.PanelResult.BackColor = System.Drawing.Color.Silver;
            this.PanelResult.Controls.Add(this.TxtExportResult);
            this.PanelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelResult.Location = new System.Drawing.Point(10, 100);
            this.PanelResult.Name = "PanelResult";
            this.PanelResult.Padding = new System.Windows.Forms.Padding(10);
            this.PanelResult.Size = new System.Drawing.Size(853, 377);
            this.PanelResult.TabIndex = 5;
            // 
            // TxtExportResult
            // 
            this.TxtExportResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtExportResult.Location = new System.Drawing.Point(10, 10);
            this.TxtExportResult.Multiline = true;
            this.TxtExportResult.Name = "TxtExportResult";
            this.TxtExportResult.ReadOnly = true;
            this.TxtExportResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtExportResult.Size = new System.Drawing.Size(833, 357);
            this.TxtExportResult.TabIndex = 0;
            this.TxtExportResult.TabStop = false;
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // FrmExportDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(873, 487);
            this.Controls.Add(this.PanelResult);
            this.Controls.Add(this.PanelExport);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelRight);
            this.Controls.Add(this.PanelLeft);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(891, 534);
            this.MinimumSize = new System.Drawing.Size(891, 534);
            this.Name = "FrmExportDriver";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Driver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmExportDriver_FormClosing);
            this.Load += new System.EventHandler(this.FrmExportDriver_Load);
            this.PanelExport.ResumeLayout(false);
            this.PanelExport.PerformLayout();
            this.PanelResult.ResumeLayout(false);
            this.PanelResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelRight;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Panel PanelExport;
        private System.Windows.Forms.Panel PanelResult;
        private System.Windows.Forms.Label LblExportTitle;
        private System.Windows.Forms.TextBox TxtDestination;
        private System.Windows.Forms.Button BtnExportDriver;
        private System.Windows.Forms.Button BtnBrowseFolder;
        private System.Windows.Forms.TextBox TxtExportResult;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
    }
}