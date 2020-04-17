namespace MediaDataConfig
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbSeriesPath = new System.Windows.Forms.TextBox();
            this.cbMoveEpisodes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.btnBrowseSeriesPath = new System.Windows.Forms.Button();
            this.cbOmdbUrl = new System.Windows.Forms.ComboBox();
            this.btnBrowseMoviesPath = new System.Windows.Forms.Button();
            this.cbMoveMovies = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMoviesPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDownloadSubtitles = new System.Windows.Forms.CheckBox();
            this.gbSubtitles = new System.Windows.Forms.GroupBox();
            this.pbOpenSubtitlesUser = new System.Windows.Forms.PictureBox();
            this.tbSubtitlesLanguage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOSPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOSUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbShowsConversionTable = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbApiKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbApiKey = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbSubtitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenSubtitlesUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApiKey)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSave.Location = new System.Drawing.Point(346, 530);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancel.Location = new System.Drawing.Point(223, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.Location = new System.Drawing.Point(15, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(96, 13);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Series Folder Path:";
            // 
            // tbSeriesPath
            // 
            this.tbSeriesPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSeriesPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbSeriesPath.Location = new System.Drawing.Point(115, 56);
            this.tbSeriesPath.Name = "tbSeriesPath";
            this.tbSeriesPath.ReadOnly = true;
            this.tbSeriesPath.Size = new System.Drawing.Size(242, 20);
            this.tbSeriesPath.TabIndex = 20;
            // 
            // cbMoveEpisodes
            // 
            this.cbMoveEpisodes.AutoSize = true;
            this.cbMoveEpisodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbMoveEpisodes.Location = new System.Drawing.Point(18, 24);
            this.cbMoveEpisodes.Name = "cbMoveEpisodes";
            this.cbMoveEpisodes.Size = new System.Drawing.Size(175, 17);
            this.cbMoveEpisodes.TabIndex = 21;
            this.cbMoveEpisodes.Text = "Move Episodes to Series Folder";
            this.cbMoveEpisodes.UseVisualStyleBackColor = true;
            this.cbMoveEpisodes.CheckedChanged += new System.EventHandler(this.cbMoveEpisodes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(24, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Omdb Url:";
            // 
            // btnDefaults
            // 
            this.btnDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDefaults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDefaults.Location = new System.Drawing.Point(27, 530);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(90, 25);
            this.btnDefaults.TabIndex = 24;
            this.btnDefaults.Text = "Defaults";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // btnBrowseSeriesPath
            // 
            this.btnBrowseSeriesPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSeriesPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBrowseSeriesPath.Location = new System.Drawing.Point(382, 50);
            this.btnBrowseSeriesPath.Name = "btnBrowseSeriesPath";
            this.btnBrowseSeriesPath.Size = new System.Drawing.Size(35, 30);
            this.btnBrowseSeriesPath.TabIndex = 25;
            this.btnBrowseSeriesPath.Text = "...";
            this.btnBrowseSeriesPath.UseVisualStyleBackColor = true;
            this.btnBrowseSeriesPath.Click += new System.EventHandler(this.btnBrowseSeriesPath_Click);
            // 
            // cbOmdbUrl
            // 
            this.cbOmdbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbOmdbUrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOmdbUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbOmdbUrl.FormattingEnabled = true;
            this.cbOmdbUrl.Items.AddRange(new object[] {
            "http://omdbapi.com/",
            "http://imdbapi.com/"});
            this.cbOmdbUrl.Location = new System.Drawing.Point(88, 456);
            this.cbOmdbUrl.Name = "cbOmdbUrl";
            this.cbOmdbUrl.Size = new System.Drawing.Size(130, 21);
            this.cbOmdbUrl.TabIndex = 26;
            // 
            // btnBrowseMoviesPath
            // 
            this.btnBrowseMoviesPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseMoviesPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBrowseMoviesPath.Location = new System.Drawing.Point(382, 51);
            this.btnBrowseMoviesPath.Name = "btnBrowseMoviesPath";
            this.btnBrowseMoviesPath.Size = new System.Drawing.Size(35, 30);
            this.btnBrowseMoviesPath.TabIndex = 30;
            this.btnBrowseMoviesPath.Text = "...";
            this.btnBrowseMoviesPath.UseVisualStyleBackColor = true;
            this.btnBrowseMoviesPath.Click += new System.EventHandler(this.btnBrowseMoviesPath_Click);
            // 
            // cbMoveMovies
            // 
            this.cbMoveMovies.AutoSize = true;
            this.cbMoveMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbMoveMovies.Location = new System.Drawing.Point(17, 19);
            this.cbMoveMovies.Name = "cbMoveMovies";
            this.cbMoveMovies.Size = new System.Drawing.Size(171, 17);
            this.cbMoveMovies.TabIndex = 29;
            this.cbMoveMovies.Text = "Move Movies to Movies Folder";
            this.cbMoveMovies.UseVisualStyleBackColor = true;
            this.cbMoveMovies.CheckedChanged += new System.EventHandler(this.cbMoveMovies_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Movies Folder Path:";
            // 
            // tbMoviesPath
            // 
            this.tbMoviesPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMoviesPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbMoviesPath.Location = new System.Drawing.Point(115, 57);
            this.tbMoviesPath.Name = "tbMoviesPath";
            this.tbMoviesPath.ReadOnly = true;
            this.tbMoviesPath.Size = new System.Drawing.Size(243, 20);
            this.tbMoviesPath.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnBrowseSeriesPath);
            this.groupBox1.Controls.Add(this.cbMoveEpisodes);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.tbSeriesPath);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 95);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnBrowseMoviesPath);
            this.groupBox2.Controls.Add(this.cbMoveMovies);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbMoviesPath);
            this.groupBox2.Location = new System.Drawing.Point(18, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 96);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // cbDownloadSubtitles
            // 
            this.cbDownloadSubtitles.AutoSize = true;
            this.cbDownloadSubtitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbDownloadSubtitles.Location = new System.Drawing.Point(16, 27);
            this.cbDownloadSubtitles.Name = "cbDownloadSubtitles";
            this.cbDownloadSubtitles.Size = new System.Drawing.Size(117, 17);
            this.cbDownloadSubtitles.TabIndex = 31;
            this.cbDownloadSubtitles.Text = "Download Subtitles";
            this.cbDownloadSubtitles.UseVisualStyleBackColor = true;
            this.cbDownloadSubtitles.CheckedChanged += new System.EventHandler(this.cbDownloadSubtitles_CheckedChanged);
            // 
            // gbSubtitles
            // 
            this.gbSubtitles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSubtitles.Controls.Add(this.pbOpenSubtitlesUser);
            this.gbSubtitles.Controls.Add(this.tbSubtitlesLanguage);
            this.gbSubtitles.Controls.Add(this.label5);
            this.gbSubtitles.Controls.Add(this.tbOSPassword);
            this.gbSubtitles.Controls.Add(this.label4);
            this.gbSubtitles.Controls.Add(this.tbOSUserName);
            this.gbSubtitles.Controls.Add(this.label3);
            this.gbSubtitles.Controls.Add(this.cbDownloadSubtitles);
            this.gbSubtitles.Location = new System.Drawing.Point(19, 232);
            this.gbSubtitles.Name = "gbSubtitles";
            this.gbSubtitles.Size = new System.Drawing.Size(432, 98);
            this.gbSubtitles.TabIndex = 33;
            this.gbSubtitles.TabStop = false;
            this.gbSubtitles.Text = "OpenSubtitles Settings";
            // 
            // pbOpenSubtitlesUser
            // 
            this.pbOpenSubtitlesUser.BackgroundImage = global::MediaDataConfig.Properties.Resources.question_mark_310100_16;
            this.pbOpenSubtitlesUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOpenSubtitlesUser.ErrorImage = null;
            this.pbOpenSubtitlesUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbOpenSubtitlesUser.InitialImage")));
            this.pbOpenSubtitlesUser.Location = new System.Drawing.Point(221, 29);
            this.pbOpenSubtitlesUser.Name = "pbOpenSubtitlesUser";
            this.pbOpenSubtitlesUser.Size = new System.Drawing.Size(16, 15);
            this.pbOpenSubtitlesUser.TabIndex = 40;
            this.pbOpenSubtitlesUser.TabStop = false;
            this.pbOpenSubtitlesUser.Click += new System.EventHandler(this.pbOpenSubtitlesUser_Click);
            // 
            // tbSubtitlesLanguage
            // 
            this.tbSubtitlesLanguage.Location = new System.Drawing.Point(123, 65);
            this.tbSubtitlesLanguage.Name = "tbSubtitlesLanguage";
            this.tbSubtitlesLanguage.Size = new System.Drawing.Size(64, 20);
            this.tbSubtitlesLanguage.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(13, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Language (3 letters):";
            // 
            // tbOSPassword
            // 
            this.tbOSPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOSPassword.Location = new System.Drawing.Point(327, 65);
            this.tbOSPassword.Name = "tbOSPassword";
            this.tbOSPassword.PasswordChar = '*';
            this.tbOSPassword.Size = new System.Drawing.Size(90, 20);
            this.tbOSPassword.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(243, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Password:";
            // 
            // tbOSUserName
            // 
            this.tbOSUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOSUserName.Location = new System.Drawing.Point(327, 27);
            this.tbOSUserName.Name = "tbOSUserName";
            this.tbOSUserName.Size = new System.Drawing.Size(90, 20);
            this.tbOSUserName.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(243, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "User name:";
            // 
            // tbShowsConversionTable
            // 
            this.tbShowsConversionTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShowsConversionTable.Location = new System.Drawing.Point(25, 362);
            this.tbShowsConversionTable.Multiline = true;
            this.tbShowsConversionTable.Name = "tbShowsConversionTable";
            this.tbShowsConversionTable.Size = new System.Drawing.Size(409, 71);
            this.tbShowsConversionTable.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(320, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Show names conversion table (example: Scandal US => Scandal;)";
            // 
            // tbApiKey
            // 
            this.tbApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApiKey.Location = new System.Drawing.Point(346, 457);
            this.tbApiKey.Name = "tbApiKey";
            this.tbApiKey.Size = new System.Drawing.Size(88, 20);
            this.tbApiKey.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(294, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Api Key:";
            // 
            // pbApiKey
            // 
            this.pbApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbApiKey.BackgroundImage = global::MediaDataConfig.Properties.Resources.question_mark_310100_16;
            this.pbApiKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbApiKey.ErrorImage = null;
            this.pbApiKey.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbApiKey.InitialImage")));
            this.pbApiKey.Location = new System.Drawing.Point(272, 460);
            this.pbApiKey.Name = "pbApiKey";
            this.pbApiKey.Size = new System.Drawing.Size(16, 15);
            this.pbApiKey.TabIndex = 39;
            this.pbApiKey.TabStop = false;
            this.pbApiKey.Click += new System.EventHandler(this.pbApiKey_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 580);
            this.Controls.Add(this.pbApiKey);
            this.Controls.Add(this.tbApiKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbShowsConversionTable);
            this.Controls.Add(this.gbSubtitles);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbOmdbUrl);
            this.Controls.Add(this.btnDefaults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbSubtitles.ResumeLayout(false);
            this.gbSubtitles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenSubtitlesUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApiKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbSeriesPath;
        private System.Windows.Forms.CheckBox cbMoveEpisodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.Button btnBrowseSeriesPath;
        private System.Windows.Forms.ComboBox cbOmdbUrl;
        private System.Windows.Forms.Button btnBrowseMoviesPath;
        private System.Windows.Forms.CheckBox cbMoveMovies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMoviesPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbDownloadSubtitles;
        private System.Windows.Forms.GroupBox gbSubtitles;
        private System.Windows.Forms.TextBox tbOSUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOSPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSubtitlesLanguage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbShowsConversionTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbApiKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbApiKey;
        private System.Windows.Forms.PictureBox pbOpenSubtitlesUser;
    }
}