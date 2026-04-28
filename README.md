# LibreTranslate.Net.Enhanced
## An enhanced fork of LibreTranslate.Net

[![NuGet version](https://img.shields.io/nuget/v/LibreTranslate.Net.Enhanced?style=flat-square&logo=nuget)](https://www.nuget.org/packages/LibreTranslate.Net.Enhanced)
[![NuGet downloads](https://img.shields.io/nuget/dt/LibreTranslate.Net.Enhanced?style=flat-square&logo=nuget)](https://www.nuget.org/packages/LibreTranslate.Net.Enhanced)
[![CI](https://img.shields.io/github/actions/workflow/status/ALDamico/LibreTranslate.Net.Enhanced/ci.yml?style=flat-square&logo=github&label=CI)](https://github.com/ALDamico/LibreTranslate.Net.Enhanced/actions/workflows/ci.yml)
[![License](https://img.shields.io/github/license/ALDamico/LibreTranslate.Net.Enhanced?style=flat-square)](LICENSE)

## Why this fork?

[LibreTranslate.Net](https://www.nuget.org/packages/LibreTranslate.Net) is an unofficial .NET client for LibreTranslate that has been abandoned and is no longer maintained. This fork picks up where it left off, adding new features and keeping up with the LibreTranslate API.

If you are migrating from `LibreTranslate.Net`, simply replace the package reference — the API is backwards compatible.

## Prerequisites

You need a running [LibreTranslate](https://github.com/LibreTranslate/LibreTranslate) instance. You can use the public instance at `https://libretranslate.com` (API key required) or run your own:

```bash
docker run -p 5000:5000 libretranslate/libretranslate
```

## Installation

**Package Manager Console**
```
Install-Package LibreTranslate.Net.Enhanced
```

**dotnet CLI**
```
dotnet add package LibreTranslate.Net.Enhanced
```

**PackageReference**
```xml
<PackageReference Include="LibreTranslate.Net.Enhanced" Version="1.9.5.1" />
```

## Usage

### With Dependency Injection (recommended)

```csharp
// Program.cs / Startup.cs
services.AddLibreTranslate(opt =>
{
    opt.Url = "https://libretranslate.com";
    opt.ApiKey = "your-api-key";
});
```

```csharp
// Inject LibreTranslate where needed
public class MyService(LibreTranslate libreTranslate)
{
    public async Task<string> TranslateAsync(string text)
    {
        return await libreTranslate.TranslateAsync(new Translate
        {
            Source = LanguageCode.English,
            Target = LanguageCode.Spanish,
            Text = text
        });
    }
}
```

### Without Dependency Injection

```csharp
using LibreTranslate.Net.Enhanced;
using LibreTranslate.Net.Enhanced.Constants;
using LibreTranslate.Net.Enhanced.Models;

var libreTranslate = new LibreTranslate("https://libretranslate.com", "your-api-key");

string spanishText = await libreTranslate.TranslateAsync(new Translate
{
    Source = LanguageCode.English,
    Target = LanguageCode.Spanish,
    Text = "Hello World!"
});

Console.WriteLine(spanishText); // ¡Hola Mundo!
```

## API Reference

```csharp
// Get all languages supported by the server
Task<IEnumerable<SupportedLanguages>> GetSupportedLanguagesAsync();

// Translate text
Task<string> TranslateAsync(Translate translate);

// Translate a batch of texts
Task<TranslationBatchResponse> TranslateAsync(TranslateBatch batch);

// Detect the language of a text
Task<List<DetectResponse>> DetectAsync(Detect detect);
Task<string> DetectAsStringAsync(Detect detect);

// Translate a file
Task<TranslationResponse> TranslateFileAsync(TranslateFile translateFile);

// Submit a translation suggestion
Task<bool> SuggestAsync(Suggestion suggestion);

// Get server frontend settings
Task<FrontendSettingsResponse> FrontendSettingsAsync();
```

## Language Codes

`LanguageCode` supports implicit conversion from string, so you can use any ISO 639-1 code directly, even if it's not listed as a built-in constant:

```csharp
LanguageCode lang = "zt"; // Chinese Traditional
LanguageCode custom = "nb"; // Norwegian Bokmål
```

Language|Code
-|-
Auto Detect|`LanguageCode.AutoDetect`
Albanian|`LanguageCode.Albanian`
Arabic|`LanguageCode.Arabic`
Azeri|`LanguageCode.Azeri`
Bengali|`LanguageCode.Bengali`
Bulgarian|`LanguageCode.Bulgarian`
Catalan|`LanguageCode.Catalan`
Chinese|`LanguageCode.Chinese`
Chinese (Traditional)|`LanguageCode.ChineseTraditional`
Dutch|`LanguageCode.Dutch`
English|`LanguageCode.English`
Esperanto|`LanguageCode.Esperanto`
Estonian|`LanguageCode.Estonian`
Finnish|`LanguageCode.Finnish`
French|`LanguageCode.French`
German|`LanguageCode.German`
Greek|`LanguageCode.Greek`
Hebrew|`LanguageCode.Hebrew`
Hindi|`LanguageCode.Hindi`
Hungarian|`LanguageCode.Hungarian`
Indonesian|`LanguageCode.Indonesian`
Irish|`LanguageCode.Irish`
Italian|`LanguageCode.Italian`
Japanese|`LanguageCode.Japanese`
Korean|`LanguageCode.Korean`
Latvian|`LanguageCode.Latvian`
Lithuanian|`LanguageCode.Lithuanian`
Malay|`LanguageCode.Malay`
Norwegian (Bokmål)|`LanguageCode.NorwegianBokmal`
Persian|`LanguageCode.Persian`
Polish|`LanguageCode.Polish`
Portuguese|`LanguageCode.Portuguese`
Romanian|`LanguageCode.Romanian`
Russian|`LanguageCode.Russian`
Slovak|`LanguageCode.Slovak`
Slovenian|`LanguageCode.Slovenian`
Spanish|`LanguageCode.Spanish`
Swedish|`LanguageCode.Swedish`
Tagalog|`LanguageCode.Tagalog`
Thai|`LanguageCode.Thai`
Turkish|`LanguageCode.Turkish`
Ukrainian|`LanguageCode.Ukrainian`
Urdu|`LanguageCode.Urdu`
