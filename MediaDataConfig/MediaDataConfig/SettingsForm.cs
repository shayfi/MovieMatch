using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace MediaDataConfig
{
    public partial class SettingsForm : Form
    {
        UserSettings Settings;
        public SettingsForm(UserSettings currentSettings)
        {
            InitializeComponent();
            Settings = currentSettings;
            ShowSettings();
        }

        private void ShowSettings()
        {
            tbSeriesPath.Text = Settings.SeriesPath;
            cbMoveEpisodes.Checked = Settings.MoveEpisode;
            tbMoviesPath.Text = Settings.MoviesPath;
            cbMoveMovies.Checked = Settings.MoveMovie;
            cbOmdbUrl.SelectedIndex = cbOmdbUrl.FindString(Settings.OmdbUrl);
            cbDownloadSubtitles.Checked = Settings.DownloadSubtitles;
            tbOSUserName.Text = Settings.OpensubtitlesUsername;
            tbOSPassword.Text = Settings.OpensubtitlesPassword;
            tbSubtitlesLanguage.Text = Settings.SubtitlesLanguage;
            tbApiKey.Text = Settings.ApiKey;
            tbShowsConversionTable.Text = Settings.ShowsConversionTable.Replace(";\n", ";\r\n");

            EnableDisableSubtitles();
            EnableDisableMoveEpisodes();
            EnableDisableMoveMovies();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.SeriesPath = tbSeriesPath.Text;
            Settings.MoveEpisode = cbMoveEpisodes.Checked;
            Settings.MoviesPath = tbMoviesPath.Text;
            Settings.MoveMovie = cbMoveMovies.Checked;
            Settings.OmdbUrl = (string)cbOmdbUrl.SelectedItem;
            Settings.DownloadSubtitles = cbDownloadSubtitles.Checked;
            Settings.OpensubtitlesUsername = tbOSUserName.Text;
            Settings.OpensubtitlesPassword = tbOSPassword.Text;
            Settings.SubtitlesLanguage = tbSubtitlesLanguage.Text;
            Settings.ApiKey = tbApiKey.Text;
            Settings.ShowsConversionTable = tbShowsConversionTable.Text;
            Settings.Save();
            Close();
        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("Reset settings to default?",
                                                        "Reset Settings",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    DialogResult res = MessageBox.Show("This will delete all your current settings.\nAre you sure you want to reset settings to default?",
                                                        "Warning",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Asterisk);
                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        Settings = UserSettings.Default();
                        Settings.Save();
                        ShowSettings();
                    }
                }

        }

        private void btnBrowseSeriesPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (Directory.Exists(tbSeriesPath.Text))
            {
                browser.SelectedPath = tbSeriesPath.Text;
            }
            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbSeriesPath.Text = browser.SelectedPath;
            }
        }

        private void btnBrowseMoviesPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (Directory.Exists(tbMoviesPath.Text))
            {
                browser.SelectedPath = tbMoviesPath.Text;
            }
            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbMoviesPath.Text = browser.SelectedPath;
            }
        }

        private void pbApiKey_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Api Key from OmdbApi is required to retrieve media details.\nObtain it from http://www.omdbapi.com/apikey.aspx\nGet key now?",
                                                        "Get Api Key",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start("chrome.exe", "http://www.omdbapi.com/apikey.aspx");
            }
        }

        private void pbOpenSubtitlesUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("User for OpenSubtitles is required to download subtitles.\nCreate it on https://www.opensubtitles.org/he/newuser\nCreate new user now?",
                                                        "Create OpenSubtitles User",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start("chrome.exe", "https://www.opensubtitles.org/he/newuser");
            }

        }

        private void cbDownloadSubtitles_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableSubtitles();
        }


        private void cbMoveEpisodes_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableMoveEpisodes();
        }

        private void cbMoveMovies_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableMoveMovies();
        }

        private void EnableDisableSubtitles()
        {
            tbOSPassword.Enabled = tbOSUserName.Enabled = tbSubtitlesLanguage.Enabled = cbDownloadSubtitles.Checked;
        }
        
        private void EnableDisableMoveEpisodes()
        {
            btnBrowseSeriesPath.Enabled = cbMoveEpisodes.Checked;
        }

        private void EnableDisableMoveMovies()
        {
            btnBrowseMoviesPath.Enabled = cbMoveMovies.Checked;
        }


    }
}
