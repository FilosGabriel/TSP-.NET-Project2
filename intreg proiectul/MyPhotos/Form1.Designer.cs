namespace MyPhotos
{
    internal partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listImages = new System.Windows.Forms.ListView();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.format = new System.Windows.Forms.ColumnHeader();
            this.description = new System.Windows.Forms.ColumnHeader();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.searchField = new System.Windows.Forms.TextBox();
            this.OpenExtern = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.SendEmailButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.resetSearch = new System.Windows.Forms.Button();
            this.selectSearch = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteSelected = new System.Windows.Forms.Button();
            this.VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            this.DescriptionHome = new System.Windows.Forms.TextBox();
            this.TagsHome = new System.Windows.Forms.TextBox();
            this.PersonsHome = new System.Windows.Forms.TextBox();
            this.PlacesHome = new System.Windows.Forms.TextBox();
            this.FormatHome = new System.Windows.Forms.TextBox();
            this.DateHome = new System.Windows.Forms.TextBox();
            this.NameHome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FilesImport = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.SaveToDatabaseImport = new System.Windows.Forms.Button();
            this.CancelImport = new System.Windows.Forms.Button();
            this.EventsImport = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.import = new System.Windows.Forms.Button();
            this.Skip = new System.Windows.Forms.Button();
            this.PathImport = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SaveImportButton = new System.Windows.Forms.Button();
            this.DescriptionImport = new System.Windows.Forms.TextBox();
            this.TagsBoxImport = new System.Windows.Forms.TextBox();
            this.PersonsTextBoxImport = new System.Windows.Forms.TextBox();
            this.PlacesImportBox = new System.Windows.Forms.TextBox();
            this.FormatImport = new System.Windows.Forms.TextBox();
            this.DateImport = new System.Windows.Forms.TextBox();
            this.NameImport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.VideoPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listImages
            // 
            this.listImages.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.listImages.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (176)))),
                ((int) (((byte) (255)))));
            this.listImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listImages.CheckBoxes = true;
            this.listImages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
                {this.name, this.date, this.format, this.description});
            this.listImages.Cursor = System.Windows.Forms.Cursors.Default;
            this.listImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listImages.ForeColor = System.Drawing.Color.White;
            this.listImages.FullRowSelect = true;
            this.listImages.HideSelection = false;
            this.listImages.Location = new System.Drawing.Point(8, 67);
            this.listImages.Name = "listImages";
            this.listImages.Size = new System.Drawing.Size(590, 802);
            this.listImages.TabIndex = 0;
            this.listImages.UseCompatibleStateImageBehavior = false;
            this.listImages.View = System.Windows.Forms.View.Details;
            this.listImages.SelectedIndexChanged += new System.EventHandler(this.listImages_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 89;
            // 
            // date
            // 
            this.date.Text = "Creation date";
            this.date.Width = 131;
            // 
            // format
            // 
            this.format.Text = "Format";
            this.format.Width = 125;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 260;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // searchField
            // 
            this.searchField.BackColor = System.Drawing.Color.White;
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchField.Location = new System.Drawing.Point(7, 10);
            this.searchField.Multiline = true;
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(591, 37);
            this.searchField.TabIndex = 2;
            // 
            // OpenExtern
            // 
            this.OpenExtern.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.OpenExtern.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.OpenExtern.FlatAppearance.BorderSize = 0;
            this.OpenExtern.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.OpenExtern.ForeColor = System.Drawing.Color.White;
            this.OpenExtern.Location = new System.Drawing.Point(1510, 876);
            this.OpenExtern.Name = "OpenExtern";
            this.OpenExtern.Size = new System.Drawing.Size(260, 57);
            this.OpenExtern.TabIndex = 17;
            this.OpenExtern.Text = "Open Extern";
            this.OpenExtern.UseVisualStyleBackColor = false;
            this.OpenExtern.Click += new System.EventHandler(this.OpenExtern_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.Location = new System.Drawing.Point(1242, 876);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(260, 57);
            this.PrintButton.TabIndex = 18;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // SendEmailButton
            // 
            this.SendEmailButton.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.SendEmailButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))),
                ((int) (((byte) (98)))), ((int) (((byte) (255)))));
            this.SendEmailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.SendEmailButton.ForeColor = System.Drawing.Color.White;
            this.SendEmailButton.Location = new System.Drawing.Point(1010, 876);
            this.SendEmailButton.Name = "SendEmailButton";
            this.SendEmailButton.Size = new System.Drawing.Size(225, 57);
            this.SendEmailButton.TabIndex = 19;
            this.SendEmailButton.Text = "Arhivate";
            this.SendEmailButton.UseVisualStyleBackColor = false;
            this.SendEmailButton.Click += new System.EventHandler(this.SendEmailButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Roboto Mono for Powerline", 15.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1905, 984);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.resetSearch);
            this.tabPage1.Controls.Add(this.selectSearch);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.DeleteSelected);
            this.tabPage1.Controls.Add(this.VideoPlayer);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.OpenExtern);
            this.tabPage1.Controls.Add(this.PrintButton);
            this.tabPage1.Controls.Add(this.SendEmailButton);
            this.tabPage1.Controls.Add(this.Save);
            this.tabPage1.Controls.Add(this.DescriptionHome);
            this.tabPage1.Controls.Add(this.TagsHome);
            this.tabPage1.Controls.Add(this.PersonsHome);
            this.tabPage1.Controls.Add(this.PlacesHome);
            this.tabPage1.Controls.Add(this.FormatHome);
            this.tabPage1.Controls.Add(this.DateHome);
            this.tabPage1.Controls.Add(this.NameHome);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.searchField);
            this.tabPage1.Controls.Add(this.listImages);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1897, 946);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // resetSearch
            // 
            this.resetSearch.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.resetSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.resetSearch.ForeColor = System.Drawing.Color.White;
            this.resetSearch.Location = new System.Drawing.Point(906, 10);
            this.resetSearch.Name = "resetSearch";
            this.resetSearch.Size = new System.Drawing.Size(108, 37);
            this.resetSearch.TabIndex = 41;
            this.resetSearch.UseVisualStyleBackColor = false;
            this.resetSearch.Click += new System.EventHandler(this.resetSearch_Click);
            // 
            // selectSearch
            // 
            this.selectSearch.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))),
                ((int) (((byte) (98)))), ((int) (((byte) (255)))));
            this.selectSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectSearch.FormattingEnabled = true;
            this.selectSearch.Items.AddRange(new object[] {"Any", "Event", "People", "Place", "Tag"});
            this.selectSearch.Location = new System.Drawing.Point(616, 10);
            this.selectSearch.Name = "selectSearch";
            this.selectSearch.Size = new System.Drawing.Size(140, 32);
            this.selectSearch.Sorted = true;
            this.selectSearch.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(764, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 39;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteSelected
            // 
            this.DeleteSelected.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteSelected.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))),
                ((int) (((byte) (98)))), ((int) (((byte) (255)))));
            this.DeleteSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.DeleteSelected.ForeColor = System.Drawing.Color.White;
            this.DeleteSelected.Location = new System.Drawing.Point(9, 876);
            this.DeleteSelected.Name = "DeleteSelected";
            this.DeleteSelected.Size = new System.Drawing.Size(356, 57);
            this.DeleteSelected.TabIndex = 38;
            this.DeleteSelected.Text = "Delete selected";
            this.DeleteSelected.UseVisualStyleBackColor = false;
            this.DeleteSelected.Click += new System.EventHandler(this.DeleteSelectedItems);
            // 
            // VideoPlayer
            // 
            this.VideoPlayer.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.VideoPlayer.Enabled = true;
            this.VideoPlayer.Location = new System.Drawing.Point(876, 9);
            this.VideoPlayer.Name = "VideoPlayer";
            this.VideoPlayer.OcxState =
                ((System.Windows.Forms.AxHost.State) (resources.GetObject("VideoPlayer.OcxState")));
            this.VideoPlayer.Size = new System.Drawing.Size(743, 620);
            this.VideoPlayer.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1022, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(867, 715);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Save
            // 
            this.Save.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(633, 876);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(356, 57);
            this.Save.TabIndex = 35;
            this.Save.Text = "Save changes";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // DescriptionHome
            // 
            this.DescriptionHome.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionHome.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))),
                ((int) (((byte) (98)))), ((int) (((byte) (255)))));
            this.DescriptionHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DescriptionHome.ForeColor = System.Drawing.Color.White;
            this.DescriptionHome.Location = new System.Drawing.Point(609, 749);
            this.DescriptionHome.Multiline = true;
            this.DescriptionHome.Name = "DescriptionHome";
            this.DescriptionHome.Size = new System.Drawing.Size(1269, 120);
            this.DescriptionHome.TabIndex = 34;
            // 
            // TagsHome
            // 
            this.TagsHome.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.TagsHome.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.TagsHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TagsHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TagsHome.ForeColor = System.Drawing.Color.White;
            this.TagsHome.Location = new System.Drawing.Point(605, 610);
            this.TagsHome.Multiline = true;
            this.TagsHome.Name = "TagsHome";
            this.TagsHome.Size = new System.Drawing.Size(384, 98);
            this.TagsHome.TabIndex = 33;
            // 
            // PersonsHome
            // 
            this.PersonsHome.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.PersonsHome.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.PersonsHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PersonsHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PersonsHome.ForeColor = System.Drawing.Color.White;
            this.PersonsHome.Location = new System.Drawing.Point(605, 472);
            this.PersonsHome.Multiline = true;
            this.PersonsHome.Name = "PersonsHome";
            this.PersonsHome.Size = new System.Drawing.Size(384, 98);
            this.PersonsHome.TabIndex = 32;
            // 
            // PlacesHome
            // 
            this.PlacesHome.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.PlacesHome.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.PlacesHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlacesHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PlacesHome.ForeColor = System.Drawing.Color.White;
            this.PlacesHome.Location = new System.Drawing.Point(605, 333);
            this.PlacesHome.Multiline = true;
            this.PlacesHome.Name = "PlacesHome";
            this.PlacesHome.Size = new System.Drawing.Size(384, 98);
            this.PlacesHome.TabIndex = 31;
            // 
            // FormatHome
            // 
            this.FormatHome.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.FormatHome.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.FormatHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormatHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormatHome.ForeColor = System.Drawing.Color.White;
            this.FormatHome.Location = new System.Drawing.Point(605, 257);
            this.FormatHome.Name = "FormatHome";
            this.FormatHome.Size = new System.Drawing.Size(384, 31);
            this.FormatHome.TabIndex = 30;
            // 
            // DateHome
            // 
            this.DateHome.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.DateHome.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.DateHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DateHome.ForeColor = System.Drawing.Color.White;
            this.DateHome.Location = new System.Drawing.Point(609, 181);
            this.DateHome.Name = "DateHome";
            this.DateHome.Size = new System.Drawing.Size(380, 31);
            this.DateHome.TabIndex = 29;
            // 
            // NameHome
            // 
            this.NameHome.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.NameHome.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.NameHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NameHome.ForeColor = System.Drawing.Color.White;
            this.NameHome.Location = new System.Drawing.Point(605, 104);
            this.NameHome.Name = "NameHome";
            this.NameHome.Size = new System.Drawing.Size(384, 31);
            this.NameHome.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(600, 573);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tags";
            // 
            // label6
            // 
            this.label6.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(600, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "Persons";
            // 
            // label5
            // 
            this.label5.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(600, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "Date of creation";
            // 
            // label4
            // 
            this.label4.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(603, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Format";
            // 
            // label3
            // 
            this.label3.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(600, 712);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(603, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Places";
            // 
            // label1
            // 
            this.label1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(603, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.FilesImport);
            this.tabPage2.Controls.Add(this.axWindowsMediaPlayer1);
            this.tabPage2.Controls.Add(this.SaveToDatabaseImport);
            this.tabPage2.Controls.Add(this.CancelImport);
            this.tabPage2.Controls.Add(this.EventsImport);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.import);
            this.tabPage2.Controls.Add(this.Skip);
            this.tabPage2.Controls.Add(this.PathImport);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.SaveImportButton);
            this.tabPage2.Controls.Add(this.DescriptionImport);
            this.tabPage2.Controls.Add(this.TagsBoxImport);
            this.tabPage2.Controls.Add(this.PersonsTextBoxImport);
            this.tabPage2.Controls.Add(this.PlacesImportBox);
            this.tabPage2.Controls.Add(this.FormatImport);
            this.tabPage2.Controls.Add(this.DateImport);
            this.tabPage2.Controls.Add(this.NameImport);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1897, 946);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Import";
            // 
            // FilesImport
            // 
            this.FilesImport.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.FilesImport.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.FilesImport.FlatAppearance.BorderSize = 0;
            this.FilesImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilesImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.FilesImport.ForeColor = System.Drawing.Color.White;
            this.FilesImport.Location = new System.Drawing.Point(301, 9);
            this.FilesImport.Name = "FilesImport";
            this.FilesImport.Size = new System.Drawing.Size(187, 40);
            this.FilesImport.TabIndex = 63;
            this.FilesImport.Text = "Files";
            this.FilesImport.UseVisualStyleBackColor = false;
            this.FilesImport.Click += new System.EventHandler(this.FilesImport_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(450, 8);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState =
                ((System.Windows.Forms.AxHost.State) (resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1169, 599);
            this.axWindowsMediaPlayer1.TabIndex = 62;
            // 
            // SaveToDatabaseImport
            // 
            this.SaveToDatabaseImport.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.SaveToDatabaseImport.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))),
                ((int) (((byte) (98)))), ((int) (((byte) (255)))));
            this.SaveToDatabaseImport.FlatAppearance.BorderSize = 0;
            this.SaveToDatabaseImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveToDatabaseImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.SaveToDatabaseImport.ForeColor = System.Drawing.Color.White;
            this.SaveToDatabaseImport.Location = new System.Drawing.Point(1357, 854);
            this.SaveToDatabaseImport.Name = "SaveToDatabaseImport";
            this.SaveToDatabaseImport.Size = new System.Drawing.Size(332, 57);
            this.SaveToDatabaseImport.TabIndex = 61;
            this.SaveToDatabaseImport.Text = "Save to database";
            this.SaveToDatabaseImport.UseVisualStyleBackColor = false;
            this.SaveToDatabaseImport.Click += new System.EventHandler(this.SaveToDatabaseImport_Click);
            // 
            // CancelImport
            // 
            this.CancelImport.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.CancelImport.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))),
                ((int) (((byte) (98)))), ((int) (((byte) (255)))));
            this.CancelImport.FlatAppearance.BorderSize = 0;
            this.CancelImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.CancelImport.ForeColor = System.Drawing.Color.White;
            this.CancelImport.Location = new System.Drawing.Point(1696, 854);
            this.CancelImport.Name = "CancelImport";
            this.CancelImport.Size = new System.Drawing.Size(192, 57);
            this.CancelImport.TabIndex = 60;
            this.CancelImport.Text = "Cancel";
            this.CancelImport.UseVisualStyleBackColor = false;
            this.CancelImport.Click += new System.EventHandler(this.CancelImport_Click);
            // 
            // EventsImport
            // 
            this.EventsImport.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.EventsImport.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))),
                ((int) (((byte) (98)))), ((int) (((byte) (255)))));
            this.EventsImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.EventsImport.ForeColor = System.Drawing.Color.White;
            this.EventsImport.Location = new System.Drawing.Point(34, 646);
            this.EventsImport.Name = "EventsImport";
            this.EventsImport.Size = new System.Drawing.Size(467, 38);
            this.EventsImport.TabIndex = 59;
            // 
            // label17
            // 
            this.label17.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(28, 609);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 29);
            this.label17.TabIndex = 58;
            this.label17.Text = "Events";
            // 
            // import
            // 
            this.import.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.import.FlatAppearance.BorderSize = 0;
            this.import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.import.ForeColor = System.Drawing.Color.White;
            this.import.Location = new System.Drawing.Point(143, 9);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(150, 40);
            this.import.TabIndex = 56;
            this.import.Text = "Directory";
            this.import.UseVisualStyleBackColor = false;
            this.import.Click += new System.EventHandler(this.ImportFromDirectory);
            // 
            // Skip
            // 
            this.Skip.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.Skip.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.Skip.FlatAppearance.BorderSize = 0;
            this.Skip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Skip.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Skip.ForeColor = System.Drawing.Color.White;
            this.Skip.Location = new System.Drawing.Point(397, 854);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(192, 57);
            this.Skip.TabIndex = 55;
            this.Skip.Text = "Skip";
            this.Skip.UseVisualStyleBackColor = false;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // PathImport
            // 
            this.PathImport.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.PathImport.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.PathImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PathImport.ForeColor = System.Drawing.Color.White;
            this.PathImport.Location = new System.Drawing.Point(34, 141);
            this.PathImport.Name = "PathImport";
            this.PathImport.ReadOnly = true;
            this.PathImport.Size = new System.Drawing.Size(467, 38);
            this.PathImport.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(28, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 29);
            this.label15.TabIndex = 51;
            this.label15.Text = "Path";
            // 
            // SaveImportButton
            // 
            this.SaveImportButton.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.SaveImportButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))),
                ((int) (((byte) (98)))), ((int) (((byte) (255)))));
            this.SaveImportButton.FlatAppearance.BorderSize = 0;
            this.SaveImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.SaveImportButton.ForeColor = System.Drawing.Color.White;
            this.SaveImportButton.Location = new System.Drawing.Point(34, 854);
            this.SaveImportButton.Name = "SaveImportButton";
            this.SaveImportButton.Size = new System.Drawing.Size(356, 57);
            this.SaveImportButton.TabIndex = 50;
            this.SaveImportButton.Text = "Save Media Info";
            this.SaveImportButton.UseVisualStyleBackColor = false;
            this.SaveImportButton.Click += new System.EventHandler(this.SaveImportButtonClick);
            // 
            // DescriptionImport
            // 
            this.DescriptionImport.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionImport.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))),
                ((int) (((byte) (98)))), ((int) (((byte) (255)))));
            this.DescriptionImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DescriptionImport.ForeColor = System.Drawing.Color.White;
            this.DescriptionImport.Location = new System.Drawing.Point(34, 730);
            this.DescriptionImport.Multiline = true;
            this.DescriptionImport.Name = "DescriptionImport";
            this.DescriptionImport.Size = new System.Drawing.Size(1854, 116);
            this.DescriptionImport.TabIndex = 49;
            // 
            // TagsBoxImport
            // 
            this.TagsBoxImport.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.TagsBoxImport.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))),
                ((int) (((byte) (98)))), ((int) (((byte) (255)))));
            this.TagsBoxImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TagsBoxImport.ForeColor = System.Drawing.Color.White;
            this.TagsBoxImport.Location = new System.Drawing.Point(34, 562);
            this.TagsBoxImport.Name = "TagsBoxImport";
            this.TagsBoxImport.Size = new System.Drawing.Size(467, 38);
            this.TagsBoxImport.TabIndex = 48;
            // 
            // PersonsTextBoxImport
            // 
            this.PersonsTextBoxImport.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.PersonsTextBoxImport.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))),
                ((int) (((byte) (98)))), ((int) (((byte) (255)))));
            this.PersonsTextBoxImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PersonsTextBoxImport.ForeColor = System.Drawing.Color.White;
            this.PersonsTextBoxImport.Location = new System.Drawing.Point(34, 478);
            this.PersonsTextBoxImport.Name = "PersonsTextBoxImport";
            this.PersonsTextBoxImport.Size = new System.Drawing.Size(467, 38);
            this.PersonsTextBoxImport.TabIndex = 47;
            // 
            // PlacesImportBox
            // 
            this.PlacesImportBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.PlacesImportBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))),
                ((int) (((byte) (98)))), ((int) (((byte) (255)))));
            this.PlacesImportBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PlacesImportBox.ForeColor = System.Drawing.Color.White;
            this.PlacesImportBox.Location = new System.Drawing.Point(34, 393);
            this.PlacesImportBox.Name = "PlacesImportBox";
            this.PlacesImportBox.Size = new System.Drawing.Size(467, 38);
            this.PlacesImportBox.TabIndex = 46;
            // 
            // FormatImport
            // 
            this.FormatImport.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.FormatImport.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))),
                ((int) (((byte) (98)))), ((int) (((byte) (255)))));
            this.FormatImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormatImport.ForeColor = System.Drawing.Color.White;
            this.FormatImport.Location = new System.Drawing.Point(34, 309);
            this.FormatImport.Name = "FormatImport";
            this.FormatImport.ReadOnly = true;
            this.FormatImport.Size = new System.Drawing.Size(467, 38);
            this.FormatImport.TabIndex = 45;
            // 
            // DateImport
            // 
            this.DateImport.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.DateImport.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.DateImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DateImport.ForeColor = System.Drawing.Color.White;
            this.DateImport.Location = new System.Drawing.Point(34, 225);
            this.DateImport.Name = "DateImport";
            this.DateImport.ReadOnly = true;
            this.DateImport.Size = new System.Drawing.Size(467, 38);
            this.DateImport.TabIndex = 44;
            // 
            // NameImport
            // 
            this.NameImport.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.NameImport.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (41)))), ((int) (((byte) (98)))),
                ((int) (((byte) (255)))));
            this.NameImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NameImport.ForeColor = System.Drawing.Color.White;
            this.NameImport.Location = new System.Drawing.Point(34, 57);
            this.NameImport.Name = "NameImport";
            this.NameImport.Size = new System.Drawing.Size(467, 38);
            this.NameImport.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 29);
            this.label8.TabIndex = 42;
            this.label8.Text = "Tags";
            // 
            // label9
            // 
            this.label9.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(28, 441);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 29);
            this.label9.TabIndex = 41;
            this.label9.Text = "Persons";
            // 
            // label10
            // 
            this.label10.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(28, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 29);
            this.label10.TabIndex = 40;
            this.label10.Text = "Date of creation";
            // 
            // label11
            // 
            this.label11.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(28, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 29);
            this.label11.TabIndex = 39;
            this.label11.Text = "Format";
            // 
            // label12
            // 
            this.label12.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(28, 693);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 29);
            this.label12.TabIndex = 38;
            this.label12.Text = "Description";
            // 
            // label13
            // 
            this.label13.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(28, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 29);
            this.label13.TabIndex = 37;
            this.label13.Text = "Places";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(28, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 29);
            this.label14.TabIndex = 36;
            this.label14.Text = "Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(525, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1364, 691);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (136)))), ((int) (((byte) (102)))),
                ((int) (((byte) (93)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1902, 985);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1918, 1024);
            this.MinimumSize = new System.Drawing.Size(1918, 1024);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "MyPhotos";
            this.Load += new System.EventHandler(this.InitialStartup);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.VideoPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listImages;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader format;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.Button OpenExtern;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button SendEmailButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox DescriptionHome;
        private System.Windows.Forms.TextBox TagsHome;
        private System.Windows.Forms.TextBox PersonsHome;
        private System.Windows.Forms.TextBox PlacesHome;
        private System.Windows.Forms.TextBox FormatHome;
        private System.Windows.Forms.TextBox DateHome;
        private System.Windows.Forms.TextBox NameHome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathImport;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button SaveImportButton;
        private System.Windows.Forms.TextBox DescriptionImport;
        private System.Windows.Forms.TextBox PlacesImportBox;
        private System.Windows.Forms.TextBox FormatImport;
        private System.Windows.Forms.TextBox DateImport;
        private System.Windows.Forms.TextBox NameImport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Skip;
        private System.Windows.Forms.TextBox EventsImport;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox PersonsTextBoxImport;
        private System.Windows.Forms.TextBox TagsBoxImport;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button SaveToDatabaseImport;
        private System.Windows.Forms.Button CancelImport;
        private AxWMPLib.AxWindowsMediaPlayer VideoPlayer;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button FilesImport;
        private System.Windows.Forms.Button DeleteSelected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox selectSearch;
        private System.Windows.Forms.Button resetSearch;
    }
}

