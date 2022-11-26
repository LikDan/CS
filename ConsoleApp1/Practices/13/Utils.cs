using System.Globalization;

namespace ConsoleApp1.Practices._13;

internal static class Utils
{
    public static string ToTitleCase(this string text)
    {
        var textInfo = new CultureInfo("en-US", false).TextInfo;
        return textInfo.ToTitleCase(text);  
    }
}