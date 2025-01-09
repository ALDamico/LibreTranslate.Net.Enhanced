using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LibreTranslate.Net.Enhanced.Constants
{
    /// <summary>
    /// The language codes that are supported in the libre translate server
    /// </summary>
    public class LanguageCode
    {
        private static readonly Dictionary<string, LanguageCode> Instance = new Dictionary<string, LanguageCode>();
        private readonly string _code;

        private LanguageCode(string code)
        {
            _code = code;
            Instance[_code] = this;
        }

        public static implicit operator LanguageCode(string str)
        {
            if (Instance.TryGetValue(str, out var result))
            {
                return result;
            }

            var culture = CultureInfo.GetCultures(CultureTypes.SpecificCultures).FirstOrDefault(c =>
                c.TwoLetterISOLanguageName.Equals(str, StringComparison.InvariantCultureIgnoreCase));
            if (culture != null)
            {
                Instance[str] = new LanguageCode(str);
                return Instance[str];
            }

            throw new InvalidCastException();
        }

        public override string ToString()
        {
            return $"{_code}";
        }

        public static readonly LanguageCode English = new LanguageCode("en");
        public static readonly LanguageCode Arabic = new LanguageCode("ar");
        public static readonly LanguageCode Azeri = new LanguageCode("az");
        public static readonly LanguageCode Bulgarian = new LanguageCode("bg");
        public static readonly LanguageCode Bengali = new LanguageCode("bn");
        public static readonly LanguageCode Catalan = new LanguageCode("ca");
        public static readonly LanguageCode German = new LanguageCode("de");
        public static readonly LanguageCode Greek = new LanguageCode("el");
        public static readonly LanguageCode Esperanto = new LanguageCode("eo");
        public static readonly LanguageCode Spanish = new LanguageCode("es");
        public static readonly LanguageCode Estonian = new LanguageCode("et");
        public static readonly LanguageCode Persian = new LanguageCode("fa");
        public static readonly LanguageCode Finnish = new LanguageCode("fi");
        public static readonly LanguageCode French = new LanguageCode("fr");
        public static readonly LanguageCode Irish = new LanguageCode("ga");
        public static readonly LanguageCode Hebrew = new LanguageCode("he");
        public static readonly LanguageCode Hindi = new LanguageCode("hi");
        public static readonly LanguageCode Hungarian = new LanguageCode("hu");
        public static readonly LanguageCode Indonesian = new LanguageCode("id");
        public static readonly LanguageCode Italian = new LanguageCode("it");
        public static readonly LanguageCode Japanese = new LanguageCode("ja");
        public static readonly LanguageCode Korean = new LanguageCode("ko");
        public static readonly LanguageCode Lithuanian = new LanguageCode("lt");
        public static readonly LanguageCode Latvian = new LanguageCode("lv");
        public static readonly LanguageCode Malay = new LanguageCode("ms");
        public static readonly LanguageCode NorwegianBokmal = new LanguageCode("nb");
        public static readonly LanguageCode Dutch = new LanguageCode("nl");
        public static readonly LanguageCode Polish = new LanguageCode("pl");
        public static readonly LanguageCode Portuguese = new LanguageCode("pt");
        public static readonly LanguageCode Romanian = new LanguageCode("ro");
        public static readonly LanguageCode Russian = new LanguageCode("ru");
        public static readonly LanguageCode Slovak = new LanguageCode("sk");
        public static readonly LanguageCode Slovenian = new LanguageCode("sl");
        public static readonly LanguageCode Albanian = new LanguageCode("sq");
        public static readonly LanguageCode Swedish = new LanguageCode("sv");
        public static readonly LanguageCode Thai = new LanguageCode("th");
        public static readonly LanguageCode Tagalog = new LanguageCode("tl");
        public static readonly LanguageCode Turkish = new LanguageCode("tr");
        public static readonly LanguageCode Ukrainian = new LanguageCode("uk");
        public static readonly LanguageCode Urdu = new LanguageCode("ur");
        public static readonly LanguageCode Chinese = new LanguageCode("zh");
        public static readonly LanguageCode ChineseTraditional = new LanguageCode("zt");
        public static readonly LanguageCode AutoDetect = new LanguageCode("auto");
    }
}