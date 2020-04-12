using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyPhotos
{
    internal partial class Form1
    {
        public void ValidateComma(object sender, EventArgs e)
        {
            var texBox = sender as TextBox;
            texBox.BackColor = texBox?.Text.EndsWith(",") == true ? Color.Red : Color.FromArgb(136, 102, 93);
        }

        private void ChangeTabSelecting(object sender, CancelEventArgs e)
        {
            var current = (sender as TabControl).SelectedTab;
            if (current.Text == "Home" && _imported)
            {
                _service.Cancel();
                SetDataList(_service.GetAllMedias());
            }

            _imported = false;
        }
    }
}