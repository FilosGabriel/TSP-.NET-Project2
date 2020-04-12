using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using ModelAPI;
using MyPhotos.Properties;
using MyPhotos.Utils;

namespace MyPhotos
{
    internal partial class Form1
    {
        private void Doc_Printpage(object sender, PrintPageEventArgs e)
        {
            var item = (Media) listImages.CheckedItems[_indexPrint].Tag;
            if (File.Exists(item.FullPath) && Format.IsImage(item.FullPath))
            {
                using var objimage = Image.FromFile(item.FullPath);
                var m = e.MarginBounds;

                if (objimage.Width / (double) objimage.Height > m.Width / (double) m.Height) // image is wider
                    m.Height = (int) (objimage.Height / (double) objimage.Width * m.Width);
                else
                    m.Width = (int) (objimage.Width / (double) objimage.Height * m.Height);

                e.Graphics.DrawImage(objimage, m);
            }

            _indexPrint++;
            e.HasMorePages = _indexPrint < listImages.CheckedItems.Count;
            if (_indexPrint == listImages.CheckedItems.Count) _indexPrint = 0;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (listImages.CheckedItems.Count <= 0) return;
            using var pdDialog = new PrintDialog();
            using var pdDocument = new PrintDocument();
            pdDocument.PrintPage += Doc_Printpage;
            pdDialog.Document = pdDocument;
            if (pdDialog.ShowDialog() == DialogResult.OK)
                pdDocument.Print();
        }

        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            var list = listImages.CheckedItems;
            if (list.Count <= 0) return;
            using var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Zip (*.zip)|*.zip;";
            var result = saveFileDialog.ShowDialog();
            saveFileDialog.CheckFileExists = true;
            saveFileDialog.OverwritePrompt = true;
            if (result != DialogResult.OK || string.IsNullOrEmpty(saveFileDialog.FileName)) return;
            var zipPath = saveFileDialog.FileName;
            if (File.Exists(zipPath))
                File.Delete(zipPath);
            using var archive = ZipFile.Open(zipPath, ZipArchiveMode.Create);
            foreach (ListViewItem item in list)
            {
                var m = (Media) item.Tag;
                if (File.Exists(m.FullPath))
                    archive.CreateEntryFromFile(m.FullPath, Path.GetFileName(m.FullPath));
            }

            archive.Dispose();
            MessageBox.Show(Resources.ExportComplete);
        }
    }
}