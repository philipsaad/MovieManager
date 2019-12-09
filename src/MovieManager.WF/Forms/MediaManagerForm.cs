using ByteSizeLib;
using Microsoft.WindowsAPICodePack.Dialogs;
using MovieManager.Lib;
using MovieManager.Lib.Classes;
using MovieManager.WF.Classes;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManager.WF
{
  public partial class mediaManagerForm : Form
  {
    private readonly SynchronizationContext synchronizationContext;
    private int totalFileCount;

    public mediaManagerForm()
    {
      InitializeComponent();
      synchronizationContext = SynchronizationContext.Current;

      //Enable double buffering on listview
      mediaFileListView.DoubleBuffer();
    }

    private async void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CommonOpenFileDialog openFolder = new CommonOpenFileDialog
      {
        AllowNonFileSystemItems = false,
        Multiselect = false,
        IsFolderPicker = true
      };

      if (openFolder.ShowDialog() != CommonFileDialogResult.Ok)
      {
        return;
      }

      string folderPath = openFolder.FileName;
      if (Directory.Exists(folderPath))
      {
        if (mediaFileListView.Items.Count > 0)
        {
          mediaFileListView.Items.Clear();
        }

        fileLoadProgressBar.Visible = true;

        WaitingForm x = new WaitingForm();
        x.Show();
        totalFileCount = await Task.Run(() => ProcessFiles.MediaFileCount(folderPath));
        x.Hide();
        
        fileLoadProgressBar.Maximum = totalFileCount;
        fileLoadStatusLabel.Text = $"0.00%";
        await Task.Run(() => LoadFiles(folderPath));
      }
    }

    private void LoadFiles(string folderPath)
    {
      int currentFileIndex = 0;

      foreach (MediaFile mediaFile in ProcessFiles.Load(folderPath))
      {
        ListViewItem listViewItem = new ListViewItem(mediaFile.FileName.Name);
        listViewItem.SubItems.Add(ByteSize.FromBytes(mediaFile.FileName.Length).ToString());
        listViewItem.SubItems.Add(mediaFile.MediaQuality);
        listViewItem.SubItems.Add(mediaFile.VideoCodec);
        listViewItem.SubItems.Add(mediaFile.AudioCodec);
        listViewItem.SubItems.Add(mediaFile.VideoResolution.ToString());
        listViewItem.SubItems.Add(mediaFile.FileName.FullName);

        synchronizationContext.Post(new SendOrPostCallback(o =>
        {
          mediaFileListView.Items.Add(listViewItem);
          currentFileIndex++;

          double progress = (double)currentFileIndex / (double)totalFileCount;
          fileLoadProgressBar.PerformStepNoAnimation(currentFileIndex);
          fileLoadStatusLabel.Text = String.Format("{0:P2}", progress);

        }), listViewItem);
      }
    }

    private void mediaFileListView_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        if (mediaFileListView.FocusedItem.Bounds.Contains(e.Location))
        {
          contextMenuStrip.Show(Cursor.Position);
        }
      }
    }

    private void openFileMenuItem_Click(object sender, EventArgs e)
    {
      string fileName = mediaFileListView.SelectedItems[0].SubItems[6].Text;
      Process.Start(fileName);
    }

    private void openLocationMenuItem_Click(object sender, EventArgs e)
    {
      string fileName = mediaFileListView.SelectedItems[0].SubItems[6].Text;
      Process.Start(new FileInfo(fileName).Directory.FullName);
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _ = new AboutForm().ShowDialog();
    }

    }
}
