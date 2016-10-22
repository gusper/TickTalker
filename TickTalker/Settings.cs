using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace TickTalker
{
    public class SettingsData
    {
        public bool AnnounceOnTheHour = true;
        public bool AnnounceOnTheHalfHour = true;
        public bool WarnInAdvance = false;
        public int MinutesInAdvance = 5;
        public int SpeakingRate = -3;
        public bool QuietTimeEnabled = false;
        public int QuietStartHour = 20;
        public int QuietEndHour = 7;
    }

    public static class Settings
    {
        private static SettingsData _data;
        private static string _path;
        private const string filename = @"\settings.xml";

        static Settings()
        {
            _path = Utils.GetAppDataPath();

            if (_data == null)
            {
                if (File.Exists(_path + filename))
                {
                    using (var fs = new FileStream(_path + filename, FileMode.Open))
                    {
                        var xs = new XmlSerializer(typeof(SettingsData));
                        _data = (SettingsData)xs.Deserialize(fs);
                    }
                }
                else
                {
                    _data = new SettingsData();
                }
            }
        }

        public static void Save()
        {
            using (TextWriter tw = new StreamWriter(_path + filename))
            {
                var xs = new XmlSerializer(typeof(SettingsData));
                xs.Serialize(tw, _data);
            }
        }

        public static bool AnnounceOnTheHour
        {
            get
            {
                return _data.AnnounceOnTheHour;
            }
            set
            {
                _data.AnnounceOnTheHour = value;
            }
        }

        public static bool AnnounceOnTheHalfHour 
        {
            get
            {
                return _data.AnnounceOnTheHalfHour;
            }
            set
            {
                _data.AnnounceOnTheHalfHour = value;
            }
        }

        public static bool WarnInAdvance 
        {
            get
            {
                return _data.WarnInAdvance;
            }
            set
            {
                _data.WarnInAdvance = value;
            }
        }

        public static int MinutesInAdvance 
        {
            get
            {
                return _data.MinutesInAdvance;
            }
            set
            {
                _data.MinutesInAdvance = value;
            }
        }
        
        public static int SpeakingRate
        {
            get
            {
                return _data.SpeakingRate;
            }
            set
            {
                _data.SpeakingRate = value;
            }
        }

        public static bool QuietTimeEnabled
        {
            get
            {
                return _data.QuietTimeEnabled;
            }
            set
            {
                _data.QuietTimeEnabled = value;
            }
        }

        public static int QuietStartHour
        {
            get
            {
                return _data.QuietStartHour;
            }
            set
            {
                _data.QuietStartHour = value;
            }
        }

        public static int QuietEndHour
        {
            get
            {
                return _data.QuietEndHour;
            }
            set
            {
                _data.QuietEndHour = value;
            }
        }
    }
}
