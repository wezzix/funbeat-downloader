using System.Globalization;

namespace MK.Funbeat.Utilities
{
    public static class NumberParser
    {
        public static decimal? TryParseDecimal(string text)
        {
            decimal result;
            return decimal.TryParse(
                text.Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out result)
                ? result
                : (decimal?)null;
        }

        public static int? TryParseInt(string text)
        {
            int result;
            return int.TryParse(text, out result)
                ? result
                : (int?)null;
        }
    }
}