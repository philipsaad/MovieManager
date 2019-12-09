using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using ByteSizeLib;

using Microsoft.WindowsAPICodePack.Dialogs;

using MovieManager.Lib;
using MovieManager.Lib.Classes;
using MovieManager.WF.Classes;

namespace MovieManager.WF
{
  public partial class mediaManagerForm : Form
  {
    /// <summary>
    /// Allows us to propagate UI changes accross threads.
    /// </summary>
    private readonly SynchronizationContext synchronizationContext;

    /// <summary>
    /// 
    /// </summary>
    public int totalFileCount { get; set; }

    public mediaManagerForm()
    {
      InitializeComponent();

      //Enable double buffering on all controls on this form
      this.Controls.OfType<Control>().ToList().ForEach(t => t.DoubleBuffer());

      //Set the SynchronizationContext to the current thread.
      synchronizationContext = SynchronizationContext.Current;
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

      if (mediaFileListView.Items.Count > 0)
      {
        mediaFileListView.Items.Clear();
      }

      fileLoadProgressBar.Visible = true;
      fileLoadStatusLabel.Visible = true;

      totalFileCount = await Task.Run(() => ProcessFiles.MediaFileCount(openFolder.FileName));

      fileLoadProgressBar.Maximum = totalFileCount;
      fileLoadStatusLabel.Text = $"0.00%";

      await Task.Run(() =>
      {
        LoadFiles(openFolder.FileName);
        HideProgressWithTimeout(1000);
      });
    }

    private void LoadFiles(string folderPath)
    {
      if (folderPath is null)
      {
        throw new ArgumentNullException(nameof(folderPath));
      }

      int currentFileIndex = 0;
      foreach (MediaFile mediaFile in ProcessFiles.Load(folderPath))
      {
        ListViewItem listViewItem = new ListViewItem(mediaFile.FileName.Name);
        listViewItem.SubItems.Add(ByteSize.FromBytes(mediaFile.FileName.Length).ToString());
        listViewItem.SubItems.Add(mediaFile.MediaQuality);
        listViewItem.SubItems.Add(mediaFile.VideoCodec);
        listViewItem.SubItems.Add(mediaFile.AudioCodec);
        listViewItem.SubItems.Add(mediaFile.VideoResolution.Dimensions);
        listViewItem.SubItems.Add(mediaFile.VideoResolution.AspectRatio);
        listViewItem.SubItems.Add(mediaFile.FileName.FullName);

        synchronizationContext.Post(new SendOrPostCallback(o =>
        {
          //Add the ListViewItem to our ListView
          mediaFileListView.Items.Add(listViewItem);

          //Increment our current file index
          currentFileIndex++;

          //Update our progress bar and percentage label
          fileLoadProgressBar.PerformStepNoAnimation(currentFileIndex);
          fileLoadStatusLabel.Text = string.Format("{0:P2}", currentFileIndex / (double)totalFileCount);
        }), null);
      }
    }

    private void HideProgressWithTimeout(int timeout)
    {
      Thread.Sleep(timeout);

      synchronizationContext.Post(new SendOrPostCallback(o =>
      {
        fileLoadProgressBar.Visible = false;
        fileLoadStatusLabel.Visible = false;
      }), null);
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
      string fileName = mediaFileListView
                        .SelectedItems[0]
                        .SubItems
                        .Cast<ListViewItem.ListViewSubItem>()
                        .Last().Text;

      Process.Start(fileName);
    }

    private void openLocationMenuItem_Click(object sender, EventArgs e)
    {
      string fileName = mediaFileListView
                        .SelectedItems[0]
                        .SubItems
                        .Cast<ListViewItem.ListViewSubItem>()
                        .Last().Text;

      Process.Start(new FileInfo(fileName).Directory.FullName);
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _ = new AboutForm().ShowDialog();
    }
  }
}
