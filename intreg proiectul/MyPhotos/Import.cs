using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ModelAPI;
using MyPhotos.Properties;
using MyPhotos.Services;
using MyPhotos.Utils;

namespace MyPhotos
{
    internal partial class Form1
    {
        public void LoadMediaFromFolder(string folderPath)
        {
            var mediaPaths = ModelService.ScanForMedia(folderPath);
            if (mediaPaths.Count > 0)
                InitImport(mediaPaths);
            else
                MessageBox.Show(string.Format(Resources.NoMedia, folderPath));
        }

        private void InitImport(IList<string> mediaPaths)
        {
            SetButtons(true);
            _importMediaList = mediaPaths.Select(SimpleFactory.CreateMediaFromPath).ToList();
            MessageBox.Show(string.Format(Resources.NMediaFound, _importMediaList.Count));
            SetDetailsInfoImportImage(_importMediaList.First());
        }

        public void SetDetailsInfoImportImage(Media inputMedia)
        {
            _indexImport++;
            if (!File.Exists(inputMedia.FullPath))
            {
                Skip_Click(null, EventArgs.Empty);
                return;
            }

            if (Format.IsImage(inputMedia.FullPath))
            {
                SwichPreviewImport(true);
                if (pictureBox2.Image != null)
                    pictureBox2.Image.Dispose();
                pictureBox2.Image = EditImage.ResizeImage(inputMedia.FullPath, pictureBox2.Size);
            }
            else
            {
                SwichPreviewImport(false);
                axWindowsMediaPlayer1.URL = inputMedia.FullPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }

            NameImport.Text = inputMedia.Name;
            PathImport.Text = inputMedia.FullPath;
            DateImport.Text = File.GetCreationTime(inputMedia.FullPath).ToString(Resources.FormatDate);
            FormatImport.Text = Path.GetExtension(inputMedia.FullPath);
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            if (_indexImport >= _importMediaList.Count)
            {
                SetButtons(false);
                _service.Complete();
                MessageBox.Show(Resources.CompleteImport);
                return;
            }

            SetDetailsInfoImportImage(_importMediaList.Skip(_indexImport).First());
        }

        private void SaveImportButtonClick(object sender, EventArgs e)
        {
            var mediaToSave = _importMediaList.Skip(_indexImport - 1).First();
            if (Validation.IsValidInput(DescriptionImport.Text))
                mediaToSave.Description = DescriptionImport.Text;
            mediaToSave.MediaId = Guid.NewGuid();
            mediaToSave.Event = Validation.ValidateAndAssign(EventsImport, SimpleFactory.CreateEvent).ToArray();
            mediaToSave.People = Validation.ValidateAndAssign(PersonsTextBoxImport, SimpleFactory.createPerson).ToArray();
            mediaToSave.Tag = Validation.ValidateAndAssign(TagsBoxImport, SimpleFactory.CreateTag).ToArray();
            mediaToSave.Place = Validation.ValidateAndAssign(PlacesImportBox, SimpleFactory.CreatePlace).ToArray();
            _service.SaveMedia(mediaToSave);
            Skip_Click(null, EventArgs.Empty);
        }

        public void SetButtons(bool value)
        {
            Skip.Enabled = value;
            SaveImportButton.Enabled = value;
        }

        private void SaveToDatabaseImport_Click(object sender, EventArgs e)
        {
            _imported = true;
            _indexImport = 0;
            MessageBox.Show(string.Format(Resources.NMediaImported, _service.Complete()));
            ResetViewImport();
        }

        private void CancelImport_Click(object sender, EventArgs e)
        {
            _service.Cancel();
            _indexImport = 0;
            MessageBox.Show(Resources.CancelImport);
            ResetViewImport();
        }

        private void ResetViewImport()
        {
            pictureBox2.Hide();
            axWindowsMediaPlayer1.Hide();
            NameImport.Text = string.Empty;
            DateImport.Text = string.Empty;
            FormatImport.Text = string.Empty;
            PathImport.Text = string.Empty;
            PlacesImportBox.Text = string.Empty;
            PersonsTextBoxImport.Text = string.Empty;
            TagsBoxImport.Text = string.Empty;
            DescriptionImport.Text = string.Empty;
            EventsImport.Text = string.Empty;
        }

        private void FilesImport_Click(object sender, EventArgs e)
        {
            using var fbd = new OpenFileDialog();
            var video = string.Join("", Format._videoFormats.Select(p => $"*{p};").ToList());
            fbd.Filter = string.Format(Resources.FileImportOption, video, video);
            fbd.Multiselect = true;
            fbd.Title = Resources.TittleImport;
            var result = fbd.ShowDialog();
            if (result != DialogResult.OK) return;
            InitImport(fbd.FileNames);
        }

        private void ImportFromDirectory(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog();
            var result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                LoadMediaFromFolder(fbd.SelectedPath);
        }

        private bool _imported;
    }
}