using ByteSizeLib;
using MediaInfo;
using MovieManager.Lib.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MovieManager.Lib
{
  public static class ProcessFiles
  {
    internal static readonly HashSet<string> validExtensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { ".avi", ".bdmv", ".mpg", ".mpeg", ".mp4", ".divx", ".ogm", ".mkv", ".wmv", ".qt", ".rm", ".mov", ".movie", ".mts", ".m2ts", ".sbe", ".dvr-ms", ".ts", ".dat", ".ifo", ".flv", ".m4v", ".3gp", ".wtv", ".ogv", ".mk3d", ".mpls", ".mpe", ".m1v", ".m2v", ".iflv", ".3gpp", ".mpv4", ".hdmov", ".mp4v" };
    internal static MediaInfoWrapper mediaInfoWrapper;

    private static IEnumerable<FileInfo> mediaFiles(string Path)
    {
      foreach (FileInfo FileInfo in new DirectoryInfo(Path).EnumerateFiles("*", SearchOption.AllDirectories).Where(file => validExtensions.Contains(file.Extension)))
      {
        yield return FileInfo;
      }
    }

    public static int MediaFileCount(string Path)
    {
      return new DirectoryInfo(Path).EnumerateFiles("*", SearchOption.AllDirectories).Where(file => validExtensions.Contains(file.Extension)).Count();
    }

    public static IEnumerable<MediaFile> Load(string Path)
    {
      foreach (FileInfo mediaFile in mediaFiles(Path))
      {
        mediaInfoWrapper = new MediaInfoWrapper(mediaFile.FullName);

        yield return new MediaFile()
        {
          AudioCodec = mediaInfoWrapper.AudioCodec,
          AudioBitrate = mediaInfoWrapper.AudioRate,
          AudioChannels = mediaInfoWrapper.AudioChannelsFriendly,
          VideoCodec = mediaInfoWrapper.BestVideoStream.Format,
          VideoBitrate = mediaInfoWrapper.VideoRate,
          VideoFramerate = mediaInfoWrapper.Framerate,
          VideoResolution = new VideoResolution()
          {
            Width = mediaInfoWrapper.BestVideoStream.Width,
            Height = mediaInfoWrapper.BestVideoStream.Height,
            FormattedResolution = mediaInfoWrapper.VideoResolution
          },
          Is3D = mediaInfoWrapper.Is3D,
          IsBluRay = mediaInfoWrapper.IsBluRay,
          IsDvd = mediaInfoWrapper.IsDvd,
          IsHdr = mediaInfoWrapper.IsHdr,
          FileName = mediaFile,
          FileSize = mediaFile.Length,
          TotalBitrate = (mediaInfoWrapper.AudioRate + mediaInfoWrapper.VideoRate),
          Duration = mediaInfoWrapper.BestVideoStream.Duration,
        };
      }
    }
  }
}
