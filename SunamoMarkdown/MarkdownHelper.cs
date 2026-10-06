namespace SunamoMarkdown;

public class MarkdownHelper
{
    // Converts HTML to Markdown format.
    // Uses Html2Markdown which has dependency HtmlAgilityPack 1.5.
    // Therefore I can't replace with standard 1.11.2 and can't compile these projects.
    // Therefore commented and removed nuget package.
    public static string ConvertToMarkDown(string html)
    {
        var converter = new Converter();
        var markdown = converter.Convert(html);
        return markdown;
    }

    public static string ReplacePairTag(string text, string tag, string replacement)
    {
        text = text.Replace("<" + tag + ">", replacement);
        text = text.Replace("<" + tag + " ", replacement);
        text = text.Replace("</" + tag + ">", replacement);
        return text;
    }
}