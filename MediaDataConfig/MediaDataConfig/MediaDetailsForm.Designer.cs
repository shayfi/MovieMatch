namespace MediaDataConfig
{
    partial class MediaDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaDetailsForm));
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnExact = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPlotCaption = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lvMovies = new System.Windows.Forms.ListView();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEpisode = new System.Windows.Forms.TextBox();
            this.tbSeason = new System.Windows.Forms.TextBox();
            this.lblSeasonCaption = new System.Windows.Forms.Label();
            this.lblEpisodeCaption = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.tbPlot = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbliDBRating = new System.Windows.Forms.Label();
            this.lbliDBRatingCaption = new System.Windows.Forms.Label();
            this.lblCastCation = new System.Windows.Forms.Label();
            this.tbCast = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbTitle.Location = new System.Drawing.Point(45, 19);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(269, 20);
            this.tbTitle.TabIndex = 7;
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.Location = new System.Drawing.Point(9, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // lblYear
            // 
            this.lblYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblYear.Location = new System.Drawing.Point(9, 54);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year:";
            // 
            // tbYear
            // 
            this.tbYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbYear.Location = new System.Drawing.Point(45, 50);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(58, 20);
            this.tbYear.TabIndex = 6;
            this.tbYear.TextChanged += new System.EventHandler(this.tbYear_TextChanged);
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblType.Location = new System.Drawing.Point(176, 54);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(66, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Media Type:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl1.Location = new System.Drawing.Point(15, 117);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(58, 13);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Language:";
            // 
            // btnExact
            // 
            this.btnExact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExact.Location = new System.Drawing.Point(416, 15);
            this.btnExact.Name = "btnExact";
            this.btnExact.Size = new System.Drawing.Size(142, 25);
            this.btnExact.TabIndex = 9;
            this.btnExact.Text = "Best Match";
            this.btnExact.UseVisualStyleBackColor = true;
            this.btnExact.Click += new System.EventHandler(this.btnExact_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Enabled = false;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOk.Location = new System.Drawing.Point(438, 648);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 25);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Apply";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSearch.Location = new System.Drawing.Point(416, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 25);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Find Other Matches";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPlotCaption
            // 
            this.lblPlotCaption.AutoSize = true;
            this.lblPlotCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlotCaption.Location = new System.Drawing.Point(357, 206);
            this.lblPlotCaption.Name = "lblPlotCaption";
            this.lblPlotCaption.Size = new System.Drawing.Size(171, 13);
            this.lblPlotCaption.TabIndex = 13;
            this.lblPlotCaption.Text = "Plot (Double click for long version):";
            this.lblPlotCaption.DoubleClick += new System.EventHandler(this.lblPlotCaption_DoubleClick);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMessage.Location = new System.Drawing.Point(85, 331);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 14;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // lvMovies
            // 
            this.lvMovies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lvMovies.Location = new System.Drawing.Point(360, 393);
            this.lvMovies.Name = "lvMovies";
            this.lvMovies.Size = new System.Drawing.Size(272, 234);
            this.lvMovies.TabIndex = 15;
            this.lvMovies.UseCompatibleStateImageBehavior = false;
            this.lvMovies.SelectedIndexChanged += new System.EventHandler(this.lvMovies_SelectedIndexChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl3.Location = new System.Drawing.Point(15, 159);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(39, 13);
            this.lbl3.TabIndex = 17;
            this.lbl3.Text = "Genre:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl2.Location = new System.Drawing.Point(15, 139);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(47, 13);
            this.lbl2.TabIndex = 19;
            this.lbl2.Text = "Director:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbEpisode);
            this.groupBox1.Controls.Add(this.tbSeason);
            this.groupBox1.Controls.Add(this.lblSeasonCaption);
            this.groupBox1.Controls.Add(this.lblEpisodeCaption);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.btnExact);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.lblYear);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.tbYear);
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 85);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // tbEpisode
            // 
            this.tbEpisode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEpisode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbEpisode.Location = new System.Drawing.Point(375, 51);
            this.tbEpisode.Name = "tbEpisode";
            this.tbEpisode.Size = new System.Drawing.Size(23, 20);
            this.tbEpisode.TabIndex = 34;
            this.tbEpisode.TextChanged += new System.EventHandler(this.tbEpisode_TextChanged);
            // 
            // tbSeason
            // 
            this.tbSeason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbSeason.Location = new System.Drawing.Point(375, 21);
            this.tbSeason.Name = "tbSeason";
            this.tbSeason.Size = new System.Drawing.Size(23, 20);
            this.tbSeason.TabIndex = 32;
            this.tbSeason.TextChanged += new System.EventHandler(this.tbSeason_TextChanged);
            // 
            // lblSeasonCaption
            // 
            this.lblSeasonCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeasonCaption.AutoSize = true;
            this.lblSeasonCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSeasonCaption.Location = new System.Drawing.Point(325, 24);
            this.lblSeasonCaption.Name = "lblSeasonCaption";
            this.lblSeasonCaption.Size = new System.Drawing.Size(46, 13);
            this.lblSeasonCaption.TabIndex = 31;
            this.lblSeasonCaption.Text = "Season:";
            // 
            // lblEpisodeCaption
            // 
            this.lblEpisodeCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEpisodeCaption.AutoSize = true;
            this.lblEpisodeCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEpisodeCaption.Location = new System.Drawing.Point(325, 54);
            this.lblEpisodeCaption.Name = "lblEpisodeCaption";
            this.lblEpisodeCaption.Size = new System.Drawing.Size(48, 13);
            this.lblEpisodeCaption.TabIndex = 33;
            this.lblEpisodeCaption.Text = "Episode:";
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Movie",
            "Series",
            "Episode",
            "Game"});
            this.cbType.Location = new System.Drawing.Point(245, 51);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(69, 21);
            this.cbType.TabIndex = 4;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLanguage.Location = new System.Drawing.Point(95, 117);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(0, 13);
            this.lblLanguage.TabIndex = 21;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDirector.Location = new System.Drawing.Point(95, 139);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(0, 13);
            this.lblDirector.TabIndex = 22;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGenre.Location = new System.Drawing.Point(95, 159);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(0, 13);
            this.lblGenre.TabIndex = 23;
            // 
            // tbPlot
            // 
            this.tbPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPlot.Location = new System.Drawing.Point(360, 219);
            this.tbPlot.Multiline = true;
            this.tbPlot.Name = "tbPlot";
            this.tbPlot.ReadOnly = true;
            this.tbPlot.Size = new System.Drawing.Size(272, 147);
            this.tbPlot.TabIndex = 25;
            this.tbPlot.DoubleClick += new System.EventHandler(this.tbPlot_DoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.Location = new System.Drawing.Point(547, 648);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbliDBRating
            // 
            this.lbliDBRating.AutoSize = true;
            this.lbliDBRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbliDBRating.Location = new System.Drawing.Point(95, 179);
            this.lbliDBRating.Name = "lbliDBRating";
            this.lbliDBRating.Size = new System.Drawing.Size(0, 13);
            this.lbliDBRating.TabIndex = 27;
            // 
            // lbliDBRatingCaption
            // 
            this.lbliDBRatingCaption.AutoSize = true;
            this.lbliDBRatingCaption.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbliDBRatingCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbliDBRatingCaption.Location = new System.Drawing.Point(15, 179);
            this.lbliDBRatingCaption.Name = "lbliDBRatingCaption";
            this.lbliDBRatingCaption.Size = new System.Drawing.Size(71, 13);
            this.lbliDBRatingCaption.TabIndex = 26;
            this.lbliDBRatingCaption.Text = "IMDB Rating:";
            // 
            // lblCastCation
            // 
            this.lblCastCation.AutoSize = true;
            this.lblCastCation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCastCation.Location = new System.Drawing.Point(357, 117);
            this.lblCastCation.Name = "lblCastCation";
            this.lblCastCation.Size = new System.Drawing.Size(31, 13);
            this.lblCastCation.TabIndex = 28;
            this.lblCastCation.Text = "Cast:";
            // 
            // tbCast
            // 
            this.tbCast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbCast.Location = new System.Drawing.Point(360, 139);
            this.tbCast.Multiline = true;
            this.tbCast.Name = "tbCast";
            this.tbCast.ReadOnly = true;
            this.tbCast.Size = new System.Drawing.Size(231, 53);
            this.tbCast.TabIndex = 29;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Image = global::MediaDataConfig.Properties.Resources.system_config_services1;
            this.btnSettings.Location = new System.Drawing.Point(606, 31);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(45, 45);
            this.btnSettings.TabIndex = 30;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pbPoster
            // 
            this.pbPoster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbPoster.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbPoster.Location = new System.Drawing.Point(18, 223);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(300, 450);
            this.pbPoster.TabIndex = 8;
            this.pbPoster.TabStop = false;
            this.pbPoster.Click += new System.EventHandler(this.pbPoster_Click);
            // 
            // MediaDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 688);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.tbCast);
            this.Controls.Add(this.lblCastCation);
            this.Controls.Add(this.lbliDBRating);
            this.Controls.Add(this.lbliDBRatingCaption);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbPlot);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblPlotCaption);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lvMovies);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pbPoster);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MediaDetailsForm";
            this.Text = "MovieMatch 2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MediaDetailsForm_FormClosing);
            this.Load += new System.EventHandler(this.MediaDetailsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Button btnExact;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPlotCaption;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ListView lvMovies;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox tbPlot;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbliDBRating;
        private System.Windows.Forms.Label lbliDBRatingCaption;
        private System.Windows.Forms.Label lblCastCation;
        private System.Windows.Forms.TextBox tbCast;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TextBox tbEpisode;
        private System.Windows.Forms.Label lblEpisodeCaption;
        private System.Windows.Forms.TextBox tbSeason;
        private System.Windows.Forms.Label lblSeasonCaption;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

