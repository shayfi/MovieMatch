using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace MediaDataConfig
{
    class Utils
    {
        public static string SerializeToString(object obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());

            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);

                return writer.ToString();
            }
        }

        public static object DeserializeFromString(string xmlNode, object myObject)
        {
            object deserializedObject;
            // Construct an instance of the XmlSerializer with the type
            // of object that is being deserialized.
            XmlSerializer mySerializer = new XmlSerializer(myObject.GetType());
            // To read the file, create a FileStream.
            using (TextReader reader = new StringReader(xmlNode))
            {
                deserializedObject = mySerializer.Deserialize(reader);
            }
            return deserializedObject;
        }

        public static Dictionary<string, string> GetShowsConversionTable(UserSettings Settings)
        {
            Dictionary<string, string> ShowsConversionTable = new Dictionary<string, string>();
            string[] words = Settings.ShowsConversionTable.Split(';');
            string[] pairSeparators = new string[] {"=>"};
            char[] trimChars = new char[] {'\n', ' '};
            foreach (string word in words)
            {
                string[] pair = word.Split(pairSeparators, StringSplitOptions.None);
                if (pair.Count() == 2)
                    ShowsConversionTable.Add(pair[0].Trim(trimChars).ToLower(), pair[1].Trim(trimChars));
            }
            return ShowsConversionTable;
        }

        static public void CopyFolder(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                File.Copy(file, dest);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                CopyFolder(folder, dest);
            }
        }

        public static void Empty(DirectoryInfo directory)
        {
            foreach (FileInfo file in directory.GetFiles())
                file.Delete();
        }
    }
}
