namespace SunamoMarkdown;

/// <summary>
/// Helper class for converting HTML to Markdown format.
/// </summary>
public class MarkdownHelper
{
    /// <summary>
    /// Converts HTML to Markdown format.
    /// Uses Html2Markdown which has dependency HtmlAgilityPack 1.5.
    /// Therefore I can't replace with standard 1.11.2 and can't compile these projects.
    /// Therefore commented and removed nuget package.
    /// </summary>
    /// <param name="html">The HTML string to convert.</param>
    /// <returns>The converted Markdown string.</returns>
    public static string ConvertToMarkDown(string html)
    {
        var converter = new Converter();
        var markdown = converter.Convert(html);
        return markdown;
    }

    /// <summary>
    /// Replaces opening and closing HTML tags with specified replacement string.
    /// </summary>
    /// <param name="input">The input string containing HTML tags.</param>
    /// <param name="tag">The HTML tag name to replace (without angle brackets).</param>
    /// <param name="replacement">The string to replace the tags with.</param>
    /// <returns>The string with replaced tags.</returns>
    public static string ReplacePairTag(string input, string tag, string replacement)
    {
        input = input.Replace("<" + tag + ">", replacement);
        input = input.Replace("<" + tag + " ", replacement);
        input = input.Replace("</" + tag + ">", replacement);
        return input;
    }
}