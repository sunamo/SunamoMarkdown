### SunamoMarkdown

A wrapper around the [Html2Markdown](https://www.nuget.org/packages/Html2Markdown) library for converting HTML content to Markdown format.

#### Features

- Convert HTML strings to Markdown via `MarkdownHelper.ConvertToMarkDown()`
- Replace paired HTML tags with custom strings via `MarkdownHelper.ReplacePairTag()`

#### Installation

```bash
dotnet add package SunamoMarkdown
```

#### Usage

```csharp
using SunamoMarkdown;

// Convert HTML to Markdown
string markdown = MarkdownHelper.ConvertToMarkDown("<strong>Hello</strong>");
// Result: "**Hello**"

// Replace HTML tags with custom strings
string result = MarkdownHelper.ReplacePairTag("<em>text</em>", "em", "_");
// Result: "_text_"
```

#### Target Frameworks

`net10.0`, `net9.0`, `net8.0`

#### Links

- [NuGet](https://www.nuget.org/profiles/sunamo)
- [GitHub](https://github.com/sunamo/PlatformIndependentNuGetPackages)
- [Developer site](https://sunamo.cz)

Request for new features / bug report / etc: [Mail](mailto:radek.jancik@sunamo.cz) or on GitHub
