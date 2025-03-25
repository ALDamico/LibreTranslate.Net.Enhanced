# LibreTranslate.Net.Enhanced
## An enhanced fork of LibreTranslate.Net
<p>
	<a href="https://www.nuget.org/packages/LibreTranslate.Net.Enhanced">
	    <img src="https://buildstats.info/nuget/LibreTranslate.Net.Enhanced?v=1.6.0" />
	</a>
</p>

### Installation
`Install-Package LibreTranslate.Net.Enhanced -Version 1.6.4`
### Using
```csharp
using LibreTranslate.Net;
```
### Usage
```csharp
var LibreTranslate = new LibreTranslate();
System.Collections.Generic.IEnumerable<SupportedLanguages> SupportedLanguages = await LibreTranslate.GetSupportedLanguagesAsync();
System.Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(supportedLanguages, Newtonsoft.Json.Formatting.Indented));
var englishText = "Hello World!";
string spanishText = await LibreTranslate.TranslateAsync(new Translate() {
    ApiKey = "MySecretApiKey",
    Source = LanguageCode.English,
    Target = LanguageCode.Spanish,
    Text = englishText
});
System.Console.WriteLine(spanishText);
```
### Output:
```
Hello World!
¡Hola Mundo!
```
### Custom LibreTranslate URL (style: `http[s]://url` with no trailing `/`):
```csharp
var LibreTranslate = new LibreTranslate("https://server_url");
```
### LibreTranslate Methods
```csharp
Task<IEnumerable<SupportedLanguages>> GetSupportedLanguagesAsync();
Task<string> TranslateAsync(Translate translate);
```
### Language codes
Language|Code
-|-
English|`LanguageCode.English`
Arabic|`LanguageCode.Arabic`
Chinese|`LanguageCode.Chinese`
French|`LanguageCode.French`
German|`LanguageCode.German`
Hindi|`LanguageCode.Hindi`
Irish|`LanguageCode.Irish`
Italian|`LanguageCode.Italian`
Japanese|`LanguageCode.Japanese`
Korean|`LanguageCode.Korean`
Portuguese|`LanguageCode.Portuguese`
Russian|`LanguageCode.Russian`
Spanish|`LanguageCode.Spanish`
AutoDetect|`LanguageCode.AutoDetect`
Azeri\*|`LanguageCode.Azeri`
Bulgarian\*|`LanguageCode.Bulgarian`
Bengali\*|`LanguageCode.Bengali`
Catalan\*|`LanguageCode.Catalan`
Greek\*|`LanguageCode.Greek`
Esperanto\*|`LanguageCode.Esperanto`
Estonian\*|`LanguageCode.Estonian`
Persian\*|`LanguageCode.Persian`
Finnish\*|`LanguageCode.Finnish`
Irish\*|`LanguageCode.Irish`
Hebrew\*|`LanguageCode.Hebrew`
Hungarian\*|`LanguageCode.Hungarian`
Indonesian\*|`LanguageCode.Indonesian`
Lithuanian\*|`LanguageCode.Lithuanian`
Latvian\*|`LanguageCode.Latvian`
Malay\*|`LanguageCode.Malay`
Norwegian (Bokmål)\*|`LanguageCode.NorwegianBokmal`
Dutch\*|`LanguageCode.Dutch`
Polish\*|`LanguageCode.Polish`
Romanian\*|`LanguageCode.Romanian`
Slovak\*|`LanguageCode.Slovak`
Slovenian\*|`LanguageCode.Slovenian`
Albanian\*|`LanguageCode.Albanian`
Swedish\*|`LanguageCode.Swedish`
Thai\*|`LanguageCode.Thai`
Tagalog\*|`LanguageCode.Tagalog`
Turkish\*|`LanguageCode.Turkish`
Ukrainian\*|`LanguageCode.Ukrainian`
Urdu\*|`LanguageCode.Urdu`
Chinese (traditional)\*|`LanguageCode.ChineseTraditional`

> \* = Added with version 1.6.0
