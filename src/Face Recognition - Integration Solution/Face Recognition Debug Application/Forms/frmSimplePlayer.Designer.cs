﻿namespace Face_Recognition_Debug_Application
{
    partial class frmSimplePlayer
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
            this.components = new System.ComponentModel.Container();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localVideoCaptureDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVideofileusingDirectShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openJPEGURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMJPEGURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capture1stDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takePictureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.savePictureToDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendPictureToAPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getNewImageFromUSBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAndProcessImageFromFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.fpsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ImageType = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSLErrors = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.videoSourcePlayer = new Accord.Controls.VideoSourcePlayer();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tmrNotifications = new System.Windows.Forms.Timer(this.components);
            this.ofdLoadExsitingImage = new System.Windows.Forms.OpenFileDialog();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.takePictureToolStripMenuItem,
            this.getStatsToolStripMenuItem,
            this.viewDataToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(434, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localVideoCaptureDeviceToolStripMenuItem,
            this.openVideofileusingDirectShowToolStripMenuItem,
            this.openJPEGURLToolStripMenuItem,
            this.openMJPEGURLToolStripMenuItem,
            this.capture1stDisplayToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // localVideoCaptureDeviceToolStripMenuItem
            // 
            this.localVideoCaptureDeviceToolStripMenuItem.Name = "localVideoCaptureDeviceToolStripMenuItem";
            this.localVideoCaptureDeviceToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.localVideoCaptureDeviceToolStripMenuItem.Text = "Local &Video Capture Device";
            this.localVideoCaptureDeviceToolStripMenuItem.Click += new System.EventHandler(this.localVideoCaptureDeviceToolStripMenuItem_Click);
            // 
            // openVideofileusingDirectShowToolStripMenuItem
            // 
            this.openVideofileusingDirectShowToolStripMenuItem.Name = "openVideofileusingDirectShowToolStripMenuItem";
            this.openVideofileusingDirectShowToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.openVideofileusingDirectShowToolStripMenuItem.Text = "Open video &file (using DirectShow)";
            this.openVideofileusingDirectShowToolStripMenuItem.Click += new System.EventHandler(this.openVideofileusingDirectShowToolStripMenuItem_Click);
            // 
            // openJPEGURLToolStripMenuItem
            // 
            this.openJPEGURLToolStripMenuItem.Name = "openJPEGURLToolStripMenuItem";
            this.openJPEGURLToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.openJPEGURLToolStripMenuItem.Text = "Open JPEG &URL";
            this.openJPEGURLToolStripMenuItem.Click += new System.EventHandler(this.openJPEGURLToolStripMenuItem_Click);
            // 
            // openMJPEGURLToolStripMenuItem
            // 
            this.openMJPEGURLToolStripMenuItem.Name = "openMJPEGURLToolStripMenuItem";
            this.openMJPEGURLToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.openMJPEGURLToolStripMenuItem.Text = "Open &MJPEG URL";
            this.openMJPEGURLToolStripMenuItem.Click += new System.EventHandler(this.openMJPEGURLToolStripMenuItem_Click);
            // 
            // capture1stDisplayToolStripMenuItem
            // 
            this.capture1stDisplayToolStripMenuItem.Name = "capture1stDisplayToolStripMenuItem";
            this.capture1stDisplayToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.capture1stDisplayToolStripMenuItem.Text = "Capture 1st display";
            this.capture1stDisplayToolStripMenuItem.Click += new System.EventHandler(this.capture1stDisplayToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(254, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // takePictureToolStripMenuItem
            // 
            this.takePictureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takePictureToolStripMenuItem1,
            this.savePictureToDBToolStripMenuItem,
            this.sendPictureToAPIToolStripMenuItem});
            this.takePictureToolStripMenuItem.Name = "takePictureToolStripMenuItem";
            this.takePictureToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.takePictureToolStripMenuItem.Text = "Take Picture";
            // 
            // takePictureToolStripMenuItem1
            // 
            this.takePictureToolStripMenuItem1.Name = "takePictureToolStripMenuItem1";
            this.takePictureToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.takePictureToolStripMenuItem1.Text = "Take Picture";
            this.takePictureToolStripMenuItem1.Click += new System.EventHandler(this.takePictureToolStripMenuItem1_Click);
            // 
            // savePictureToDBToolStripMenuItem
            // 
            this.savePictureToDBToolStripMenuItem.Name = "savePictureToDBToolStripMenuItem";
            this.savePictureToDBToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.savePictureToDBToolStripMenuItem.Text = "Save Picture to DB";
            this.savePictureToDBToolStripMenuItem.Click += new System.EventHandler(this.savePictureToDBToolStripMenuItem_Click);
            // 
            // sendPictureToAPIToolStripMenuItem
            // 
            this.sendPictureToAPIToolStripMenuItem.Name = "sendPictureToAPIToolStripMenuItem";
            this.sendPictureToAPIToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sendPictureToAPIToolStripMenuItem.Text = "Send Picture to API";
            this.sendPictureToAPIToolStripMenuItem.Click += new System.EventHandler(this.sendPictureToAPIToolStripMenuItem_Click);
            // 
            // getStatsToolStripMenuItem
            // 
            this.getStatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getNewImageFromUSBToolStripMenuItem,
            this.loadAndProcessImageFromFSToolStripMenuItem});
            this.getStatsToolStripMenuItem.Name = "getStatsToolStripMenuItem";
            this.getStatsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.getStatsToolStripMenuItem.Text = "Process Images";
            this.getStatsToolStripMenuItem.Click += new System.EventHandler(this.getStatsToolStripMenuItem_Click);
            // 
            // getNewImageFromUSBToolStripMenuItem
            // 
            this.getNewImageFromUSBToolStripMenuItem.Name = "getNewImageFromUSBToolStripMenuItem";
            this.getNewImageFromUSBToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.getNewImageFromUSBToolStripMenuItem.Text = "Get New Image From USB";
            this.getNewImageFromUSBToolStripMenuItem.Click += new System.EventHandler(this.getNewImageFromUSBToolStripMenuItem_Click);
            // 
            // loadAndProcessImageFromFSToolStripMenuItem
            // 
            this.loadAndProcessImageFromFSToolStripMenuItem.Name = "loadAndProcessImageFromFSToolStripMenuItem";
            this.loadAndProcessImageFromFSToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.loadAndProcessImageFromFSToolStripMenuItem.Text = "Load and Process Image From FS";
            this.loadAndProcessImageFromFSToolStripMenuItem.Click += new System.EventHandler(this.loadAndProcessImageFromFSToolStripMenuItem_Click);
            // 
            // viewDataToolStripMenuItem
            // 
            this.viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            this.viewDataToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.viewDataToolStripMenuItem.Text = "ViewData";
            this.viewDataToolStripMenuItem.Click += new System.EventHandler(this.viewDataToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fpsLabel,
            this.ImageType,
            this.tsSLErrors});
            this.statusStrip.Location = new System.Drawing.Point(0, 341);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(434, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // fpsLabel
            // 
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(419, 17);
            this.fpsLabel.Spring = true;
            this.fpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImageType
            // 
            this.ImageType.Name = "ImageType";
            this.ImageType.Size = new System.Drawing.Size(0, 17);
            // 
            // tsSLErrors
            // 
            this.tsSLErrors.Name = "tsSLErrors";
            this.tsSLErrors.Size = new System.Drawing.Size(0, 17);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.videoSourcePlayer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(434, 317);
            this.mainPanel.TabIndex = 2;
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.AutoSizeControl = true;
            this.videoSourcePlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoSourcePlayer.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer.Location = new System.Drawing.Point(56, 37);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(322, 242);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.NewFrame += new Accord.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer_NewFrame);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "AVI files (*.avi)|*.avi|All files (*.*)|*.*";
            this.openFileDialog.Title = "Opem movie";
            // 
            // tmrNotifications
            // 
            this.tmrNotifications.Interval = 10000;
            this.tmrNotifications.Tick += new System.EventHandler(this.tmrNotifications_Tick);
            // 
            // ofdLoadExsitingImage
            // 
            this.ofdLoadExsitingImage.InitialDirectory = "W:\\Example Pictures\\";
            this.ofdLoadExsitingImage.Title = "Load Image of faces for processing";
            // 
            // frmSimplePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(434, 363);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "frmSimplePlayer";
            this.Text = "Simple Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion



        private System.Windows.Forms.MenuStrip mainMenuStrip;

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

        private System.Windows.Forms.StatusStrip statusStrip;

        private System.Windows.Forms.Panel mainPanel;

        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem localVideoCaptureDeviceToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;

        private Accord.Controls.VideoSourcePlayer videoSourcePlayer;

        private System.Windows.Forms.Timer timer;

        private System.Windows.Forms.ToolStripStatusLabel fpsLabel;

        private System.Windows.Forms.ToolStripMenuItem openVideofileusingDirectShowToolStripMenuItem;

        private System.Windows.Forms.OpenFileDialog openFileDialog;

        private System.Windows.Forms.ToolStripMenuItem openJPEGURLToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem openMJPEGURLToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem capture1stDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takePictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel ImageType;
        private System.Windows.Forms.ToolStripMenuItem takePictureToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem savePictureToDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendPictureToAPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsSLErrors;
        private System.Windows.Forms.Timer tmrNotifications;
        private System.Windows.Forms.ToolStripMenuItem viewDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getNewImageFromUSBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAndProcessImageFromFSToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdLoadExsitingImage;
    }
}
