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
    // Home page
    internal partial class Form1
    {
        private void SetDetailsHome(Media media)
        {
            NameHome.Text = media.Name;
            FormatHome.Text = media.Format;
            DescriptionHome.Text = media.Description;
            DateHome.Text = media.DateOfCreation.ToString(Resources.FormatDate);
            PlacesHome.Text = StringUtil.JoinValues(media.Place, e => e.Name);
            EventsImport.Text = StringUtil.JoinValues(media.Event, e => e.Name);
            PersonsHome.Text = StringUtil.JoinValues(media.People, e => e.Name);
            TagsHome.Text = StringUtil.JoinValues(media.Tag, e => e.Name);
        }


        private void listImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            OpenExtern.Enabled = true;
            var selectedItem = (Media) listImages.SelectedItems[0].Tag;

            if (File.Exists(selectedItem.FullPath))
            {
                if (Format.IsImage(selectedItem.FullPath))
                {
                    SwichPreview(true);
                    if (pictureBox1.Image != null)
                        pictureBox1.Image.Dispose();
                    pictureBox1.Image = EditImage.ResizeImage(selectedItem.FullPath, pictureBox1.Size);
                }
                else
                {
                    SwichPreview(false);
                    VideoPlayer.URL = selectedItem.FullPath;
                    VideoPlayer.Ctlcontrols.play();
                }

                SetDetailsHome(selectedItem);
            }
            else
                Dialogs.RemoveDialog(selectedItem, listImages, _service);

            Save.Enabled = true;
            }
            catch (Exception ex)
            {
                // ignored 
            }
        }


        private void InitialStartup(object sender, EventArgs e)
        {
            SetDataList(_service.GetAllMedias());
        }

        private void SetButtonsHome(bool value)
        {
            PrintButton.Enabled = value;
            SendEmailButton.Enabled = value;
        }

        private void SetDataList(IEnumerable<Media> data)
        {
            listImages.Items.Clear();
            var imagesToDelete = new List<Media>();
            foreach (var image in data)
            {
                if (!File.Exists(image.FullPath))
                    imagesToDelete.Add(image);
                else
                {
                    string[] row =
                    {
                        image.Name, image.DateOfCreation.ToString(Resources.FormatDate), image.Format, image.Description
                    };
                    var lvi = new ListViewItem(row) {Tag = image};
                    listImages.Items.Add(lvi);
                }
            }

            if (imagesToDelete.Count == 0) return;
            Dialogs.FileWasRemoved(imagesToDelete, _service, listImages);
        }

        private void DeleteSelectedItems(object sender, EventArgs e)
        {
            var listChecked = listImages.CheckedItems;
            if (listChecked.Count <= 0) return;
            ResetViewHome();
            foreach (ListViewItem item in listChecked)
            {
                var itemMedia = (Media) item.Tag;
                itemMedia.Deleted = true;
                _service.Delete(itemMedia);
                listImages.Items.Remove(item);
            }

            _service.Complete();
        }

        private void ResetViewHome()
        {
            pictureBox1.Hide();
            VideoPlayer.Hide();
            NameHome.Text = string.Empty;
            DateHome.Text = string.Empty;
            FormatHome.Text = string.Empty;
            PlacesHome.Text = string.Empty;
            PersonsHome.Text = string.Empty;
            TagsHome.Text = string.Empty;
            DescriptionHome.Text = string.Empty;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // try
            // {
            OpenExtern.Enabled = true;
            var selectedItem = (Media) listImages.SelectedItems[0].Tag;
            if (File.Exists(selectedItem.FullPath))
            {
                var media = new Media();
                media.Name = selectedItem.Name;
                media.Description = selectedItem.Description;
                if (Validation.IsValidInput(NameHome.Text))
                    media.Name = NameHome.Text;

                if (Validation.IsValidInput(DescriptionHome.Text))
                    media.Description = DescriptionHome.Text;
                // selectedItem.Event = Validation.ValidateAndAssign(Event, SimpleFactory.CreateEvent);
                media.People = Validation.ValidateAndAssign(PersonsHome, SimpleFactory.createPerson).ToArray();
                media.Tag = Validation.ValidateAndAssign(TagsHome, SimpleFactory.CreateTag).ToArray();
                media.Place = Validation.ValidateAndAssign(PlacesHome, SimpleFactory.CreatePlace).ToArray();
                _service.Update(selectedItem, media);
                MessageBox.Show(Resources.UpdatedSuccessfully);
                SetDataList(_service.GetAllMedias());
            }
            else
                MessageBox.Show(string.Format(Resources.FileDontExist, selectedItem.FullPath));

            Save.Enabled = true;
            // }
            // catch (Exception ex)
            // {
            //     MessageBox.Show(ex.Message);
            // }
        }
    }
}