using System.Collections.Generic;
using System.IO;
using MyPhotos.Properties;

namespace MyPhotos.Utils
{
    internal class Format
    {
        public static bool IsImage(string path)
        {
            return _imagesFormats.Contains(Path.GetExtension(path));
        }

        public static bool IsVideo(string path)
        {
            return _videoFormats.Contains(Path.GetExtension(path));
        }

        static Format()
        {

            _imagesFormats = new List<string>() {".gif ", ".jpeg", ".jpg", ".png"};
            _videoFormats = new List<string>()
                {".3g2", ".3gp", ".avi", "flv", ".h264", ".mv4", ".mp4", ".mpg", ".mpeg", ".wmv"};
        }

        public static IList<string> _imagesFormats;
        public static IList<string> _videoFormats;
    }
}