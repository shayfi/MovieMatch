using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

namespace MediaDataConfig
{
    class SearchResults
    {
        public MediaDetails[] search { get; set; }
        public string error { get; set; }
    }
    public class MediaDetails
    {
     private UserSettings Settings;
     private static string[] blacklist = {"dvdrip", "hdrip", "brrip", "bdrip", "hdtv", "r5", "stv","hddvd", "hd",
                                             "unrated", "extended", "limited", "dvdscr", "screener", "retail",
                                             "720p", "1080p", "3d", "web-dl"};
     private static char[] Separators = new char[] { '.', '_', '-', '(', ')', '{', '}' }; 
     public bool IsEpisode { get; set; }
     public int Season { get; set; }
     public int Episode { get; set; }
     //Data members that represent the Json structure returned from OMDBApi
     public string title {get; set;}
     public string year { get; set; }
     public string rated { get; set; }
     public string released { get; set; }
     public string runtime { get; set; }
     public string genre { get; set; }
     public string director { get; set; }
     public string writer { get; set; }
     public string actors { get; set; }
     public string plot { get; set; }
     public string language { get; set; }
     public string country { get; set; }
     public string awards { get; set; }
     public string poster { get; set; }
     public string metascore { get; set; }
     public string imdbRating { get; set; }
     public string imdbVotes { get; set; }
     public string imdbID { get; set; }
     public string type { get; set; }
     public string error { get; set; }

     public MediaDetails()
     {
         Settings = UserSettings.Load();
     }

     public MediaDetails(string filePath, Dictionary<string, string> ShowsConversionTable)
     {
         Settings = UserSettings.Load();
         IsEpisode = false;
         string fileName = Path.GetFileNameWithoutExtension(filePath);

         string[] temp = fileName.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
         fileName = String.Join(" ", temp);

         string[] nameTokens = fileName.Split(' ');
         int number;
         foreach (string token in nameTokens)
         {
             if (int.TryParse(token, out number) && number > 1900 & number < 3000)
             {
                 // This is the movie year.
                 // Save it properly and stop parsing.
                 year = token;
             }
             else if (int.TryParse(token, out number) && (number > 99 & number < 1900) || (number > 10000))
             {
                 // This is the episode number in format of "114" or "11415".
                 // Treat the string as series name and stop parsing.
                 IsEpisode = true;
                 type = "series";
                 var episodeNumber = token;
                 if (number > 10000)
                     episodeNumber = token.Substring(0, token.Length - 2);
                 int episodePosition = episodeNumber.Length - 2;
                 Season = Int32.Parse(episodeNumber.Substring(0, episodePosition));
                 Episode = Int32.Parse(episodeNumber.Substring(episodePosition, 2));
                 break;
             }
             else if (Regex.IsMatch(token, @"^.*S\d\dE\d\d", RegexOptions.IgnoreCase))
             {
                 // This is the episode number in format of "S01E14"
                 // Treat the string as series name and stop parsing.
                 IsEpisode = true;
                 type = "series";
                 Season = Int32.Parse(token.Substring(1, 2));
                 Episode = Int32.Parse(token.Substring(4, 2));
                 break;
             }
             else
             {
                 if (Array.IndexOf(blacklist, token.ToLower()) >= 0)
                     break;
                 else if (String.IsNullOrEmpty(year))
                     title += token + " ";
             }
         }
         if (IsEpisode)
             title = AdjustShowName(title, ShowsConversionTable);
     }

     public static string GetNormalizedMovieName(string filePath)
     {
         string fileName = Path.GetFileNameWithoutExtension(filePath);
         fileName = fileName.Replace(' ', '.');
         return fileName + Path.GetExtension(filePath);
     }

     public static string GetNormalizedEpisodeName(string filePath, string Season, string Episode)
     {
        string fileName = Path.GetFileNameWithoutExtension(filePath);
        string[] temp = fileName.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
        string parsedFileName = String.Join(" ", temp);
        string[] nameTokens = parsedFileName.Split(' ');
        int number;
        string episodeToken = "";
        bool doubleEpisode = false;
        bool numericEpisode = false;
        bool lowerCaseName = nameTokens[0].Equals(nameTokens[0].ToLower());
        for (int pos = 0; pos < (nameTokens.Length > 1 ? 2 : 1); pos++)
        {
            lowerCaseName = nameTokens[pos].Equals(nameTokens[pos].ToLower());
            if (!lowerCaseName)
                break;
        }
        foreach (string token in nameTokens)
        {
            if (String.IsNullOrEmpty(episodeToken) &&
                int.TryParse(token, out number) && number > 1900 & number < 3000)
            {
                // This is the series year.
            }
            else if (String.IsNullOrEmpty(episodeToken) &&
                (int.TryParse(token, out number) &&
                (number > 99 & number < 1900) || (number > 10000)))
            {
                // This is the episode number in format of "114" or "11415".
                episodeToken = token;
                doubleEpisode = (number > 10000);
                numericEpisode = true;
            }
            else if (Regex.IsMatch(token, @"^.*S\d\dE\d\d", RegexOptions.IgnoreCase))
            {
                // This is the episode number in format of "S01E14"
                episodeToken = token;
                doubleEpisode = token.Length > 6;
            }
            if (String.IsNullOrEmpty(episodeToken))
            {
                //this is a word from the series name - capitalyze it
                if (lowerCaseName)
                    fileName = fileName.Replace(token, CultureInfo.CurrentCulture.TextInfo.ToTitleCase(token));
            }
            else
            {
                //this is the group name or the format - make it all capital case
                if (lowerCaseName)
                    fileName = fileName.Replace(token, token.ToUpper());
            }
        }
        if (!String.IsNullOrEmpty(episodeToken) && numericEpisode)
        {
            string newEpisodeToken;
            if (!doubleEpisode)
            {
                newEpisodeToken = String.Format("S{0}E{1}", Season.PadLeft(2, '0'), Episode.PadLeft(2, '0'));
            }
            else
            {
                string nextEpisode = (Int32.Parse(Episode) + 1).ToString();
                newEpisodeToken = String.Format("S{0}E{1}E{2}", Season.PadLeft(2, '0'), Episode.PadLeft(2, '0'), nextEpisode.PadLeft(2, '0'));
            }
            fileName = fileName.Replace(episodeToken, newEpisodeToken);
        }
        fileName = fileName.Replace(' ', '.');
        return fileName + Path.GetExtension(filePath);
     }

     public string BuildUrlParamsById(bool shortPlot = true)
     {
         string urlParams = "";
         urlParams += AddParam(urlParams, "apikey", Settings.ApiKey);
         urlParams += AddParam(urlParams, "i", imdbID);
         if (!shortPlot)
             urlParams += AddParam(urlParams, "plot", "full");

         return urlParams;
     }

     public string BuildUrlParams(bool search, bool shortPlot = true, bool xmlResponse = false)
     {
         string urlParams = "";
         urlParams += AddParam(urlParams, "apikey", Settings.ApiKey);
         urlParams += AddParam(urlParams, search ? "s" : "t", title);
         urlParams += AddParam(urlParams, "y", year);
         urlParams += AddParam(urlParams, "type", type);
         if (!shortPlot)
             urlParams += AddParam(urlParams, "plot", "full");
         if (xmlResponse)
             urlParams += AddParam(urlParams, "r", "xml");

         return urlParams;
     }

     private string AddParam(string urlParams, string key, string value)
     {
         string newParam = "";
         if (!String.IsNullOrEmpty(value))
             newParam = String.Format("{0}{1}={2}", urlParams.Contains('=') ? "&" : "?", key, value);
         return newParam;
     }

     public string CleanTitle()
     {
         return Path.GetInvalidFileNameChars().Aggregate(title, (current, c) => current.Replace(c.ToString(), string.Empty));
     }

     private string AdjustShowName(string title, Dictionary<string, string> ShowsConversionTable)
     {
         string newTitle = null;
         ShowsConversionTable.TryGetValue(title.ToLower().Trim(' '), out newTitle);
         return String.IsNullOrEmpty(newTitle) ? title : newTitle;
     }

    }

}
