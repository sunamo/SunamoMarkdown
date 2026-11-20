namespace SunamoMarkdown;

/// <summary>
/// Represents the markdown helper type.
/// </summary>
public class MarkdownHelper
{
    // Converts HTML to Markdown format.
    // Uses Html2Markdown which has dependency HtmlAgilityPack 1.5.
    // Therefore I can't replace with standard 1.11.2 and can't compile these projects.
    // Therefore commented and removed nuget package.
    /// <summary>
    /// Convert to mark down.
    /// </summary>
    /// <param name="html">The html.</param>
    /// <returns>The convert to mark down result.</returns>
    public static string ConvertToMarkDown(string html)
    {
        var converter = new Converter();
        var markdown = converter.Convert(html);
        return markdown;
    }

    /// <summary>
    /// Replace pair tag.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="tag">The tag.</param>
    /// <param name="replacement">The replacement.</param>
    /// <returns>The replace pair tag result.</returns>
    public static string ReplacePairTag(string text, string tag, string replacement)
    {
        text = text.Replace("<" + tag + ">", replacement);
        text = text.Replace("<" + tag + " ", replacement);
        text = text.Replace("</" + tag + ">", replacement);
        return text;
    }
}