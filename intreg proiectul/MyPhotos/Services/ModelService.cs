using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ModelAPI;
using MyPhotos.Properties;
using MyPhotos.Utils;

namespace MyPhotos.Services
{
    public sealed class ModelService
    {
        public IList<Media> Search(string search, string type)
        {
            var client = new WcfClient();
            return client.FindByContentTypeMedia(search, type);
            // return _unitService.Media.FindByContentType(search, type);
        }

        public IList<Media> GetAllMedias()
        {
            using var client = new WcfClient();
            return client.GetAllNotDeletedMedia();
            // return _unitService.Media.GetAllNotDeleted();
        }

        public static IList<string> ScanForMedia(string path)
        {
            return new List<string>(Directory.GetFiles(path)).Where(e =>
                Format._imagesFormats.Contains(Path.GetExtension(e)) ||
                Format._videoFormats.Contains(Path.GetExtension(e))).ToList();
        }


        public void SaveMedia(Media media)
        {
            _tempMedia.Add(media);
        }

        public int Complete()
        {
            using var client = new WcfClient();
            var filesNotFound = new List<string>();
            foreach (var tempMedium in _tempMedia)
            {
                if (!File.Exists(tempMedium.FullPath))
                    filesNotFound.Add(tempMedium.FullPath);
                else
                    client.InsertMedia(tempMedium);
                // _unitService.Media.Insert(tempMedium);
            }

            _tempMedia.Clear();
            if (filesNotFound.Count <= 0) return 0;
            var b = new StringBuilder();
            foreach (var fileNotFound in filesNotFound)
            {
                b.Append(fileNotFound);
                b.Append("\n");
            }

            MessageBox.Show(b.ToString(), Resources.FailImport);
            return 0;
            // return _unitService.Complete();
        }

        internal void Delete(Media media)
        {
            media.Deleted = true;
            using var client = new WcfClient();
            client.UpdateMedia(media);
            // _unitService.Media.Update(media);
        }


        public ModelService()
        {
            // _unitService = new UnitOfWork(new ModelAPI.ModelContainer());
            _tempMedia = new List<Media>();
        }

        public void Cancel()
        {
            _tempMedia.Clear();
        }

        // private readonly IUnitOfWork _unitService;
        private IList<Media> _tempMedia;

        public void Update(Media selectedItem, Media media)
        {
            media.MediaId = selectedItem.MediaId;
            media.DateOfCreation = selectedItem.DateOfCreation;
            media.FullPath = selectedItem.FullPath;
            media.Format = selectedItem.Format;
            media.Deleted = false;
            using var client = new WcfClient();
            client.DeleteMedia(selectedItem);
            client.InsertMedia(media);
            // _unitService.Media.DeleteMediaInCascade(selectedItem);
            // _unitService.Complete();
            // _unitService.Media.Insert(media);
            // _unitService.Complete();
        }
    }
}