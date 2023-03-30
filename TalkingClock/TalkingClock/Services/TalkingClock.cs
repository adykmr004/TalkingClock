using System;
using TalkingClock.Utils;

namespace TalkingClock
{
    public class TalkingClock : ITalkingClock
    {
        public string GetTimeToHumanFriendlyText(string time)
        {
            DateTime currentTime = DateTime.Now;

            if (!String.IsNullOrEmpty(time))
            {
                if (!DateTime.TryParse(time, out currentTime))
                {
                    return "Invalid time format. Please use HH:mm format.";
                }
            }

            int hour = currentTime.Hour % 12;
            int minute = currentTime.Minute;
            string humanfriendlytimeText = string.Empty;


            if (minute == 0)
            {
                humanfriendlytimeText = $"{Constants.HourToText[hour]} o'clock";
            }
            else if (minute < 10)
            {
                humanfriendlytimeText = $"{Constants.oneDigitToText[minute]} past {Constants.HourToText[hour]}";
            }
            else if (minute < 20)
            {
                humanfriendlytimeText = $"{Constants.teensToText[minute % 10]} past {Constants.HourToText[hour]}";
            }
            else if (minute < 30)
            {
                humanfriendlytimeText = $"{Constants.tensToText[minute / 10]} {Constants.oneDigitToText[minute % 10]} past {Constants.HourToText[hour]}";
            }
            else if (minute == 30)
            {
                humanfriendlytimeText = $"Half past {Constants.HourToText[hour]}";
            }
            else
            {
                hour = (hour + 1) % 12;
                var minutesTo = 60 - minute;

                if (minutesTo < 10)
                {
                    humanfriendlytimeText = $"{Constants.oneDigitToText[minutesTo]} to {Constants.HourToText[hour]}";
                }
                else if (minutesTo < 20)
                {
                    humanfriendlytimeText = $"{Constants.teensToText[minutesTo % 10]} to {Constants.HourToText[hour]}";
                }
                else
                {
                    humanfriendlytimeText = $"{Constants.tensToText[minutesTo / 10]} {Constants.oneDigitToText[minutesTo % 10]} to {Constants.HourToText[hour]}";
                }
            }
            return humanfriendlytimeText;
        }
    }
}
