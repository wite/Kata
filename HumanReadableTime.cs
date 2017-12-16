using System;
public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        var time = TimeSpan.FromSeconds(seconds);
        var totalHours = time.Days * 24 + time.Hours;

        return String.Format("{0}:{1}:{2}", totalHours.ToString("00"), time.Minutes.ToString("00"), time.Seconds.ToString("00"));
    }
}