# SunamoMarkdown

A wrapper around the [Html2Markdown](https://www.nuget.org/packages/Html2Markdown) library for converting HTML content to Markdown format.

## Overview

SunamoMarkdown is part of the Sunamo package ecosystem, providing modular, platform-independent utilities for .NET development.

## Main Components

### Key Classes

- **MarkdownHelper** - Static helper class for HTML-to-Markdown conversion

### Key Methods

- `ConvertToMarkDown(string html)` - Converts HTML string to Markdown format
- `ReplacePairTag(string text, string tag, string replacement)` - Replaces paired HTML tags with a custom string

## Installation

```bash
dotnet add package SunamoMarkdown
```

## Dependencies

- **Html2Markdown** (v7.1.2.20)
- **Microsoft.Extensions.Logging.Abstractions** (v10.0.2)

## Package Information

- **Package Name**: SunamoMarkdown
- **Target Frameworks**: net10.0; net9.0; net8.0
- **Category**: Platform-Independent NuGet Package
- **License**: MIT

## Related Packages

This package is part of the Sunamo package ecosystem. For more information about related packages, visit the [main repository](https://github.com/sunamo/PlatformIndependentNuGetPackages).

## License

See the repository root for license information.
