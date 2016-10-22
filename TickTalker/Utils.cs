using System;
using System.IO;

namespace TickTalker
{
    internal static class Utils
    {
        internal static string GetAppDataPath()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dirName = new FileInfo(appDataPath).FullName;
            dirName += @"\TickTalker";

            if (!Directory.Exists(dirName))
            {
                Directory.CreateDirectory(dirName);
            }

            return dirName;
        }
    }
}
