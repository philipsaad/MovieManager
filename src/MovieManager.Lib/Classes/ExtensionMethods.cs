using MediaInfo.Model;
using System;

namespace MovieManager.Lib.Classes
{
  public static class ExtensionMethods
  {
    public static string GetMediaQuality(this MediaInfo.MediaInfoWrapper mediaInfoWrapper)
    {
      if (mediaInfoWrapper is null)
      {
        throw new ArgumentNullException(nameof(mediaInfoWrapper));
      }

      string mediaQuality = string.Empty;
      VideoStream videoStream = mediaInfoWrapper.BestVideoStream;

      if (videoStream.Width >= 3840 || videoStream.Height >= 2160)
      {
        mediaQuality += "4K";
      }
      else if (videoStream.Width >= 1280 || videoStream.Height >= 720)
      {
        mediaQuality += "HD";
      }
      else
      {
        mediaQuality += "SD";
      }

      mediaQuality += mediaInfoWrapper.IsHdr ? " HDR" : "";
      mediaQuality += mediaInfoWrapper.Is3D ? " 3D" : "";
      mediaQuality += mediaInfoWrapper.IsDvd ? " DVD" : "";
      mediaQuality += mediaInfoWrapper.IsBluRay ? " BluRay" : "";

      return mediaQuality;
    }
  }
}
