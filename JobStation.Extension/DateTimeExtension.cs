using System;

namespace JobStation.Extension
{
    public static class DateTimeExtension
    {
        public static DateTimeOffset ConvertToUserTime(this DateTimeOffset value, string timeZoneId)
        {
            try
            {
                TimeZoneInfo timezone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
                var newDateTime = TimeZoneInfo.ConvertTime(value, timezone);
                return newDateTime;
            }
            catch
            {
                return value;
            }
        }
    }
}
