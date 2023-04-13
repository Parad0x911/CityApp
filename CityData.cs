//using Java.Lang;
namespace CityApp
{
    public class Constants
    {
        [JsonProprety("types")]
        public static string Types { get; set; }

        [JsonProprety("location")]
        public static string Location { get; set; }

        [JsonProprety("radius")]
        public static int Radius { get; set; }

        [JsonProprety("distanceunit")]
        public static string distanceUnit { get; set; }

        [JsonProprety("countrylds")]
        public static string countrylds { get; set; }

        [JsonProprety("timeZonelds")]
        public static string timezonelds { get; set; }

        [JsonProprety("minPopulation")]
        public static int minpopulation { get; set; }

        [JsonProprety("maxPopulation")]
        public static int maxpopulation { get; set; }

        [JsonProprety("namePrefixDefaultLangResults")]
        public static string nameprefixdefaultlangresults { get; set; }

        [JsonProprety("languageCode")]
        public static string languagecode { get; set; }

        [JsonProprety("asciiMode")]
        public static bool asciimode { get; set; }

        [JsonProprety("hateoasMode")]
        public static bool hateoasmode { get; set; }

        [JsonProprety("includeDeleted")]
        public static string includedeleted { get; set; }

        [JsonProprety("limit")]
        public static int limit { get; set; }

        [JsonProprety("offset")]
        public static int offset { get; set; }

        [JsonProprety("sort")]
        public static string sort { get; set; }
    }
}
