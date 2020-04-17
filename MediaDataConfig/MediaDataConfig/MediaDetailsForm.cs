using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Media;
using System.Diagnostics;
using OpenSubtitlesDotNET;

namespace MediaDataConfig
{
    public partial class MediaDetailsForm : Form
    {
        private StarRatingControl m_starRatingControl;
        private UserSettings Settings;
        MediaDetailsFormHelper helper;

        public MediaDetailsForm(string initialSearchTxt)
        {
            InitializeComponent();
            Settings = UserSettings.Load();
            helper = new MediaDetailsFormHelper();
            helper.SetSettings(Settings);

            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(_DragEnter);
            this.DragDrop += new DragEventHandler(_DragDrop);
            m_starRatingControl = new StarRatingControl();
            m_starRatingControl.Top = 175;
            m_starRatingControl.Left = 130;
            Controls.Add(m_starRatingControl);
            lvMovies.View = View.Details;
            lvMovies.LabelEdit = false;
            lvMovies.AllowColumnReorder = true;
            lvMovies.FullRowSelect = true;
            lvMovies.GridLines = true;
            lvMovies.Sorting = SortOrder.Ascending;
            lvMovies.Columns.Add("Best Matches", -2, HorizontalAlignment.Left);
            lblSeasonCaption.Visible = false;
            lblEpisodeCaption.Visible = false;
            tbSeason.Visible = false;
            tbEpisode.Visible = false;
            if (!String.IsNullOrEmpty(initialSearchTxt))
            {
                btnOk.Enabled = EnableDisableApplyMovie() || EnableDisableApplyEpisode();
                SearchFromFile(initialSearchTxt);
            }
        }

        private void _DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void _DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                btnOk.Enabled = EnableDisableApplyMovie() || EnableDisableApplyEpisode();
                SearchFromFile(files[0]);
            }
        }
        private void SearchFromFile(string initialSearchTxt)
        {
            helper.Applied = false;
            helper.MediaPath = initialSearchTxt;
            helper.IsDirectory = Directory.Exists(helper.MediaPath);
            helper.IsFile = File.Exists(helper.MediaPath);
            var mediaDetails = new MediaDetails(helper.MediaPath, helper.ShowsConversionTable);
            helper.IsEpisode = mediaDetails.IsEpisode;
            helper.SeasonNumber = mediaDetails.Season.ToString();
            helper.EpisodeNumber = mediaDetails.Episode.ToString();
            GetDetailsFromWebAsync(Settings.OmdbUrl + mediaDetails.BuildUrlParams(false));
            lvMovies.Visible = false;
        }

        private void GetDetailsFromWebAsync(string webRequestUrl)
        {
            lblMessage.Text = "Loading...";
            pbPoster.Image = null;
            pbPoster.ImageLocation = "";
            BackgroundWorker bgWorker;
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(WebRequestReturned);
            bgWorker.RunWorkerAsync(webRequestUrl);
            Cursor.Current = Cursors.WaitCursor;
        }

        private string GetDetailsFromWeb(string webRequestUrl)
        {
            Cursor.Current = Cursors.WaitCursor;
            WebRequest request = WebRequest.Create(webRequestUrl);
            request.Timeout = 7000;
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception)
            {
                return "{\"Error\":\"Unable to connect to server\"}";
            }
            Console.WriteLine(response.StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            Cursor.Current = Cursors.Arrow;
            return responseFromServer;
        }

        private void SetErrorDetailsView(MediaDetails mediaDetails)
        {
            lblMessage.Text = mediaDetails.error;
            pbPoster.Image = null;
            pbPoster.ImageLocation = "";
            if (!String.IsNullOrEmpty(helper.MediaPath))
            {
                mediaDetails = new MediaDetails(helper.MediaPath, helper.ShowsConversionTable);
                tbTitle.Text = mediaDetails.title;
                tbYear.Text = mediaDetails.year;
                DisplayEpisodeDetails();
            }
        }

        private void SetSuccessDetailsView(MediaDetails mediaDetails)
        {
            lblMessage.Text = "";
            tbTitle.Text = mediaDetails.CleanTitle();
            tbCast.Text = mediaDetails.actors;
            string year = Regex.Replace(mediaDetails.year, "[^0-9]", "");
            if (year.Length > 4)
                year = year.Substring(0, year.Length - 4);
            tbYear.Text = year;
            lblLanguage.Text = mediaDetails.language;
            cbType.SelectedIndex = cbType.FindString(mediaDetails.type);
            tbPlot.Text = mediaDetails.plot;
            lblGenre.Text = mediaDetails.genre;
            lblDirector.Text = mediaDetails.director;
            lbliDBRating.Text = mediaDetails.imdbRating;
            helper.ImdbId = mediaDetails.imdbID.Replace("tt", "");
            DisplayEpisodeDetails();
            double rating;
            bool hasRating = Double.TryParse(mediaDetails.imdbRating, out rating);
            m_starRatingControl.SelectedStar = hasRating ? (int)Math.Round(rating/* / 2*/, 0) : 0;
            m_starRatingControl.Refresh();
            pbPoster.Tag = mediaDetails.imdbID;
            if (mediaDetails.poster.Contains("http"))
            {
                pbPoster.Load(mediaDetails.poster);
                lblMessage.Text = "";
                pbPoster.Cursor = Cursors.Hand;
                lblMessage.Cursor = Cursors.Default;
            }
            else
            {
                pbPoster.Image = null;
                pbPoster.ImageLocation = "";
                lblMessage.Text = "Poster not available";
                pbPoster.Cursor = Cursors.Default;
                lblMessage.Cursor = Cursors.Hand;
            }
        }

        private void SetMovieDetails(string responseFromServer)
        {
            MediaDetails mediaDetails;
            string jsonString;
            try
            {
                jsonString = responseFromServer;
                mediaDetails = JsonConvert.DeserializeObject<MediaDetails>(jsonString);
            }
            catch (Exception)
            {
                mediaDetails = new MediaDetails();
                mediaDetails.error = "Server returned an Error";
            }

            if (!String.IsNullOrEmpty(mediaDetails.error))
            {
                SetErrorDetailsView(mediaDetails);
            }
            else
            {
                SetSuccessDetailsView(mediaDetails);
            }
            btnOk.Enabled = EnableDisableApplyMovie() || EnableDisableApplyEpisode();
         }

        private void DisplayEpisodeDetails()
        {
            lblSeasonCaption.Visible = helper.IsEpisode;
            lblEpisodeCaption.Visible = helper.IsEpisode;
            tbSeason.Visible = helper.IsEpisode;
            tbEpisode.Visible = helper.IsEpisode;
            tbSeason.Text = helper.SeasonNumber;
            tbEpisode.Text = helper.EpisodeNumber;
        }


        private void SetMoviesList(string responseFromServer)
        {
            lvMovies.Visible = true;
            lvMovies.Items.Clear();
            SearchResults searchResults = JsonConvert.DeserializeObject<SearchResults>(responseFromServer);
            if (!String.IsNullOrEmpty(searchResults.error))
            {
                lblMessage.Text = searchResults.error;
                pbPoster.Image = null;
                return;
            }
            foreach (MediaDetails mediaDetails in searchResults.search)
            {
                string title = mediaDetails.title + " (" + mediaDetails.year + ") - " + mediaDetails.type;
                ListViewItem item = new ListViewItem(title, 0);
                item.Tag = mediaDetails.imdbID;
                lvMovies.Items.Add(item);
            }
 
        }

        private void btnExact_Click(object sender, EventArgs e)
        {
            GetMovieDetails(true);
        }

        private void PopulateMediaDetails(MediaDetails mediaDetails)
        {
            mediaDetails.title = tbTitle.Text;
            mediaDetails.year = tbYear.Text;
            mediaDetails.type = (string)cbType.SelectedItem;
        }

        private void GetMovieDetails(bool shortPlot)
        {
            var mediaDetails = new MediaDetails();
            PopulateMediaDetails(mediaDetails);
            string responseFromServer = GetDetailsFromWeb(Settings.OmdbUrl + mediaDetails.BuildUrlParams(false, shortPlot));
            lvMovies.Items.Clear();
            SetMovieDetails(responseFromServer);
            lvMovies.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var mediaDetails = new MediaDetails();
            PopulateMediaDetails(mediaDetails);
            string responseFromServer = GetDetailsFromWeb(Settings.OmdbUrl + mediaDetails.BuildUrlParams(true));
            SetMoviesList(responseFromServer);
        }

        private void lvMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMovies.SelectedItems.Count > 0)
            {
                var item = lvMovies.SelectedItems[0];
                var mediaDetails = new MediaDetails();
                mediaDetails.imdbID = (string)item.Tag;
                string responseFromServer = GetDetailsFromWeb(Settings.OmdbUrl + mediaDetails.BuildUrlParamsById());
                SetMovieDetails(responseFromServer);
            }
        }

        private void ApplyEpisodeToFileSystem()
        {
            Cursor.Current = Cursors.WaitCursor;
            helper.ApplyEpisodeToFileSystem(tbTitle.Text, tbSeason.Text, tbEpisode.Text);
            btnOk.Enabled = EnableDisableApplyMovie() || EnableDisableApplyEpisode();
            Cursor.Current = Cursors.Arrow;
        }

        private void ApplyMovieToFileSystem()
        {
            Cursor.Current = Cursors.WaitCursor;
            bool isTvSeries = (cbType.SelectedIndex >=0 && ((string)(cbType.SelectedItem)).ToLower() == "series");
            helper.ApplyMovieToFileSystem(isTvSeries, pbPoster.ImageLocation, tbTitle.Text, tbYear.Text);
            btnOk.Enabled = EnableDisableApplyMovie() || EnableDisableApplyEpisode();
            Cursor.Current = Cursors.Arrow;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (EnableDisableApplyMovie())
            {
                ApplyMovieToFileSystem();
            }
            else if (EnableDisableApplyEpisode())
            {
                ApplyEpisodeToFileSystem();
            }
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = EnableDisableApplyMovie() || EnableDisableApplyEpisode();
        }

        private void tbYear_TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = EnableDisableApplyMovie() || EnableDisableApplyEpisode();
        }

        private void tbPlot_DoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbPlot.Text))
                GetMovieDetails(false);
        }

        private void lblPlotCaption_DoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbPlot.Text))
                GetMovieDetails(false);
        }

        private bool EnableDisableApplyEpisode()
        {
            int season=0, episode=0;
            bool enabled = (helper.IsEpisode &&
                helper.IsFile &&
                !String.IsNullOrEmpty(tbTitle.Text) &&
                !String.IsNullOrEmpty(tbSeason.Text)  &&
                !String.IsNullOrEmpty(tbEpisode.Text) &&
                int.TryParse(tbSeason.Text, out season) &&
                int.TryParse(tbEpisode.Text, out episode) &&
                !helper.Applied);
            enabled = enabled && season > 0 && episode > 0;
            return enabled;
        }

        private bool EnableDisableApplyMovie()
        {
            bool enabled = (!helper.IsEpisode &&
                !String.IsNullOrEmpty(tbTitle.Text) &&
                !String.IsNullOrEmpty(tbYear.Text) &&
                !String.IsNullOrEmpty(pbPoster.ImageLocation) &&
                (helper.IsFile || helper.IsDirectory) &&
                !helper.Applied);
            return enabled;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Cursor.Current = Cursors.WaitCursor;
                Close();
                return true;
            }
            if (keyData == Keys.Enter)
            {
                if (EnableDisableApplyMovie())
                {
                    ApplyMovieToFileSystem();
                    Cursor.Current = Cursors.WaitCursor;
                    Close();
                }
                else if (EnableDisableApplyEpisode())
                {
                    ApplyEpisodeToFileSystem();
                    Cursor.Current = Cursors.WaitCursor;
                    Close();
                }
                else
                {
                    SystemSounds.Beep.Play();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string webRequestUrl = (string)e.Argument;
            WebRequest request = WebRequest.Create(webRequestUrl);
            request.Timeout = 7000;
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response;
            string serverResponse;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                serverResponse = reader.ReadToEnd();
            }
            catch (Exception)
            {
                serverResponse = "{\"Error\":\"Unable to connect to server\"}";
            }
            //Cursor.Current = Cursors.Arrow;
            e.Result = serverResponse;
        }

        void WebRequestReturned(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                string responseFromServer = (string)e.Result;
                SetMovieDetails(responseFromServer);
                Cursor.Current = Cursors.Arrow;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm(Settings);
            settingsForm.ShowDialog();
            Settings = UserSettings.Load();
            helper.SetSettings(Settings);
        }

        private void btnSetEpisode_Click(object sender, EventArgs e)
        {
            ApplyEpisodeToFileSystem();
        }

        private void tbSeason_TextChanged(object sender, EventArgs e)
        {
            EnableDisableApplyEpisode();
        }

        private void tbEpisode_TextChanged(object sender, EventArgs e)
        {
            EnableDisableApplyEpisode();
        }

        private bool SeriesFolderExist()
        {
            string episodeFolder = Path.Combine(Settings.SeriesPath, tbTitle.Text);
            return Settings.MoveEpisode && Directory.Exists(episodeFolder);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (!IsFile)
            //    return;
            //DownloadSubtitles(MediaPath);
            /*
            OSLanguage hebLang = new OSLanguage("heb", "he", "Hebrew", true, true);
            List<SearchSubtitleResult> subtitleList = subtitlesSession.SearchByFile(new FileInfo(mediaPath), hebLang);
            if (subtitleList.Count > 0)
            {
                MemoryStream st = subtitlesSession.DownloadSubtitle(subtitleList[0]);
                string subtitlesPath = Path.Combine(Path.GetDirectoryName(mediaPath), Path.GetFileNameWithoutExtension(mediaPath) + ".srt");
                FileStream fs = new FileStream(subtitlesPath, FileMode.OpenOrCreate);
                st.WriteTo(fs);
                st.Flush();
                st.Close();
            }
            */
        }

        private void MediaDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void MediaDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (helper.SubtitlesSession != null)
            {
                bool res = helper.SubtitlesSession.LogOut();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void pbPoster_Click(object sender, EventArgs e)
        {
            OpenImdb();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {
            OpenImdb();
        }

        private void OpenImdb()
        {
            if (pbPoster.Tag != null)
                Process.Start("chrome.exe", "https://www.imdb.com/title/" + pbPoster.Tag);
        }

    }
}
