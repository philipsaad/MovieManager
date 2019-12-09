namespace MovieManager.WF
{
  partial class mediaManagerForm
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
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mediaFileListView = new System.Windows.Forms.ListView();
      this.fileNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.fileSizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.mediaQualityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.videoCodecHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.audioCodecHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.videoResolutionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.fileHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.fileLoadProgressBar = new System.Windows.Forms.ToolStripProgressBar();
      this.fileLoadStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openLocationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.mainMenuStrip.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.contextMenuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // mainMenuStrip
      // 
      this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
      this.mainMenuStrip.Name = "mainMenuStrip";
      this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
      this.mainMenuStrip.Size = new System.Drawing.Size(1200, 25);
      this.mainMenuStrip.TabIndex = 0;
      this.mainMenuStrip.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
      this.openToolStripMenuItem.Text = "Open";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
      this.optionsToolStripMenuItem.Text = "Options";
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // mediaFileListView
      // 
      this.mediaFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameHeader,
            this.fileSizeHeader,
            this.mediaQualityHeader,
            this.videoCodecHeader,
            this.audioCodecHeader,
            this.videoResolutionHeader,
            this.fileHeader});
      this.mediaFileListView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mediaFileListView.FullRowSelect = true;
      this.mediaFileListView.GridLines = true;
      this.mediaFileListView.HideSelection = false;
      this.mediaFileListView.LabelWrap = false;
      this.mediaFileListView.Location = new System.Drawing.Point(0, 25);
      this.mediaFileListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.mediaFileListView.MultiSelect = false;
      this.mediaFileListView.Name = "mediaFileListView";
      this.mediaFileListView.Size = new System.Drawing.Size(1200, 702);
      this.mediaFileListView.TabIndex = 1;
      this.mediaFileListView.UseCompatibleStateImageBehavior = false;
      this.mediaFileListView.View = System.Windows.Forms.View.Details;
      this.mediaFileListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mediaFileListView_MouseClick);
      // 
      // fileNameHeader
      // 
      this.fileNameHeader.Text = "File Name";
      this.fileNameHeader.Width = 500;
      // 
      // fileSizeHeader
      // 
      this.fileSizeHeader.Text = "File Size";
      this.fileSizeHeader.Width = 100;
      // 
      // mediaQualityHeader
      // 
      this.mediaQualityHeader.Text = "Quality";
      this.mediaQualityHeader.Width = 80;
      // 
      // videoCodecHeader
      // 
      this.videoCodecHeader.Text = "Video Codec";
      // 
      // audioCodecHeader
      // 
      this.audioCodecHeader.Text = "Audio Codec";
      // 
      // videoResolutionHeader
      // 
      this.videoResolutionHeader.Text = "Resolution";
      // 
      // fileHeader
      // 
      this.fileHeader.Text = "";
      this.fileHeader.Width = 0;
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileLoadProgressBar,
            this.fileLoadStatusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 705);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
      this.statusStrip.Size = new System.Drawing.Size(1200, 22);
      this.statusStrip.TabIndex = 2;
      this.statusStrip.Text = "statusStrip1";
      // 
      // fileLoadProgressBar
      // 
      this.fileLoadProgressBar.Name = "fileLoadProgressBar";
      this.fileLoadProgressBar.Size = new System.Drawing.Size(667, 23);
      this.fileLoadProgressBar.Step = 1;
      this.fileLoadProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.fileLoadProgressBar.Visible = false;
      // 
      // fileLoadStatusLabel
      // 
      this.fileLoadStatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.fileLoadStatusLabel.Name = "fileLoadStatusLabel";
      this.fileLoadStatusLabel.Size = new System.Drawing.Size(0, 17);
      // 
      // contextMenuStrip
      // 
      this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
      this.contextMenuStrip.Name = "contextMenuStrip";
      this.contextMenuStrip.Size = new System.Drawing.Size(93, 26);
      // 
      // fileToolStripMenuItem1
      // 
      this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenuItem,
            this.openLocationMenuItem});
      this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
      this.fileToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
      this.fileToolStripMenuItem1.Text = "File";
      // 
      // openFileMenuItem
      // 
      this.openFileMenuItem.Name = "openFileMenuItem";
      this.openFileMenuItem.Size = new System.Drawing.Size(213, 22);
      this.openFileMenuItem.Text = "Open File in Default Player";
      this.openFileMenuItem.Click += new System.EventHandler(this.openFileMenuItem_Click);
      // 
      // openLocationMenuItem
      // 
      this.openLocationMenuItem.Name = "openLocationMenuItem";
      this.openLocationMenuItem.Size = new System.Drawing.Size(213, 22);
      this.openLocationMenuItem.Text = "Open File Location";
      this.openLocationMenuItem.Click += new System.EventHandler(this.openLocationMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
      // 
      // mediaManagerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1200, 727);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.mediaFileListView);
      this.Controls.Add(this.mainMenuStrip);
      this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.mainMenuStrip;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "mediaManagerForm";
      this.ShowIcon = false;
      this.Text = "Media Manager";
      this.mainMenuStrip.ResumeLayout(false);
      this.mainMenuStrip.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.contextMenuStrip.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip mainMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ListView mediaFileListView;
    private System.Windows.Forms.ColumnHeader fileNameHeader;
    private System.Windows.Forms.ColumnHeader fileSizeHeader;
    private System.Windows.Forms.ColumnHeader mediaQualityHeader;
    private System.Windows.Forms.ColumnHeader videoCodecHeader;
    private System.Windows.Forms.ColumnHeader audioCodecHeader;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripProgressBar fileLoadProgressBar;
    private System.Windows.Forms.ToolStripStatusLabel fileLoadStatusLabel;
    private System.Windows.Forms.ColumnHeader videoResolutionHeader;
    private System.Windows.Forms.ColumnHeader fileHeader;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem openLocationMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
  }
}

