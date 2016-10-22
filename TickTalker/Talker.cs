using System;
using System.Collections.Generic;
using System.Text;
using System.Speech.Synthesis;

namespace TickTalker
{
    class Talker
    {
        private SpeechSynthesizer _ss = new SpeechSynthesizer();

        public Talker()
        {
            _ss.Rate = Settings.SpeakingRate;
            _ss.Volume = 100;

            // Do this so Windows registers TickTalker in the volume mixer
            _ss.SpeakAsync(""); 
        }

        public SpeechSynthesizer SynthObj
        {
            get { return _ss; }
        }

        public void ProcessTick()
        {
            if (isQuietTime())
                return;

            if (Settings.AnnounceOnTheHour)
            {
                if (DateTime.Now.Minute == 0)
                {
                    _ss.SpeakAsync("It's " + DateTime.Now.ToShortTimeString());
                }
                else if (Settings.WarnInAdvance && DateTime.Now.Minute == (60 - Settings.MinutesInAdvance))
                {
                    _ss.SpeakAsync("It's almost " + (DateTime.Now.AddMinutes(Settings.MinutesInAdvance).ToShortTimeString()));
                }
            }

            if (Settings.AnnounceOnTheHalfHour)
            {
                if (DateTime.Now.Minute == 30)
                {
                    _ss.SpeakAsync("It's " + DateTime.Now.ToShortTimeString());
                }
                else if (Settings.WarnInAdvance && DateTime.Now.Minute == (30 - Settings.MinutesInAdvance))
                {
                    _ss.SpeakAsync("It's almost " + (DateTime.Now.AddMinutes(Settings.MinutesInAdvance).ToShortTimeString()));
                }
            }
        }

        private bool isQuietTime()
        {
            if (!Settings.QuietTimeEnabled)
                return false;

            int currHour = DateTime.Now.Hour;

            // If quiet span crosses midnight
            if (Settings.QuietStartHour > Settings.QuietEndHour)
            {
                return ((currHour >= Settings.QuietStartHour) || (currHour < Settings.QuietEndHour));
            }
            // If quiet span does not cross midnight
            else if (Settings.QuietStartHour < Settings.QuietEndHour)
            {
                return ((currHour >= Settings.QuietStartHour) && (currHour < Settings.QuietEndHour));
            }

            return (currHour == Settings.QuietStartHour);
        }
    }
}
