using System.Reflection;
using System.Windows.Forms;

namespace MovieManager.WF.Classes
{
  public static class ExtensionMethods
  {
    public static void DoubleBuffer(this Control control)
    {
      // http://stackoverflow.com/questions/76993/how-to-double-buffer-net-controls-on-a-form/77233#77233
      // Taxes: Remote Desktop Connection and painting: http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx
      if (System.Windows.Forms.SystemInformation.TerminalServerSession)
      {
        return;
      }

      PropertyInfo dbProp = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
      dbProp.SetValue(control, true, null);
    }
    public static void PerformStepNoAnimation(this ToolStripProgressBar pb, int value)
    {
      //https://stackoverflow.com/a/22941217
      
      // To get around the progressive animation, we need to move the 
      // progress bar backwards.
      if (value == pb.Maximum)
      {
        // Special case as value can't be set greater than Maximum.
        pb.Maximum = value + 1;     // Temporarily Increase Maximum
        pb.Value = value + 1;       // Move past
        pb.Maximum = value;         // Reset maximum
      }
      else
      {
        pb.Value = value + 1;       // Move past
        pb.Value = value;               // Move to correct value
      }
    }
  }
}
