using MediaInfo.Model;
using System;
using System.IO;

namespace MovieManager.Lib.Classes
{
  public class MediaFile
  {
    //Audio properties
    public string AudioCodec { get; set; }
    public int AudioBitrate { get; set; }
    public string AudioChannels { get; set; }

    //Video properties
    public string VideoCodec { get; set; }
    public int VideoBitrate { get; set; }
    public double VideoFramerate { get; set; }
    public VideoResolution VideoResolution { get; set; }
    public bool IsHdr { get; set; }
    public bool Is3D { get; set; }
    public bool IsDvd { get; set; }
    public bool IsBluRay { get; set; }

    //Misc values
    public FileInfo FileName { get; set; }
    public long FileSize { get; set; }
    public int TotalBitrate { get; set; }
    public TimeSpan Duration { get; set; }
    public string MediaQuality
    {
      get
      {
        string mediaQuality = string.Empty;

        if (VideoResolution.FormattedResolution == "2160P")
          mediaQuality += "4K";
        else if (VideoResolution.FormattedResolution == "1080P" || VideoResolution.FormattedResolution == "720P")
          mediaQuality += "HD";
        else
          mediaQuality += "SD";

        mediaQuality += IsHdr ? " HDR" : "";
        mediaQuality += Is3D ? " 3D" : "";
        mediaQuality += IsDvd ? " DVD" : "";
        mediaQuality += IsBluRay ? " BluRay" : "";

        return mediaQuality;
      }

      set { }
    }
  }

  public class VideoResolution
  {
    public int Width { get; set; }
    public int Height { get; set; }
    public string FormattedResolution { get; set; }

    public override string ToString() {
      return $"{Width}×{Height}";
    }
  }
}
