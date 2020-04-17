using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenSubtitlesDotNET;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace MediaDataConfig
{
    class MediaDetailsFormHelper
    {
        public bool IsDirectory { set; get; }
        public bool IsFile { set; get; }
        public bool IsEpisode { set; get; }
        public bool Applied { set; get; }
        public string SeasonNumber { set; get; }
        public string EpisodeNumber { set; get; }
        public string ImdbId { set; get; }
        public string MediaPath { set; get; }
        public OSDotNetSession SubtitlesSession;
        public OSLanguage SubtitlesLang { set; get; }
        public UserSettings Settings { set; get; }
        public Dictionary<string, string> ShowsConversionTable { set; get; }

        public void SetSettings(UserSettings settings)
        {
            Settings = settings;
            ShowsConversionTable = Utils.GetShowsConversionTable(Settings);
            SubtitlesLang = new OSLanguage(String.IsNullOrEmpty(Settings.SubtitlesLanguage) ? "all" : Settings.SubtitlesLanguage, "", "", true, true);
        }

        public void ApplyEpisodeToFileSystem(string TitleText, string SeasonText, string EpisodeText)
        {
            try
            {
                string newFilePath;
                if (Settings.MoveEpisode && Directory.Exists(Settings.SeriesPath))
                {
                    string episodeFolder = Path.Combine(Settings.SeriesPath, TitleText);
                    if (!Directory.Exists(episodeFolder))
                    {
                        Directory.CreateDirectory(episodeFolder);
                    }
                    string seasonFolder = String.Format("Season {0}", SeasonText);
                    string seasonPath = Path.Combine(episodeFolder, seasonFolder);
                    if (!Directory.Exists(seasonPath))
                    {
                        Directory.CreateDirectory(seasonPath);
                    }
                    newFilePath = Path.Combine(seasonPath, MediaDetails.GetNormalizedEpisodeName(MediaPath, SeasonText, EpisodeText));
                }
                else
                {
                    string mediaDirectory = Path.GetDirectoryName(MediaPath);
                    newFilePath = Path.Combine(mediaDirectory, MediaDetails.GetNormalizedEpisodeName(MediaPath, SeasonText, EpisodeText));
                }
                if (!Path.GetFullPath(MediaPath).Equals(Path.GetFullPath(newFilePath)))
                    File.Move(MediaPath, newFilePath);
                Applied = true;
                if (Settings.DownloadSubtitles)
                    DownloadSubtitles(newFilePath, TitleText);
                if (Settings.MoveEpisode && Directory.Exists(Settings.SeriesPath) && OpenDestinationFolder())
                    Process.Start("explorer.exe", Directory.GetParent(newFilePath).FullName);

            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show("Failed to apply chenges to file system. See error details?",
                                                        "Error",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Error);
                if (result == System.Windows.Forms.DialogResult.Yes)
                    throw ex;
            }
        }

        public void ApplyMovieToFileSystem(bool isTvSeries, string posterUrl, string TitleText, string YearText)
        {
            try
            {
                WebClient webClient = new WebClient();
                string downloadPath = "";
                string newFolderPath = "";
                string newFolderName;
                if (isTvSeries)
                    newFolderName = TitleText;
                else
                    newFolderName = String.Format("{0} ({1})", TitleText, YearText);
                if (IsDirectory)
                {
                    var parentDirectoryInfo = Directory.GetParent(MediaPath);
                    newFolderPath = Path.Combine(parentDirectoryInfo.FullName, newFolderName);
                    if (!Path.GetFullPath(MediaPath).Equals(Path.GetFullPath(newFolderPath)))
                        Directory.Move(MediaPath, newFolderPath);
                    MediaPath = newFolderName;
                }
                else if (IsFile)
                {
                    newFolderPath = Path.Combine(Path.GetDirectoryName(MediaPath), newFolderName);
                    if (!Directory.Exists(newFolderPath))
                    {
                        Directory.CreateDirectory(newFolderPath);
                        string mediaFileNewPath = Path.Combine(newFolderPath, MediaDetails.GetNormalizedMovieName(MediaPath));
                        File.Move(MediaPath, mediaFileNewPath);
                        if (Settings.DownloadSubtitles)
                            DownloadSubtitles(mediaFileNewPath, TitleText);
                    }
                }
                else
                    return;

                downloadPath = Path.Combine(newFolderPath, "folder.jpg");
                File.Delete(downloadPath);
                webClient.DownloadFile(posterUrl, downloadPath);
                File.SetAttributes(downloadPath, File.GetAttributes(downloadPath) | FileAttributes.Hidden);
                if (!isTvSeries && Settings.MoveMovie && Directory.Exists(Settings.MoviesPath))
                {
                    string movieFolderName = Path.GetFileName(newFolderPath);
                    var folderInMoviePath = Path.Combine(Settings.MoviesPath, movieFolderName);
                    if (!Path.GetFullPath(newFolderPath).Equals(Path.GetFullPath(folderInMoviePath)))
                    {
                        Utils.CopyFolder(newFolderPath, folderInMoviePath);
                        Utils.Empty(new DirectoryInfo(newFolderPath));
                        Directory.Delete(newFolderPath);
                    }
                    newFolderPath = folderInMoviePath;
                }
                Applied = true;
                if (!isTvSeries && Settings.MoveMovie && Directory.Exists(Settings.MoviesPath) && OpenDestinationFolder())
                    Process.Start("explorer.exe", newFolderPath);
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show("Failed to apply chenges to file system. See error details?",
                                                        "Error",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Error);
                if (result == System.Windows.Forms.DialogResult.Yes)
                    throw ex;
            }
        }

        private bool OpenDestinationFolder()
        {
            DialogResult result = MessageBox.Show("Media processing completed. Open destination folder?",
                                                        "Process Completed Successfully",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
            return (result == System.Windows.Forms.DialogResult.Yes);
        }

        private void DownloadSubtitles(string videoFilePath, string TitleText)
        {
            if (SubtitlesSession == null)
            {
                //subtitlesSession = OSDotNetSession.LogIn("shayfichman", "opensubtitles", "en", "moviematch v1.2");
                SubtitlesSession = OSDotNetSession.LogIn(Settings.OpensubtitlesUsername, Settings.OpensubtitlesPassword, "en", "moviematch v1.2");
                if (SubtitlesSession == null)
                    return;
            }

            List<SearchSubtitleResult> subtitleList = SubtitlesSession.SearchByFile(new FileInfo(videoFilePath), SubtitlesLang);
            if (subtitleList.Count == 0)
            {
                if (!IsEpisode)
                {
                    subtitleList = SubtitlesSession.SearchOnlyByImdbId(ImdbId, SubtitlesLang);
                    if (subtitleList.Count == 0)
                        subtitleList = SubtitlesSession.SearchOnlyByTag(Path.GetFileName(videoFilePath), SubtitlesLang);
                    if (subtitleList.Count == 0)
                        subtitleList = SubtitlesSession.SearchOnlyByQuery(TitleText, SubtitlesLang);
                }
                else
                {
                    subtitleList = SubtitlesSession.SearchOnlyByTag(Path.GetFileName(videoFilePath), SubtitlesLang);
                    if (subtitleList.Count == 0)
                        subtitleList = SubtitlesSession.SearchByEpisode(TitleText, SeasonNumber, EpisodeNumber, SubtitlesLang);
                }
            }

            if (subtitleList.Count > 0)
            {
                string subtitlesPath = Path.Combine(Path.GetDirectoryName(videoFilePath), Path.GetFileNameWithoutExtension(videoFilePath) + "." + subtitleList[0].SubFormat);
                if (!File.Exists(subtitlesPath))
                {
                    MemoryStream st = SubtitlesSession.DownloadSubtitle(subtitleList[0]);
                    using (FileStream fs = new FileStream(subtitlesPath, FileMode.OpenOrCreate))
                    {
                        st.WriteTo(fs);
                        st.Flush();
                        st.Close();
                    }
                }
            }
        }

    }
}
