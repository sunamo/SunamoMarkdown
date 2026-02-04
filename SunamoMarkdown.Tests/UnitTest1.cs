namespace SunamoMarkdown.Tests;

/// <summary>
/// Unit tests for the MarkdownHelper class.
/// </summary>
public class MarkdownHelperTests
{
    /// <summary>
    /// Tests the ConvertToMarkDown method with various HTML inputs.
    /// </summary>
    [Fact]
    public void ConvertToMarkDownTest()
    {
        var html = "Something to <strong>convert</strong>";
        string markdown = MarkdownHelper.ConvertToMarkDown(html);

        Assert.NotNull(markdown);
        Assert.NotEmpty(markdown);
        Assert.Contains("**convert**", markdown);

        html = "<!--StartFragment--><span style=\"color: rgb(0, 0, 128); font - family: Arial, Helvetica, sans - serif; font - size: 16px; font - style: normal; font - variant - ligatures: normal; font - variant - caps: normal; font - weight: 400; letter - spacing: normal; orphans: 2; text - align: start; text - indent: 0px; text - transform: none; white - space: normal; widows: 2; word - spacing: 0px; -webkit - text - stroke - width: 0px; background - color: rgb(255, 255, 255); text - decoration - style: initial; text - decoration - color: initial; display: inline !important; float: none; \">They<span>�</span></span><strong style=\"color: rgb(0, 0, 128); font - family: Arial, Helvetica, sans - serif; font - size: 16px; font - style: normal; font - variant - ligatures: normal; font - variant - caps: normal; letter - spacing: normal; orphans: 2; text - align: start; text - indent: 0px; text - transform: none; white - space: normal; widows: 2; word - spacing: 0px; -webkit - text - stroke - width: 0px; background - color: rgb(255, 255, 255); text - decoration - style: initial; text - decoration - color: initial; \">will have completed</strong><span style=\"color: rgb(0, 0, 128); font - family: Arial, Helvetica, sans - serif; font - size: 16px; font - style: normal; font - variant - ligatures: normal; font - variant - caps: normal; font - weight: 400; letter - spacing: normal; orphans: 2; text - align: start; text - indent: 0px; text - transform: none; white - space: normal; widows: 2; word - spacing: 0px; -webkit - text - stroke - width: 0px; background - color: rgb(255, 255, 255); text - decoration - style: initial; text - decoration - color: initial; display: inline !important; float: none; \"><span>�</span>the project before the deadline.</span><!--EndFragment-->";
        markdown = MarkdownHelper.ConvertToMarkDown(html);

        Assert.NotNull(markdown);
        Assert.NotEmpty(markdown);
    }

    /// <summary>
    /// Tests the ReplacePairTag method for replacing HTML tags with markdown equivalents.
    /// </summary>
    [Fact]
    public void ReplacePairTagTest()
    {
        var input = "<strong>Bold text</strong>";
        var result = MarkdownHelper.ReplacePairTag(input, "strong", "**");

        Assert.Equal("**Bold text**", result);

        input = "<i>Italic text</i>";
        result = MarkdownHelper.ReplacePairTag(input, "i", "_");

        Assert.Equal("_Italic text_", result);
    }
}
