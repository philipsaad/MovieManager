using System.Reflection;
using System.Windows.Forms;

namespace MovieManager.WF.Classes
{
  public static class ExtensionMethods
  {
    /// <summary>
    /// Easy extension method to toggle the hidden DoubleBuffered property on WinForm controls
    /// </summary>
    /// <remarks>
    /// How to double buffer .NET controls on a form?: https://stackoverflow.com/a/77233
    /// </remarks>
    /// <param name="control">The WinForm control to apply double buffering to</param>
    public static void DoubleBuffer(this Control control)
    {
      //Taxes: Remote Desktop Connection and painting: http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx
      //Do not enable double buffering if we are in a terminal server session
      if (!SystemInformation.TerminalServerSession)
      {
        PropertyInfo dbProp = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
        dbProp.SetValue(control, true, null);
      }
    }

    /// <summary>
    /// Sets the progress bar value, without using 'Windows Aero' animation.
    /// This is to work around a known WinForms issue where the progress bar 
    /// is slow to update. 
    /// </summary>
    /// <remarks>
    /// ProgressBar is slow in Windows Forms: https://stackoverflow.com/a/22941217
    /// </remarks>
    /// <param name="toolStripProgressBar">The ToolStripProgressBar control set the progress bar value to</param>
    /// <param name="value">Sets the current value of the System.Windows.Forms.ToolStripProgressBar.</param>
    public static void PerformStepNoAnimation(this ToolStripProgressBar toolStripProgressBar, int value)
    {
      //To get around the progressive animation, we need to move the progress bar backwards.
      if (value == toolStripProgressBar.Maximum)
      {
        toolStripProgressBar.Maximum = value + 1; //Temporarily Increase Maximum
        toolStripProgressBar.Value = value + 1; //Move past
        toolStripProgressBar.Maximum = value; //Reset maximum
      }
      else
      {
        toolStripProgressBar.Value = value + 1; //Move past
      }
     
      toolStripProgressBar.Value = value; //Move to correct value
    }
  }
}
