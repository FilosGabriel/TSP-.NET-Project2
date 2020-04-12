using MyPhotos.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ModelAPI;
using MyPhotos.Properties;

namespace MyPhotos
{
    internal partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Paint += set_background;
            tabPage1.Paint += set_background;
            tabPage2.Paint += set_background;
            _service = new ModelService();
            SetButtons(false);
            OpenExtern.Enabled = false;
            SetButtonsHome(true);
            button1.Text = "\uD83D\uDD0D";
            resetSearch.Text = "\u21BA";
            VideoPlayer.Hide();
            selectSearch.SelectedIndex = 0;
            pictureBox2.Hide();
            Application.EnableVisualStyles();
            tabControl1.Selecting += ChangeTabSelecting;
            PersonsTextBoxImport.TextChanged += ValidateComma;
            TagsBoxImport.TextChanged += ValidateComma;
            PlacesImportBox.TextChanged += ValidateComma;
            EventsImport.TextChanged += ValidateComma;
        }

        private void set_background(Object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            var gradientRectangle = new Rectangle(0, 0, Width, Height);

            var b = new LinearGradientBrush(gradientRectangle, ColorTranslator.FromHtml("#00b0ff"),
                ColorTranslator.FromHtml("#00b0ff"), 0f);
            graphics.FillRectangle(b, gradientRectangle);
        }


        private void OpenExtern_Click(object sender, EventArgs e)
        {
            var data = (Media) listImages.SelectedItems[0].Tag;
            System.Diagnostics.Process.Start(data.FullPath);
        }

        private int _indexImport = 0;
        private IList<Media> _importMediaList;
        private readonly ModelService _service;
        private int _indexPrint;


        private void button1_Click(object sender, EventArgs e)
        {
            var result = _service.Search(searchField.Text, selectSearch.Text);
            SetDataList(result);
            if (result.Count == 0)
            {
                MessageBox.Show(Resources.NoMediaFound);
            }
        }

        private void resetSearch_Click(object sender, EventArgs e)
        {
            SetDataList(_service.GetAllMedias());
            searchField.Text = string.Empty;
        }
    }
}