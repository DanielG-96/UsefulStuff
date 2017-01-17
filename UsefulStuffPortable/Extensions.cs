using System;

namespace UsefulStuffPortable.Extensions
{
    public static class Extensions
    {
        /// <summary>
        /// Gets if a string is null
        /// </summary>
        /// <param name="s">String to check</param>
        /// <returns>True if null, false if not</returns>
        public static bool IsNull(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        /// <summary>
        /// Converts a string to an integer
        /// </summary>
        /// <param name="s">String to convert</param>
        /// <returns>Integer value on success, 0 on failure</returns>
        public static int ToInt(this string s)
        {
            try
            {
                return int.Parse(s);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Converts a decimal to an integer
        /// </summary>
        /// <param name="d">Decimal to convert</param>
        /// <returns>Integer value on success, 0 on failure</returns>
        public static int ToInt(this decimal d)
        {
            try
            {
                return Convert.ToInt32(d);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Converts a string to a float (32-bit floating-point type)
        /// </summary>
        /// <param name="s">String to convert</param>
        /// <returns>Float value on success, 0 on failure</returns>
        public static float ToFloat(this string s)
        {
            try
            {
                return float.Parse(s);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Converts a string to a double (64-bit floating-point type)
        /// </summary>
        /// <param name="s">String to convert</param>
        /// <returns>Double value on success, 0 on failure</returns>
        public static double ToDouble(this string s)
        {
            try
            {
                return double.Parse(s);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Converts a string to a decimal (128-bit floating-point type)
        /// </summary>
        /// <param name="s">String to convert</param>
        /// <returns>Decimal value on success, 0 on failure</returns>
        public static decimal ToDecimal(this string s)
        {
            try
            {
                return decimal.Parse(s);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Removes the last character from a string
        /// </summary>
        /// <param name="instr">String to remove last character from</param>
        /// <returns>New string without last character</returns>
        public static string RemoveLastCharacter(this string instr)
        {
            return instr.Substring(0, instr.Length - 1);
        }

        /// <summary>
        /// Removes a specified number of last characters from a string
        /// </summary>
        /// <param name="instr">String to remove characters from</param>
        /// <param name="number">Number of characters to remove</param>
        /// <returns>New string without characters</returns>
        public static string RemoveLast(this string instr, int number)
        {
            return instr.Substring(0, instr.Length - number);
        }

        /// <summary>
        /// Removes the first character from a string
        /// </summary>
        /// <param name="instr">String to remove first character from</param>
        /// <returns>New string without first character</returns>
        public static string RemoveFirstCharacter(this string instr)
        {
            return instr.Substring(1);
        }

        /// <summary>
        /// Removes a specified number of first characters from a string
        /// </summary>
        /// <param name="instr">String to remove characters from</param>
        /// <param name="number">New string without characters</param>
        /// <returns></returns>
        public static string RemoveFirst(this string instr, int number)
        {
            return instr.Substring(number);
        }

        /// <summary>
        /// Checks if a date is between two dates
        /// </summary>
        /// <param name="dt">Date to check</param>
        /// <param name="rangeBeg">Date range beginning</param>
        /// <param name="rangeEnd">Date range ending</param>
        /// <returns>True if date is between two dates, false otherwise</returns>
        public static bool Between(this DateTime dt, DateTime rangeBeg, DateTime rangeEnd)
        {
            return dt.Ticks >= rangeBeg.Ticks && dt.Ticks <= rangeEnd.Ticks;
        }

        /// <summary>
        /// Figures out the age of someone or something
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns>Calculated age length</returns>
        public static int CalculateAge(this DateTime dateTime)
        {
            var age = DateTime.Now.Year - dateTime.Year;
            if (DateTime.Now < dateTime.AddYears(age))
            {
                age--;
            }
            return age;
        }

        /// <summary>
        /// Gets a readable sentence from a time (e.g. 2 seconds ago, 1 month ago)
        /// </summary>
        /// <param name="value">Date/time to get value from</param>
        /// <returns>Readable time</returns>
        [Obsolete("This method doesn't really work properly, use ToPrettyDate instead.")]
        public static string ToReadableTime(this DateTime value)
        {
            var ts = new TimeSpan(DateTime.UtcNow.Ticks - value.Ticks);
            double delta = ts.TotalSeconds;
            if (delta < 60)
            {
                return ts.Seconds == 1 ? "one second ago" : ts.Seconds + " seconds ago";
            }
            if (delta < 120)
            {
                return "a minute ago";
            }
            if (delta < 2700) // 45 * 60
            {
                return ts.Minutes + " minutes ago";
            }
            if (delta < 5400) // 90 * 60
            {
                return "an hour ago";
            }
            if (delta < 86400) // 24 * 60 * 60
            {
                return ts.Hours + " hours ago";
            }
            if (delta < 172800) // 48 * 60 * 60
            {
                return "yesterday";
            }
            if (delta < 2592000) // 30 * 24 * 60 * 60
            {
                return ts.Days + " days ago";
            }
            if (delta < 31104000)
            {
                int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? "one month ago" : months + " months ago";
            }
            var years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
            return years <= 1 ? "one year ago" : years + " years ago";
        }

        /// <summary>
        /// Gets a readable date that looks pretty (e.g. 2 minutes ago, 6 hours ago etc.)
        /// </summary>
        /// <param name="date">Date to check</param>
        /// <returns>Readable date</returns>
        public static string ToPrettyDate(this DateTime date)
        {
            TimeSpan ts = DateTime.Now.Subtract(date);
            int totalDays = (int)ts.TotalDays;
            int totalSecs = (int)ts.TotalSeconds;

            if(totalDays == 0)
            {
                if(totalSecs < 60)
                {
                    return "just now";
                }
                if(totalSecs < 120)
                {
                    return "a minute ago";
                }
                if(totalSecs < 3600)
                {
                    return string.Format("{0} minutes ago", Math.Floor((double)totalSecs / 60));
                }
                if(totalSecs < 7200)
                {
                    return "1 hour ago";
                }
                if(totalSecs < 86400)
                {
                    return string.Format("{0} hours ago", Math.Floor((double)totalSecs / 3600));
                }
            }
            
            if(totalDays == 1)
            {
                return "yesterday";
            }

            if(totalDays < 7)
            {
                return string.Format("{0} days ago", totalDays);
            }

            if(totalDays < 31)
            {
                return string.Format("{0} weeks ago", Math.Ceiling((double)totalDays / 7));
            }

            return "Could not get a readable time";
        }

        /// <summary>
        /// Gets if it is currently a working day
        /// </summary>
        /// <param name="date">Date to check</param>
        /// <returns>True if working day, false if not</returns>
        public static bool WorkingDay(this DateTime date)
        {
            return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
        }

        /// <summary>
        /// Gets if it is a weekend
        /// </summary>
        /// <param name="date">Date to check</param>
        /// <returns>True if weekend, false if not</returns>
        public static bool IsWeekend(this DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }

        /// <summary>
        /// Determines when the next working day is
        /// </summary>
        /// <param name="date">Date to check</param>
        /// <returns>The next working day</returns>
        public static DateTime NextWorkday(this DateTime date)
        {
            var nextDay = date;
            while (!nextDay.WorkingDay())
            {
                nextDay = nextDay.AddDays(1);
            }
            return nextDay;
        }

        /// <summary>
        /// Determine the next date
        /// </summary>
        /// <param name="current">The current date</param>
        /// <param name="dayOfWeek">The day of week</param>
        /// <returns>The next date</returns>
        public static DateTime Next(this DateTime current, DayOfWeek dayOfWeek)
        {
            int offsetDays = dayOfWeek - current.DayOfWeek;
            if (offsetDays <= 0)
            {
                offsetDays += 7;
            }
            DateTime result = current.AddDays(offsetDays);
            return result;
        }
    }
}
