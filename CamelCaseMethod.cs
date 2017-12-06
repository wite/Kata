using System.Globalization;
namespace Kata
{
    public static class Problem
    {
        public static string CamelCase(this string str)
        {
            TextInfo text = CultureInfo.CurrentCulture.TextInfo;
            return text.ToTitleCase(str.ToLower()).Replace(" ", "");
        }
    }
}