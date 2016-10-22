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
}
