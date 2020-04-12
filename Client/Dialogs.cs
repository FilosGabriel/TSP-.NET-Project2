using System.Collections.Generic;
using System.Windows.Forms;
using ModelAPI;
using MyPhotos.Properties;
using MyPhotos.Services;

namespace MyPhotos
{
    public class Dialogs
    {
        public static void RemoveDialog(Media selectedItem, ListView listImages, ModelService _service)
        {
            var message =
                $"File at location {selectedItem.FullPath} don't exist.\nDo you want to delete this media from app?";
            var caption = "Media file was deleted";
            var buttons = MessageBoxButtons.YesNo;

            var result = MessageBox.Show(message, caption, buttons);
            if (result != DialogResult.Yes) return;
            listImages.Items.Remove(listImages.SelectedItems[0]);
            _service.Delete(selectedItem);
            _service.Complete();
        }

        public static void FileWasRemoved(List<Media> image, ModelService _service, ListView listView)
        {
            var message =
                $"{image.Count} files don't exist.\nDo you want to delete these medias from app?";
            const string caption = "Media files was deleted";
            const MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show(message, caption, buttons);
            if (result != DialogResult.Yes)
            {
                foreach (var media in image)
                {
                    string[] row =
                    {
                        media.Name, media.DateOfCreation.ToString(Resources.FormatDate), media.Format, media.Description
                    };
                    var lvi = new ListViewItem(row) {Tag = image};
                    listView.Items.Add(lvi);
                }
            }
            else
            {
                foreach (var toDelete in image)
                {
                    _service.Delete(toDelete);
                }

                _service.Complete();
            }
        }
    }
}