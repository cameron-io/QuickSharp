namespace Lib.ExtensionMethods;

public static class StringExtensions
{
    public static string Shorten(this string str, int numberOfWords)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(numberOfWords);

        if (numberOfWords == 0) return "";

        var words = str.Split(' ');

        if (words.Length <= numberOfWords) return str;

        return string.Join(" ", words.Take(numberOfWords));
    }
}
