using System.Drawing;

namespace MyPhotos.Utils
{
    internal class EditImage
    {
        public static Image ResizeImage(string path, Size newSize)
        {
            using var image = Image.FromFile(path);
            Image newImage = new Bitmap(newSize.Width, newSize.Height);
            using var gfx = Graphics.FromImage((Bitmap) newImage);
            gfx.DrawImage(image, new Rectangle(Point.Empty, newSize));
            return newImage;
        }
    }
}