namespace UsefulStuffPortable.Utilities
{
    public static class Utilities
    {
        static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        /// <summary>
        /// Converts a value into a certain size with a suffix leading it
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <returns>New value with suffix</returns>
        public static string SizeSuffix(long value)
        {
            if(value < 0) { return "-" + SizeSuffix(-value); }
            if(value == 0) { return "0.0 bytes"; }

            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
        }

        /// <summary>
        /// Gets a random letter
        /// </summary>
        /// <param name="upper">Should the letter be uppercase</param>
        /// <returns>Random letter</returns>
        public static char GetRandomLetter(bool upper = false)
        {
            Random rnd = new Random();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            return upper ? char.ToUpper(Convert.ToChar(alphabet[rnd.Next(alphabet.Length)])) : Convert.ToChar(alphabet[rnd.Next(alphabet.Length)]);
        }
    }
}
