using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.ComponentModel;

namespace MediaDataConfig
{
    public class UserSettings
    {
        public bool MoveEpisode { get; set; }
        public string SeriesPath { get; set; }
        public string OmdbUrl { get; set; }
        public bool MoveMovie { get; set; }
        public string MoviesPath { get; set; }
        public bool DownloadSubtitles { get; set; }
        public string OpensubtitlesUsername { get; set; }
        public string OpensubtitlesPassword { get; set; }
        public string SubtitlesLanguage { get; set; }
        public string ShowsConversionTable { get; set; }
        public string ApiKey { get; set; }

        public static UserSettings Default()
        {
            UserSettings settings = new UserSettings();
            settings.SeriesPath = "C:";
            settings.MoviesPath = "C:";
            settings.OmdbUrl = "http://omdbapi.com/";
            settings.MoveEpisode = false;
            settings.MoveMovie = false;
            settings.DownloadSubtitles = false;
            settings.OpensubtitlesUsername = "";
            settings.OpensubtitlesPassword = "";
            settings.SubtitlesLanguage = "heb";
            settings.ShowsConversionTable = "";
            settings.ApiKey = "";

            return settings; 
        }

        private static object GetDefaultValue(string SettingName)
        {
            var settings = UserSettings.Default();
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(settings))
            {
                if (SettingName.Equals(descriptor.Name))
                    return descriptor.GetValue(settings);
            }
            return null;
        }

        public static UserSettings Load()
        {
            bool saveRequired = false;
            UserSettings settings = new UserSettings();
            string xmlNode = (string)Properties.Settings.Default["AllSettings"];
            try
            {
                settings = (UserSettings)Utils.DeserializeFromString(xmlNode, settings);
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(settings))
                {
                    object value = descriptor.GetValue(settings);
                    if (value == null)
                    {
                       object defaultValue = GetDefaultValue(descriptor.Name);
                       descriptor.SetValue(settings, defaultValue);
                       saveRequired = true;
                    }
                }
                if (saveRequired)
                    settings.Save();
            }
            catch (Exception)
            {
                settings = UserSettings.Default();
                settings.Save();
            }
            return settings;
        }
        
        public void Save()
        {
            string xmlNode = Utils.SerializeToString(this);
            Properties.Settings.Default["AllSettings"] = xmlNode;
            Properties.Settings.Default.Save();
        }

    }
}
